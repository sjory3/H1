using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace Texas_burger
{
    class LDAP
    {
        private static LDAP client1 = new LDAP();

        public DirectoryEntry CreateDirectoryEntry()
        {
            DirectoryEntry ldapConnection = new DirectoryEntry("172.16.1.131", "root", "MCBpower123");
            return ldapConnection;
        }

        public SearchResult SearchAllFromOne(String username)
        {
            DirectorySearcher search = new DirectorySearcher(client1.CreateDirectoryEntry());
            search.Filter = "(samaccountname=" + username + ")";
            SearchResult result = search.FindOne();
            return result;
        }
    }
}
