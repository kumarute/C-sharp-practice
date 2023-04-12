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
            int SumaPares = 0;
            int SumaImpares = 0;
            int[] Numeros = new int[5];
            Console.WriteLine("Introduce 5 números");
            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < Numeros.Length; j++)
            {



                if (Numeros[j] % 2 == 0)
                    SumaPares += Numeros[j];
                else
                    SumaImpares += Numeros[j];
            }
            Console.WriteLine("La suma de pares es " + SumaPares + " la suma de impares es " + SumaImpares);
        } 
    }
}
