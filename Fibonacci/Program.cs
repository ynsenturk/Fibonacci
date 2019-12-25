using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci (1-10)
            int sayi1 = 1;
            int sayi2 = 1;
            int sayi3 = 0;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            for (int i = 0; i < 10; i++)
            {
                sayi3 = sayi1 + sayi2;
                Console.WriteLine(sayi3);
                sayi1 = sayi2;
                sayi2 = sayi3;

            }
            Console.ReadLine();
        }
    }
}
