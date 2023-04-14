using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablamultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("introduce el número");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero * i+" ") ;
            }
        }
    }
}
