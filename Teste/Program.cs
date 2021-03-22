using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 15;
            b = 5;
            c = 2;

            c += a < b ? a : b;

            if ((b > c) && (c < a))
            {
                c = a + b;
                Console.WriteLine(c);
            }
            else
            {
                c = a - b;
                Console.WriteLine(c);
            }


            Console.ReadKey();
        }
    }
}
