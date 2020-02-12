using System;
using System.Collections.Generic;
using System.Text;

namespace Pengeinstitut
{
    class AddAccount : AddCustomer
    {
        public int Accountnumber { get; set; } = 0;

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

        public void CreateAccount(List<AddCustomer> customerList)
        {
            Console.WriteLine("\nCreate account");

            Console.WriteLine("Which customer do you want to create an account for?\n");
            foreach(AddCustomer c in customerList)
            {
                Console.WriteLine($"{c.Name} {c.Cpr}");
            }
            Console.WriteLine();
            Console.Write("Select an option(cpr): ");
            double choose = Convert.ToDouble(Console.ReadLine());
            AddCustomer currentCustomer = FindCustomerByCpr(customerList, choose);
            Console.WriteLine();
           
            Console.WriteLine($"Thank you for creating an account {currentCustomer.Name}. The account number to your new account is {Accountnumber}");
            

            Console.WriteLine("Press enter to go back");
            Console.ReadLine();
        }
    }
}
