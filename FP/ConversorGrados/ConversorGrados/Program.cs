using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorGrados
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, farenheit;
            Console.WriteLine("Introduce los grados celsius");
             celsius =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Los grados es Celsius son "+ celsius);
             farenheit = (celsius * 1.8+ 32);
            Console.WriteLine("El equivalente en grados Farenheit es {0}",farenheit);

            Console.WriteLine("Ahora mostraremos números del 1 al 10");
            
            for( int i=1;i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            
            Console.WriteLine("ahora introducimos un número y el prgrama nos dirá si es negativo, positivo o cero");

            double numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("el número es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("el número es negativo");
            }
            else
            {
                Console.WriteLine("el númeor es cero");

            }
        }
    }
}
