using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Ange ett heltal: ");
            try
            {
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange ett annat heltal: ");
                int tal2 = int.Parse(Console.ReadLine());

                if (tal1 < tal2)
                {
                    Console.WriteLine("Tal 2 är större än Tal 1.");
                }
                else
                {
                    Console.WriteLine("Tal 1 är större än Tal 2");
                }
            }
            catch
            {
                Console.WriteLine("Du skrev in ett ogiltigt tal för variabeltypen Int.\n" +
                    "Tänk på att talet maximalt får vara 2,147,483,647 och minst -2,147,483,647\n" +
                    "Tänk även på att inte skriva in bokstäver eller andra ogiltiga tecken.\n");
            }
            


            Console.WriteLine("\nTryck på Enter för att börja om");
            Console.ReadLine();
            goto start;
        }
    }
}
