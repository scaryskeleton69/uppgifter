using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett år: ");
            float year = float.Parse(Console.ReadLine());
            //skottår är delbara med 4
            //för att bestämma om ett tal är delbart med ett annat kan man använda "%" modulus operatorn
            Console.WriteLine(5 % 20);
            //den matematiska beräkningen x modulus n = 0 betyder att x är jämnt delbart med n
            if (year % 4 == 0) //om år är jämnt delbart med 4 är det ett skottår
            {
                Console.WriteLine("Ditt år är ett skottår");
            }
            else
            {
                Console.WriteLine("Ditt år är inte ett skottår");
            }
            
            Console.ReadLine();
        }
    }
}
