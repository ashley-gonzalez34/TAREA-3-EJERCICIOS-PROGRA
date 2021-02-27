using System;

namespace TABLAS_D_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            string n;
            Console.Write("INGRESE UN NUMERO: ");
            num = int.Parse(Console.ReadLine());
          

            n = Console.ReadLine();

            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " x " + n + " = " + i * num + "\n");
            }
        }
    }
}
