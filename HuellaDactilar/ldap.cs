using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaDactilar
{
    class ldap
    {
        public void ldap_connect(string hostname = null, int port = 389) { }
        public void ldap_close(string link_identifier) { }
        public void ldap_bind(string link_identifier, string bind_rdn, string bind_password) { }
        public void ldap_unbind(string link_identifier) { }

    }
}
