using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Skriv in ett år: ");
                float year = float.Parse(Console.ReadLine());
                //skottår är delbara med 4, eller 100 och 400, men inte 100.
                //den matematiska beräkningen x modulus n = 0 betyder att x är jämnt delbart med n
                if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
                {
                    Console.WriteLine("Ditt år är ett skottår");
                }
                else
                {
                    Console.WriteLine("Ditt år är inte ett skottår\n");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Se till så att du skrev in årtalet rätt!\nProgrammet avslutas om 3 sekunder");
                Thread.Sleep(3000);
            }
            
        }
    }
}
