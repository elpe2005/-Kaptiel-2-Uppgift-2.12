using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till bil hyrningsfirman, här kan du räkna hur mycket det kommer kosta. ");
            Console.WriteLine(" Hur många dagar ska du hyra? ");
            string dagar = Console.ReadLine();
            Console.WriteLine(" Okej hur många kilometer ska du åka?");
            string km = Console.ReadLine();
            int dagarna = int.Parse(dagar);
            int kmarna = int.Parse(km);
            int summan = 300 + kmarna + 500 * dagarna;
            Console.WriteLine("Summan är " + summan + "kr");

            
            
        }
    }
}