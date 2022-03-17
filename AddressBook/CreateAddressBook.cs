using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class CreateAddressBook
    {

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }

        //Method to display Contact.
        public void displayContact()
        {
            Console.WriteLine("FirstName: " + this.FirstName + " LastName: " + this.LastName
                            + " Address: " + this.Address + " City: " + this.City + " State: "
                            + this.State + " Zip: " + this.Zip + " PhoneNumber: "
                            + this.PhoneNumber + " Email: " + this.Email);
        }
        //Method to Add Contact in a List.
        public void AddContact()
        {
            Console.Write("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email \n");
            CreateAddressBook addressBook = new CreateAddressBook()  //Initializing elements using collection-initializer syntax
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };

            //creating a List to store contacts in List.
            IList<CreateAddressBook> AddreddBookList = new List<CreateAddressBook>();  //created List of class Type.
            AddreddBookList.Add(addressBook);
            addressBook.displayContact();
        }
        AddressBookMain addressMain = new AddressBookMain();
        //created List of class Type.
        public void ReadInput()
        {
            bool CONTINUE = true;

            //the loop continues until the user exit from program.
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Add contacts");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Edit Details");
                Console.WriteLine("4.Delete Person");
                Console.WriteLine("5.Add Multiple Person");
                Console.WriteLine("0.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddDetails(addressMain);
                        break;
                    case 2:
                        addressMain.DisplayContact();
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name of person");
                        string name = Console.ReadLine();
                        addressMain.EditContact(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter the first name of person");
                        string dName = Console.ReadLine();
                        addressMain.DeleteContact(dName);
                        break;
                    case 5:
                        AddMultiplePerson();
                        break;
                    case 0:
                        CONTINUE = false;
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// This method is used to add a new contact.
        /// </summary>
        /// <param name="addressBookMain"></param>
        public static void AddDetails(AddressBookMain addressMain)
        {
            Console.WriteLine("Enter first Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            long zipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            addressMain.AddContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }
        //Method to Add Multiple Contact
        public void AddMultiplePerson()
        {
            Console.WriteLine("How many contact,you want to Add");
            int cNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cNumber; i++)
            {
                CreateAddressBook.AddDetails(addressMain);
            }
            Console.WriteLine("All Contacts Added successfully! \n");
        }
    }
}
