using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Diferencia()
        {
            Console.WriteLine("Introduce un número");
            int Numero = Convert.ToInt32(Console.ReadLine());

            if (Numero > 51)
                Numero = (Numero-51) * 3;
            else
                Numero = 51 - Numero;
            return Numero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Diferencia());
        }
    }
}
