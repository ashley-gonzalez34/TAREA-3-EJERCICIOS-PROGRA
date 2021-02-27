using System;

namespace PIDE_EL_NUMERO_DEL_DIA_DE_LA_SEMANA
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;
            string RESUL = null;
            string cadena;


            Console.Write("Ingrese un numero : ");
            cadena = Console.ReadLine();
            NUM = int.Parse(cadena);
            Program ob = new Program();
            RESUL = ob.Diasdelasemana(NUM);

            Console.WriteLine();

            Console.WriteLine("El dia es : " + RESUL);
            Console.Write("Pulse cualquier  Tecla:");
            Console.ReadLine();

        }
        private string Diasdelasemana(int DIA)
        { 
            string a = null;
            switch (DIA)
            {

            
                case 1:
                    a = "DOMINGO";

                    break;

                case 2:
                    a = "LUNES";


                    break;

                case 3:
                    a = "MARTES";

                    break;

                case 4:
                    a = "MIÉRCOLES";

                    break;

                case 5:
                    a = "JUEVES";


                    break;

                case 6:
                    a = "VIERNES";

                    break;

                case 7:
                    a = "SÁBADO";

                    break;

                default:
                    a = "Incorrecto";
                   
                    break;

            }
            return (a);

        }
    }
}

    








