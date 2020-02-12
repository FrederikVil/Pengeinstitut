using System;
using System.Collections.Generic;

namespace Pengeinstitut
{
    class Program
    {
        private static bool LoopContinue { get; set; }

        private static int GoTo { get; set; }
        private static List<AddCustomer> customers = new List<AddCustomer>();

        private static void ChooseOption()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Create customer");
            Console.WriteLine("2) Create account");
            Console.WriteLine();
            Console.Write("Select an option: ");
            GoTo = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            LoopContinue = true;

            ChooseOption();

            while (LoopContinue)
            {
                switch (GoTo)
                {
                    case 1:
                        AddCustomer customer = new AddCustomer();
                        customer.CreateCustomer();
                        customers.Add(customer);
                        LoopContinue = true;
                        ChooseOption();
                        break;

                    case 2:
                        AddAccount account = new AddAccount();
                        account.CreateAccount(customers);
                        LoopContinue = true;
                        ChooseOption();
                        break;

                    default:
                        Console.WriteLine("Choose one of the options!\n");
                        LoopContinue = true;
                        break;
                }
            }
        }
    }
}

    
