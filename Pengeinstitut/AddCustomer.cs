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


        public void CreateCustomer()
        {
            Console.WriteLine("\nCreate customer");

            Console.Write("Name: ");
            Name = Convert.ToString(Console.ReadLine());

            Console.Write("Email: ");
            Email = Convert.ToString(Console.ReadLine());

            Console.Write("CPR: ");
            Cpr = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"You created a customer: \nName: {Name} \nEmail {Email} \nCpr: {Cpr}");

            Console.WriteLine("Press enter to go back");
            Console.ReadLine();

        }
    }
}
