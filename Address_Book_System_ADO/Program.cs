using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Address Book System ADO.NET");

            AddressBookManagement addressBookManagement = new AddressBookManagement();
            addressBookManagement.GetAllContact(); //UC2
            Console.ReadLine();
        }
    }
}
