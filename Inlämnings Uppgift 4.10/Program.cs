using System;

namespace Uppgift4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = "";
            string O = "";
            Console.WriteLine("Hur många X per grupp?");
            int Xantal = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int Oantal = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O mönster per rad?");
            int Omönster = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int Rader = int.Parse(Console.ReadLine());

            for (int k = 0; k < Xantal; k++)
            {
                X = X + "X";
            }
            for (int l = 0; l < Oantal; l++)
            {
                O = O + "O";
            }

            for (int i = 0; i < Rader; i++)
            {
                for (int j = 0; j < Omönster; j++)
                {
                    Console.Write(X);
                    Console.Write(O);
                }
                Console.WriteLine(X);
            }
        }
    }
}