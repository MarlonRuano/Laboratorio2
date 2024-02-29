using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inresos_marlon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa tus ingresos de los últimos 3 meses:");

            double[] ingresos = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingresos del mes {i + 1}: ");
                ingresos[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Por favor, escribe tu nombre completo: ");
            string nombreCompleto = Console.ReadLine();

            double sumaIngresos = 0;
            foreach (double ingreso in ingresos)
            {
                sumaIngresos += ingreso;
            }
            double promedioIngresos = sumaIngresos / 3;

            Console.WriteLine($"Hola {nombreCompleto}, en total ganaste una suma de {sumaIngresos} y promediaste un promedio de {promedioIngresos}");

            Console.ReadLine(); 

        }
    }
}
