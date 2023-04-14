using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumayTriple
{
    class Program
    {
        public static int SumaArray()
        {
            Console.WriteLine("Introduce dos números separados por comas");
            string NumerosString = Console.ReadLine(); //lee los numeros
            string[] NumerosArray = NumerosString.Split(',');// la funcion split crea un array de subcadenas separando los numeros por las comas
            int[] Numeros = Array.ConvertAll(NumerosArray, int.Parse);//convierte NumerosArray del tipo array de strings a tipo int

            int Suma = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (i > 0 && Numeros[i] == Numeros[i - 1])
                    Suma += 3 * Numeros[i];
                else
                    Suma += Numeros[i];
            }
            return Suma;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumaArray());//Llamamos a la función en Main
        }
    }
}
