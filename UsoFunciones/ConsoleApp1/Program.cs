using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   
        public static int Calcular (int a)
        {
            string cad = Convert.ToString(a);
            //Convertimos el parámetro en string
            int Sum = 0;
            for (int i = 0; i < cad.Length; i++)
            { /*recorremos el número y vamos tomando las subcadenas,los dígitos,con la función
                 * Substring, almacenándolo en una variable de tipo entero Sum para hacer la suma de los dígitos*/
                Sum += Convert.ToInt32(cad.Substring(i, 1));
            }
                return Sum;
                
            
        }
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Introduzca el número");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Calcular(numero));
            Console.ReadKey();
        }
    }
}
