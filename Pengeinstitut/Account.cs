using System;
using System.Collections.Generic;
using System.Text;

namespace Pengeinstitut
{
    class Account
    {

        public double Balance { get; set; }
        public double Interestrate { get; set; }

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

        public void ShowAccount(List<AddCustomer> customerList, List<AddAccount> accountList)
        {
            Console.WriteLine("\nShow accounts");

            Console.WriteLine("Which customer do you want to see?\n");

            foreach (AddCustomer c in customerList)
            {
                Console.WriteLine($"Name: {c.Name} CPR: {c.Cpr}");
            }
            Console.WriteLine();
            Console.Write("Select an option(cpr): ");
            long choose = Convert.ToInt64(Console.ReadLine());
            AddCustomer currentCustomer = FindCustomerByCpr(customerList, choose);
            Console.WriteLine();

            Console.WriteLine($"Showing accounts for {currentCustomer.Name}\n");

            foreach (AddAccount a in accountList)
            {
                if (currentCustomer.Cpr == a.Accountnumber + 1)
                {
                    Console.WriteLine($"Account number: {a.Accountnumber}");
                }
                
            }

            Console.WriteLine("Press enter to go back");
            Console.ReadLine();
        }
    }
}
