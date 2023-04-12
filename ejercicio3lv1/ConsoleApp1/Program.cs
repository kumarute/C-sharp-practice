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
            int[] Vector1  = new int [5];
            int[] Vector2 = new int[5];
            Console.WriteLine("Introduce un vector de 5 números");
            for (int i = 0; i < Vector1.Length; i++)
            {
                Vector1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Introduce un segundo vector de 5 números");
            for (int j = 0; j < Vector1.Length; j++)
            {
                Vector2[j] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("El vector1 es");
            Console.WriteLine(String.Join(",", Vector1));
            Console.WriteLine("El vector2 es");
            Console.WriteLine(String.Join(",", Vector2));

            int[] MultiplicaciónVectores = new int[5];
            for(int k=0;k<Vector1.Length;k++)
            {
                MultiplicaciónVectores[k] = Vector1[k] * Vector2[k];
            }
            Console.WriteLine("La multiplicación de Vectores es");
            Console.WriteLine(String.Join(",", MultiplicaciónVectores));
        }
    }
}
