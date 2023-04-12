using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que introduzca el radio del círculo
            Console.Write("Introduce el radio del círculo: ");
            int radio = Int32.Parse(Console.ReadLine());

            // Dibujar el círculo utilizando operaciones matemáticas y el carácter '*'
            for (int y = -radio; y <= radio; y++)
            {
                for (int x = -radio; x <= radio; x++)
                {
                    if (x * x + y * y <= radio * radio)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
