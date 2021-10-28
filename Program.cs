using System;

namespace AddressBookPayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            AddressBookPayrollService repo = new AddressBookPayrollService();

            AddressBookPayrollService model = new AddressBookPayrollService();


            model.AddressBook1FirstName = "navya";
            model.AddressBook1City = "Pune";
                model.AddressBook1Age = 34;
            

          
            repo.GetAllAddress();




        }



    }
    }

