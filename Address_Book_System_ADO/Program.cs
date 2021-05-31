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

            //addressBookManagement.DataBaseConnection(); //UC1
            //addressBookManagement.GetAllContact(); //UC2
            AddNewContactDetails(); //UC3

            Console.ReadLine();
        }
        // UC3:- Ability to insert new Contacts to Address Book 
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Kartik";
            model.LastName = "singh";
            model.Address = "Mumbai";
            model.City = "Mumbai";
            model.State = "Maharashtra";
            model.Zip = "412104";
            model.PhoneNumber = "2635145678";
            model.EmailId = "himanshu@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "Himanshu";

            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }
}
