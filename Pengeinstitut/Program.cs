using System;

namespace Pengeinstitut
{
    class Program
    {
        private static bool loopContinue { get; set; }

        private static int goTo { get; set; }

        private static void ChooseOption()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Create customer");
            Console.WriteLine();
            Console.Write("Select an option: ");
            goTo = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            loopContinue = true;
            

            while (loopContinue)
            {
                ChooseOption();

                switch (goTo)
                {
                    case 1:
                        AddCustomer customer1 = new AddCustomer();
                        customer1.CreateCustomer();
                        loopContinue = false;
                        break;

                    default:
                        Console.WriteLine("Choose one of the options!\n");
                        loopContinue = true;
                        break;
                }
            }
        }
    }
}

    
