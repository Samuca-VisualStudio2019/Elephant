using System;

namespace AppElephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant { Name = "Lucinda", EarSize = 33 };
            Elephant iloyd = new Elephant { Name = "Iloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed: " + input);
                
                if (input == '1')
                {
                    Console.WriteLine("Calling illoyd.WhoAmI()");
                    iloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant holder;
                    holder = iloyd;
                    iloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped");
                }
                else if (input == '4')
                {
                    iloyd = lucinda;
                    iloyd.EarSize = 4321;
                    iloyd.WhoAmI();
                }

                else
                {
                    return;
                    Console.WriteLine();
                }
            }
        }
    }
}
