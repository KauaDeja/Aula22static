using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine( Conversor.RealParaDolar(100) );
            System.Console.WriteLine( Conversor.DolarParaReal(100) );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(Conversor.RealParaEuro(200));
            System.Console.WriteLine(Conversor.EuroParaReal(200));
            Console.ResetColor();

        }
    }
}
