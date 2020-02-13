using System;
using System.Collections.Generic;
using System.Text;

namespace Pengeinstitut
{
    class AddCustomer
    {
        public long Cpr { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        // En liste til kontierne på den enkelte customer.
        public  List<Account> Accounts = new List<Account>();

        // Metoden tager input fra brugeren og putter det ind i CreateCustomer, så jeg kan bruge den i min Main til at tilføje Customers til min liste.
        public void CreateCustomer()
        {
            Console.WriteLine("\nCreate customer");

            Console.Write("Name: ");
            Name = Convert.ToString(Console.ReadLine());

            Console.Write("Email: ");
            Email = Convert.ToString(Console.ReadLine());

            Console.Write("CPR: ");
            Cpr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"You created a customer: \nName: {Name} \nEmail {Email} \nCpr: {Cpr}");

            Console.WriteLine("Press enter to go back");
            Console.ReadLine();
        
        }
    }
}
