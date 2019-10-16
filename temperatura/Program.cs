
using System;

namespace Serra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la temperatura della serra: ");
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura < 5)
            {
                Console.WriteLine("la temperatura porta a danni irreparabili");
            }
            else if (5 <= temperatura && temperatura < 18)
            {
                Console.WriteLine("temperatura di pericolo");
            }
            else
            {
                Console.WriteLine("Temperatura normale");
            }
            Console.ReadLine();
        }
    }
}