using System;

namespace numero_elevados_a_potencias
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 ;
            int num2 = 2;
            
            



            Console.WriteLine("Ingrese el numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero elevado");
            num2 = int.Parse(Console.ReadLine());
 
            var resultado = 10;

            int i;
            for  (i = 100; i<=100; i++)
                
            { 
             resultado = num1 * num2;
            }

            Console.WriteLine("Resultado: " + resultado );
        }
    }
}


    

