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
            Console.WriteLine(addressBookManagement.DeleteContactUsingName("Himanshu", "kholiya") ? "Delete Record successfully\n" : "Delete failed"); //UC5
            Console.ReadLine();
        }
    
        // UC3:- Ability to insert new Contacts to Address Book 
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Vishal";
            model.LastName = "Singh";
            model.Address = "Bhandup";
            model.City = "Mumbai";
            model.State = "Maharashtra";
            model.Zip = "412105";
            model.PhoneNumber = "66663629";
            model.EmailId = "vishal@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "Himanshu";

            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }
}