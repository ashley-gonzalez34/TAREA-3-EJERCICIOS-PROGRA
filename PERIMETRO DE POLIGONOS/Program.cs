using System;

namespace PERIMETRO_DE_POLIGONOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2;

                Console.WriteLine("ingrese una longitud");
            a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero del poligono");
            a2 = int.Parse(Console.ReadLine());

            Console.Write("EL area dl poligono es :" + ( (5 * a1  *a2) / 2 ) );

        }
    }
}
