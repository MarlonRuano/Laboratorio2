using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace La_Calculadora
{
    class Calculadora
    {
        
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma: " + calculadora.Sumar(num1, num2));
            Console.WriteLine("Resta: " + calculadora.Restar(num1, num2));
            Console.WriteLine("División: " + calculadora.Dividir(num1, num2));
            Console.WriteLine("Multiplicación: " + calculadora.Multiplicar(num1, num2));
            Console.ReadLine();
        }
    }
}