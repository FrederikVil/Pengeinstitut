using System;
using System.Collections.Generic;
using System.Text;

namespace Pengeinstitut
{
    class Account
    {

        public  int Accountnumber { get; set; }
        public double Balance { get; set; }
        public double Interestrate { get; set; }
        public static int AccountCounter = 0;

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

        // Hver gang ny konto laves, får den et højere nummer.
        public  Account()
        {
            AccountCounter++;
            Accountnumber = AccountCounter;
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

            // Printer current customer accounts ud.
            foreach (Account a in currentCustomer.Accounts)
            {
                Console.WriteLine($"Account number: {a.Accountnumber}");

            }
            Console.WriteLine("\nPress enter to go back");
            Console.ReadLine();
        }
    }
}
