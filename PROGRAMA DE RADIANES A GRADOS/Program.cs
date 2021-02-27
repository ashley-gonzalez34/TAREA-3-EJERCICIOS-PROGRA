using System;

namespace PROGRAMA_DE_RADIANES_A_GRADOS
{
    class Program
    {
        static void Main(string[] args)
        {

            double grados, radianes, pi = 3.1416;
            int valor;

            Console.WriteLine(" Ingrese el numero: ");
            valor = int.Parse(Console.ReadLine());

            grados = Convert.ToDouble(valor);
            radianes = gradosRadianes(grados, pi);
            Console.WriteLine("{0} radianes son {1} grados", radianes, grados);

            


        }
        static double gradosRadianes(double a1, double a2)
        { double r = 0.0;

            r = ( a1 * a2)/ 180;
            return r;
        }



        





        
    }
}
