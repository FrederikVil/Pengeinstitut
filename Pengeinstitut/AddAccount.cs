using System;
using System.Collections.Generic;
using System.Text;

namespace Pengeinstitut
{
    class AddAccount : AddCustomer
    {

        public long Accountnumber { get; set; }

        // En metode der tjekker om man skriver et tal der svarer til et af CPR nummrene på listen.
        private AddCustomer FindCustomerByCpr(List<AddCustomer> customerList, double choose)
        {
            foreach (AddCustomer c in customerList)
            {
                if (c.Cpr == choose)
                {
                    return c;
                }
            }
            return null;
        }

        // Jeg har min liste over costumers, hvor jeg looper igennem dem alle og printer deres navn og CPR ud.
        public void CreateAccount(List<AddCustomer> customerList)
        {
            Console.WriteLine("\nCreate account");

            Console.WriteLine("Which customer do you want to create an account for?\n");
            foreach(AddCustomer c in customerList)
            {
                Console.WriteLine($"Name: {c.Name} CPR: {c.Cpr}");
            }
            Console.WriteLine();
            Console.Write("Select an option(cpr): ");
            long choose = Convert.ToInt64(Console.ReadLine());
            // Currentcustomer er det CPR nummer man lige har skrevet ind.
            AddCustomer currentCustomer = FindCustomerByCpr(customerList, choose);
            Console.WriteLine();
           
            Console.WriteLine($"Thank you for creating an account {currentCustomer.Name}. The account number to your new account is {Accountnumber = currentCustomer.Cpr - 1}");
            
            Console.WriteLine("Press enter to go back");
            Console.ReadLine();
        }
    }
}
