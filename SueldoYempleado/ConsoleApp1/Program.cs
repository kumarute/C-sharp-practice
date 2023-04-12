using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Empleados = new string[5];
            double[] Sueldos = new double[5];
            int MayorSueldo = 0;

            for (int i = 0; i < Sueldos.Length; i++)
            {
                Console.WriteLine("Introduce el nombre del empleado {0}:", i);
                Empleados[i] = Console.ReadLine();
                Console.WriteLine("Introduce el sueldo del empleado {0}", i);
                do
                {
                    Sueldos[i] = Double.Parse(Console.ReadLine());
                    if (Sueldos[i] <= 0)
                        Console.WriteLine("No puede haber sueldo 0 o negativo");

                } while (Sueldos[i] <= 0);
            }
            for(int j = 1; j < Sueldos.Length; j++)
            {
                if (Sueldos[MayorSueldo] < Sueldos[j])
                    MayorSueldo = j;

            }
            Console.WriteLine("El mayor sueldo lo cobra {0}", Empleados[MayorSueldo]);
            Console.WriteLine("y el sueldo es de {0}", Sueldos[MayorSueldo]);
        }
    }
}
