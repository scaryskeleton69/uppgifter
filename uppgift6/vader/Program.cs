using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vader
{
    class Program
    {
        static void Main(string[] args)
        {
            bool regn;
            bool sol;
            bool moln;
            Console.WriteLine("Beskriv vädret!\nRegnar det? (y/n) ");
            if (Console.ReadLine() == "y")
            {
                regn = true;
            }
            else
            {
                regn = false;
            }

            Console.WriteLine("Är det soligt? (y/n) ");
            if(Console.ReadLine() == "y")
            {
                sol = true;
            }
            else
            {
                sol = false;
            }

            Console.WriteLine("Hur många grader är det?");
            int temp = int.Parse(Console.ReadLine());

            if(temp > 24 && sol)
            {
                Console.WriteLine("Det är varmt, använd enbart t-shirt");
            }
            else if(temp < 0 && regn)
            {
                Console.WriteLine("Det snöar, använd täckjacka");
            }
            else if(temp > 0 && regn)
            {
                if(temp < 12)
                {
                    Console.WriteLine("Det är kyligt, ta på dig varma kläder och paraply.");
                }
                else
                {
                    Console.WriteLine("Det är ganska varmt, men det är regn. Använd paraply.");
                }
            }
            Console.WriteLine("Klicka på enter för att avsluta");
            Console.ReadLine();
        }
    }
}
