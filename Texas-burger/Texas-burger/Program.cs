using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;

namespace Texas_burger
{
    class Program
    {
        static void Main(string[] args)
        {
            LDAP ldap = new LDAP();

            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            Console.WriteLine(ldap.SearchAllFromOne(username));
            Console.ReadKey();
        }
    }
}