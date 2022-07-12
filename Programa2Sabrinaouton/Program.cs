using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2Sabrinaouton
{
    class Program
    {
        static void Main(string[] args)
        {
			double a, b, c, d, e;
			Console.Write("ingrese el valor de A: ");
			a = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el valor de B: ");
			b = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el valor de C: ");
			c = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor de D: ");
			d = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el valor de E: ");
			e = Double.Parse(Console.ReadLine());
			if (a != 0)
			{
				Console.WriteLine("Es una Parabola");
			}
			if (b != 0)
			{
				Console.WriteLine("Es una Parabola");
			}
			if (a != 0 && a == b)
			{
				Console.WriteLine("es una circunferencia");
			}
			if (a != 0 && b != 0 && a != b)
			{
				Console.WriteLine("es una Elipse");
			}
			if (a != 0 && b != 0 && a < 0 && b > 0 && a != b)
			{

				Console.WriteLine("es una hiperbola");
			}
			else
			{
				Console.WriteLine("");

			}
			Console.ReadLine();
		}



	}

}
        
   

