using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_static_marlon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int resultado = SumarNumeros();
                Console.WriteLine("La suma de los números es: " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("¡Gracias por usar la aplicación!");
            }
        }
        static int SumarNumeros()
        {
            Console.WriteLine("Ingrese el primer número:");
            string entrada1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo número:");
            string entrada2 = Console.ReadLine();
            int num1, num2;
            try
            {
                num1 = Convert.ToInt32(entrada1);
                num2 = Convert.ToInt32(entrada2);
            }
            catch (FormatException)
            {
                throw new Exception("Debe ingresar números válidos.");
            }
            catch (OverflowException)
            {
                throw new Exception("Los números ingresados están fuera del rango válido.");
            }

            return num1 + num2;
        }
    }
}