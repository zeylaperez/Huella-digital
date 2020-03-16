using HuellaDactilar.Controller;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using libzkfpcsharp;
using ZKSoftwareAPI;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;


namespace HuellaDactilar
{
    public partial class AddHuella : Form
    {
        private string huella64 = string.Empty;
        private string[] marcas = new string[10];
        private int dedo;
        private Int64 idPersona;
        private string numTargeta;
        private string nombre;
        private string apellidos;
        private bool flag = true;
        private GestionarHuella gestionarHuella;
        private clsData clsConexion;
        private string permiso;

        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        byte[] FPBuffer;
        int RegisterCount = 0;
        const int REGISTER_FINGER_COUNT = 3;

        byte[][] RegTmps = new byte[3][];
        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];

        int cbCapTmp = 2048;
        int cbRegTmp = 0;
        int iFid = 1;

        private int mfpWidth = 0;
        private int mfpHeight = 0;
        private int mfpDpi = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]

        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        public AddHuella(string[] Marcas, int Dedo, Int64 ID, string Targeta, string Nombre, string Apellidos, string Permiso)
        {
            InitializeComponent();
            marcas = Marcas;
            dedo = Dedo;
            idPersona = ID;
            numTargeta = Targeta;
            nombre = Nombre;
            apellidos = Apellidos;
            permiso = Permiso;
        }

        ZKSoftware reloj = new ZKSoftware(Modelo.X628C);

        private void AddHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            gestionarHuella = new GestionarHuella(flag, idPersona);
            gestionarHuella.Show();
            this.Hide();
        }

        private void AddHuella_Load(object sender, EventArgs e)
        {
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nombre + " es un " + permiso);
            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
            {
                int nCount = zkfp2.GetDeviceCount();
                if (nCount == 1)
                {
                    if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(nCount - 1)))
                    {
                        MessageBox.Show("OpenDevice fail");
                        return;
                    }
                    if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
                    {
                        MessageBox.Show("Init DB fail");
                        zkfp2.CloseDevice(mDevHandle);
                        mDevHandle = IntPtr.Zero;
                        return;
                    }
                    picFPImg.Enabled = true;
                    btn_Conectar.Enabled = false;
                    btn_Desconectar.Enabled = true;

                    for (int i = 0; i < 3; i++)
                    {
                        RegTmps[i] = new byte[2048];
                    }
                    byte[] paramValue = new byte[4];
                    int size = 4;
                    zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
                    zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

                    size = 4;
                    zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
                    zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

                    FPBuffer = new byte[mfpWidth * mfpHeight];

                    size = 4;
                    zkfp2.GetParameters(mDevHandle, 3, paramValue, ref size);
                    zkfp2.ByteArray2Int(paramValue, ref mfpDpi);

                    Thread captureThread = new Thread(new ThreadStart(DoCapture));
                    captureThread.IsBackground = true;
                    captureThread.Start();
                    bIsTimeToDie = false;
                }
                else
                {
                    zkfp2.Terminate();
                    MessageBox.Show("El dispositivo no está conectado");
                }
            }
            else
            {
                MessageBox.Show("Fallo en la iniciialización del lector de huellas, ret=" + ret + " !");
            }
        }

        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                    IsRegister = true;
                    FingerPrint();
                }
                Thread.Sleep(200);
            }
        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = true;
            RegisterCount = 0;
            Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            zkfp2.Terminate();

            btn_Desconectar.Enabled = false;
            btn_Conectar.Enabled = true;
        }

        private void Img_Huella_Click(object sender, EventArgs e)
        {

        }

        private void FingerPrint()
        {
            MemoryStream ms = new MemoryStream();
            BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
            Bitmap bmp = new Bitmap(ms);
            this.picFPImg.Image = bmp;


            String strShow = zkfp2.BlobToBase64(CapTmp, cbCapTmp);

            if (IsRegister)
            {
                int ret = zkfp.ZKFP_ERR_OK;
                int fid = 0, score = 0;
                ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                if (zkfp.ZKFP_ERR_OK == ret)
                {
                    MessageBox.Show("Este dedo ya está registrado por " + fid + "!\n");
                    return;
                }

                if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                {
                    MessageBox.Show("Por favor presione el mismo dedo 3 veces para enrolarlo.\n");
                    return;
                }

                Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);
                String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                byte[] blob = zkfp2.Base64ToBlob(strBase64);
                RegisterCount++;
                if (RegisterCount >= REGISTER_FINGER_COUNT)
                {
                    RegisterCount = 0;
                    if (zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBMerge(mDBHandle, RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref cbRegTmp)) &&
                            zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBAdd(mDBHandle, iFid, RegTmp)))
                    {
                        iFid++;
                        String huellaBase64 = Convert.ToBase64String(RegTmp);
                        GuardarHuella(huellaBase64);
                        //MessageBox.Show("enroll succ\n");
                    }
                    else
                    {
                        MessageBox.Show("Fallo al enrolar la huella, error code=" + ret + "\n");
                    }
                    IsRegister = false;
                    return;
                }
                else
                {
                    if (REGISTER_FINGER_COUNT - RegisterCount == 1)
                        MessageBox.Show("Ud debe presionar su dedo " + (REGISTER_FINGER_COUNT - RegisterCount) + " vez\n");
                    else
                        MessageBox.Show("Ud debe presionar su dedo " + (REGISTER_FINGER_COUNT - RegisterCount) + " veces\n");
                }
            }
            else
            {
                if (cbRegTmp <= 0)
                {
                    MessageBox.Show("Please register your finger first!\n");
                    return;
                }
                if (bIdentify)
                {
                    int ret = zkfp.ZKFP_ERR_OK;
                    int fid = 0, score = 0;
                    ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                    if (zkfp.ZKFP_ERR_OK == ret)
                    {
                        MessageBox.Show("Identify succ, fid= " + fid + ",score=" + score + "!\n");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Identify fail, ret= " + ret + "\n");
                        return;
                    }
                }
                else
                {
                    int ret = zkfp2.DBMatch(mDBHandle, CapTmp, RegTmp);
                    if (0 < ret)
                    {
                        MessageBox.Show("Match finger succ, score=" + ret + "!\n");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Match finger fail, ret= " + ret + "\n");
                        return;
                    }
                }

            }
        }

        private void btCaptureBmp_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "fingertemplate.bmp";
            saveFileDialog1.RestoreDirectory = true;

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName.ToString();
                if (fileName != "" && fileName != null && picFPImg.Image != null)
                {
                    //http://www.wischik.com/lu/programmer/1bpp.html
                    Bitmap bmp = new Bitmap(picFPImg.Image.Width, picFPImg.Image.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(picFPImg.Image, 0, 0, bmp.Width, bmp.Height);

                    }
                    Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                    System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
                    IntPtr ptr = bmpData.Scan0;
                    int bytes = bmpData.Stride * bmpData.Height;
                    byte[] rgbValues = new byte[bytes];
                    System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
                    Rectangle rect2 = new Rectangle(0, 0, bmp.Width, bmp.Height);

                    Bitmap bit = new Bitmap(bmp.Width, bmp.Height, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
                    System.Drawing.Imaging.BitmapData bmpData2 = bit.LockBits(rect2, System.Drawing.Imaging.ImageLockMode.ReadWrite, bit.PixelFormat);
                    IntPtr ptr2 = bmpData2.Scan0;
                    int bytes2 = bmpData2.Stride * bmpData2.Height;
                    byte[] rgbValues2 = new byte[bytes2];
                    System.Runtime.InteropServices.Marshal.Copy(ptr2, rgbValues2, 0, bytes2);
                    double colorTemp = 0;
                    for (int i = 0; i < bmpData.Height; i++)
                    {
                        for (int j = 0; j < bmpData.Width * 3; j += 3)
                        {
                            colorTemp = rgbValues[i * bmpData.Stride + j + 2] * 0.299 + rgbValues[i * bmpData.Stride + j + 1] * 0.578 + rgbValues[i * bmpData.Stride + j] * 0.114;
                            rgbValues2[i * bmpData2.Stride + j / 3] = (byte)colorTemp;
                        }
                    }
                    System.Runtime.InteropServices.Marshal.Copy(rgbValues2, 0, ptr2, bytes2);
                    bmp.UnlockBits(bmpData);
                    ColorPalette tempPalette;
                    {
                        using (Bitmap tempBmp = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format8bppIndexed))
                        {
                            tempPalette = tempBmp.Palette;
                        }
                        for (int i = 0; i < 256; i++)
                        {
                            tempPalette.Entries[i] = Color.FromArgb(i, i, i);
                        }
                        bit.Palette = tempPalette;
                    }
                    bit.UnlockBits(bmpData2);

                    bit.Save(fileName, picFPImg.Image.RawFormat);

                    bit.Dispose();
                }
            }
        }

        private void AddHuella_Closing(object sender, EventArgs e)
        {
            zkfp2.CloseDevice(mDevHandle);
            zkfp2.Terminate();
        }

        private void GuardarHuella(string huella64)
        {
            if (marcas.Length >= dedo)
                marcas[dedo] = huella64;
            else
            {
                for (int i = 0; i < dedo; i++)
                    marcas[i] += ",";
                marcas[dedo] = huella64;
            }
            gestionarHuella = new GestionarHuella(false, 0);
            clsConexion = new clsData();
            if (clsConexion.insertData(idPersona, numTargeta, gestionarHuella.unirHuellas(marcas), nombre, apellidos, permiso))
            {
                MessageBox.Show("Huella insertada correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
