using System;

namespace serie_de_fibbonacci
{
    class Program
    {
		static void Main(string[] args)
		{
			byte num, c, l;
			long b1;
			double RESUL = 0;
			string a;
			Console.Write("Ingrese un numero: ");
			a = Console.ReadLine();
			
			num = byte.Parse(a);
			for (c = 1; c <= num; c++)
			{
				b1 = 1;
				for (l = 1; l <= l; l++)
				{
					b1 = b1 *l;
				}
				RESUL = RESUL + (c / b1);
			}
			Console.WriteLine("El resultado es : " + RESUL);
			
		}
			
		
    }
}
