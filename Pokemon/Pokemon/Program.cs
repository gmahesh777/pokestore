using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = (ConsoleColor.DarkBlue);
            Console.Clear();
            Console.WriteLine();
            Console.Write("\t\t\t-------------");
            Console.ForegroundColor = (ConsoleColor.Red);
            Console.Write("Pokéstore");
            Console.ForegroundColor = (ConsoleColor.Gray);
            Console.WriteLine("-------------");
            Console.ForegroundColor = (ConsoleColor.Magenta);
            Console.WriteLine("\t\t\t\tA. Pikachu    - $ 6");
            Console.ForegroundColor = (ConsoleColor.Blue);
            Console.WriteLine("\t\t\t\tB. Squirtle   - $ 5");
            Console.ForegroundColor = (ConsoleColor.Green);
            Console.WriteLine("\t\t\t\tC. Charmander - $ 5");
            Console.ForegroundColor = (ConsoleColor.Gray);
            Console.WriteLine("\t\t\t-----------------------------------");
            Console.WriteLine();
            int A = 0,B = 0,C = 0;

            Console.WriteLine("How many Pikachu do you want?");
            A=int.Parse(Console.ReadLine());
            Console.WriteLine("How many Squirtle do you want?");
            B=int.Parse(Console.ReadLine());
            Console.WriteLine("How many Charmander do you want?");
            C=int.Parse(Console.ReadLine());

            float cost=CalculateCost.Calculate(A,B,C);
            Console.WriteLine(" ---------------------------------------");
            Console.WriteLine(" \tTotal Cost:\t$ {0}", cost.ToString("#0.00"));
            Console.WriteLine(" ---------------------------------------");
            Console.ReadKey();

        }
    }
}
