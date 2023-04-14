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
            int[,] Matriz = new int[2, 3];
            Random Aleatorio = new Random();

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = Aleatorio.Next(10);

                }

            }

            int Suma = 0;
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write(Matriz[i, j] + "\t");
                    Suma += Matriz[i, j];
                }
                Console.WriteLine("|\t{0}", Suma);
                Suma = 0;

            }
            int SumaTotal = 0;
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < Matriz.GetLength(1); i++) //ahora empezamos por una columna 
            {
                for (int j = 0; j < Matriz.GetLength(0); j++)//vamos recoriendo la matriz por filas
                {
                    Suma += Matriz[j, i];
                }
                Console.Write("{0}\t",Suma);
                SumaTotal += Suma;
                Suma = 0;
            }
            Console.Write("|\t{0}",SumaTotal);



        }
    }
}