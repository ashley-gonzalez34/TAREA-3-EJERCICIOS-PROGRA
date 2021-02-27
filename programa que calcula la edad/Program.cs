using System;

namespace programa_que_calcula_la_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad,acumulador = 0;
         



            for (int x = 1;  x <= 5 ; x ++ )
            {
                  Console.WriteLine("Por favor ingresar edad");
                  edad = int.Parse(Console.ReadLine());
                  acumulador = acumulador + edad;
               
            }
            
            Console.WriteLine("El promedio de las edades es :" + acumulador);
            
            
                



            


            
            


            
        }
    }
}
