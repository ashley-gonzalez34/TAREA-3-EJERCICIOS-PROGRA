using System;

namespace CALCULO_DE_IMPUESTO
{
    class Program
    {
        static void Main(string[] args)
        {
            float iva, num, pv;
            Console.WriteLine("Introduce el numero de la venta");
            num = int.Parse(Console.ReadLine());

            iva = num * 19;
            pv = num + iva;


            Console.WriteLine("EL total de iva es : " + iva);
            Console.WriteLine("El Precio es : " + pv);
            Console.WriteLine
        }
            






    }
}
