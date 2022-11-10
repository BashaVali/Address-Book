using System;

namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");

            ContactDetails contactDetails = new ContactDetails();

            AddContact addContact = new AddContact();
            addContact.EnterInput();
            addContact.ViewTheDetails();

            EditContactDetails editDetails = new EditContactDetails();
            editDetails.Edit();
        }
    }
}