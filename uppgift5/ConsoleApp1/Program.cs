using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skottår
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Skriv in ett år: ");
                float year = float.Parse(Console.ReadLine());

                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Ditt år är ett skottår");
                    }
                    else
                    {
                        Console.WriteLine("Ditt år är inte ett skottår");
                    }

                }

                else if (year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine("Ditt år är ett skottår");
                }
                else
                {
                    Console.WriteLine("Ditt år är inte ett skottår");
                }

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Någonting gick fel. Dubbelkolla så att du skrev in årtalet rätt. \nProgrammet stängs nu...");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
