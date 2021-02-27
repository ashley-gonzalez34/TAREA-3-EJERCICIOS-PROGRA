using System;

namespace NUMEROS_PARES
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Este numero es Par");

            }
            else
            {
                Console.WriteLine("Este numero no es Par");

            }


        }
    }
}
