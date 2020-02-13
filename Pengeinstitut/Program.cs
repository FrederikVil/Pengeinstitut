using System;
using System.Collections.Generic;

namespace Pengeinstitut
{
    class Program
    {
        private static bool LoopContinue { get; set; }

        private static int GoTo { get; set; }

        // En liste der gør at jeg kan parre en customer med en account
        private static List<AddCustomer> customers = new List<AddCustomer>();

        // Main menu metoden, hvor man vælger hvad man vil i gøre i programmet
        private static void ChooseOption()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Create customer");
            Console.WriteLine("2) Create account");
            Console.WriteLine("3) Show accounts");
            Console.WriteLine();
            Console.Write("Select an option: ");
            GoTo = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            // Loopet er true så det kører hele tiden
            LoopContinue = true;

            ChooseOption();

            // De forskellige valgmuligheder i main menuen kører i et loop. 
            while (LoopContinue)
            {

                switch (GoTo)
                {
                    // Skriver man 1 laver man en customer.
                    case 1:
                        AddCustomer customer = new AddCustomer();
                        customer.CreateCustomer();
                        // Tillføjer den nylig lavet customer til listen.
                        customers.Add(customer);
                        LoopContinue = true;
                        ChooseOption();
                        break;

                    // Skriver man 2 laver man en account til en customer.
                    case 2:
                        AddAccount addAccount = new AddAccount();
                        // Jeg tager min liste (customers) med over i CreateAccount.
                        addAccount.CreateAccount(customers);
                        LoopContinue = true;
                        ChooseOption();
                        break;

                    case 3:
                        Account account = new Account();
                        account.ShowAccount(customers);
                        LoopContinue = true;
                        ChooseOption();
                        break;

                    // Skriver man alt andet kører loopet bare igen og man kan vælge forfra.
                    default:
                        Console.WriteLine("Choose one of the options!\n");
                        ChooseOption();
                        LoopContinue = true;
                        break;
                }
            }
        }
    }
}

    
