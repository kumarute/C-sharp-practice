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
            int[] Numeros = new int[3];
            Console.WriteLine("Introduce 10 números");
            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = int.Parse(Console.ReadLine());
                int Maximo = Numeros[0];
                int Minimo = Numeros[0];
                if (Numeros[i] > Maximo)
                    Maximo = Numeros[i];
                else if (Numeros[i] < Minimo)
                    Minimo = Numeros[i];
                Console.WriteLine("El número más grande es " + Maximo + " el número más pequeño es " + Minimo);

            }
        }
    }
    
}
