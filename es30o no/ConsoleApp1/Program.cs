using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Es30()
        {
            Console.WriteLine("introduce los numeros separados por un espacio");
            string LecturaString = Console.ReadLine();//lectura del usuario en una string
            string[] NumerosArray = LecturaString.Split(' ');//dividimos la string con Split y almacenamos en un vector string las subcadenas
            int[] Numeros = Array.ConvertAll(NumerosArray, int.Parse);//convertimos cada subcadena string en tipo int
            
            for (int i = 0; i < Numeros.Length; i++)//recorremos el vector con el bucle for
            {
                if (Numeros[i] == 30)//si uno de los valores es igual a 30
                    return true;
                else if (i < Numeros.Length-1 && Numeros[i] + Numeros[i + 1] == 30)//si la suma de dos terminos es igual 30, limitamos el recorrido de i en el vector para que no se salga de los limites de este
                    return true;
            }
            return false;
        }
        static void Main(string[] args)

        {
            Console.WriteLine(Es30());
        }
    }
}
