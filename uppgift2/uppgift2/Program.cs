using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {


            
            try
            {
                Console.WriteLine("Skriv två tal\nTal ett: ");
                string n1 = Console.ReadLine();
                Console.WriteLine("Tal två: ");
                string n2 = Console.ReadLine();
                //konverterar string till float
                float x1 = float.Parse(n1);
                float x2 = float.Parse(n2);
                Console.WriteLine("Välj ett alternativ:\n1. Summa\n2. Produkt\n3. Båda");

                string svar = Console.ReadLine();
                //konverterar string till int
                int svarint = Convert.ToInt32(svar);

                if (svarint == 1)
                {
                    Console.WriteLine("Din summa är: " + (x1 + x2));
                }
                else if (svarint == 2)
                {
                    Console.WriteLine("Din produkt är: " + (x1 * x2));
                }
                else if (svarint == 3)
                {
                    Console.WriteLine("Produkt = " + (x1 * x2) + "\nSumma = " + (x1 + x2));
                }
                else
                {
                    Console.WriteLine("Du har valt fel nummer");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Nu har du gjort något fel. Vänligen starta om programmet och gör rätt.");
                Console.ReadLine();
            }
            
        }
    }
}
