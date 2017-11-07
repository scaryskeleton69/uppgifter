using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            //samla information och placera informationen i strings
            Console.WriteLine("Hur mycket ska produkten kosta?: ");
            string prisString = Console.ReadLine();
            Console.WriteLine("Hur många procent rea ska det vara? (Svara mellan 0 och 100): ");
            string reaString = Console.ReadLine();

            //konvertera strings till floats
            //en fördel med float är att det kan hantera decimaltal vilket är väldigt viktigt i denna uppgift.

            //jag använder try och catch för att göra programmet mer user-friendly.
            try
            {
                float pris = float.Parse(prisString);
                float rea = float.Parse(reaString);
                float totalRea = rea / 100;
                float discounted = totalRea * pris;
                Console.Clear();
                //liten paus för att det ska bli bekvämare att använda programmet
                Thread.Sleep(500);
                Console.WriteLine("Med hjälp av värdena du matade in (rea: " + rea + "% och originalpris: " + pris + ") så är det nya priset " + discounted);
            }
            catch
            {
                Console.WriteLine("Ett fel har uppstått!\nDu har skrivit in ogiltiga värden för rea och/eller produktkostnaden.");
            }
            Console.WriteLine("Klicka på enter för att avsluta programmet");
            Console.ReadLine();
        }
    }
}
