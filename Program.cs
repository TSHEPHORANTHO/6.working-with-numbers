using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.working_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //WRITING WITHOUT CALCULATION USE ""
            Console.WriteLine("6 + 4");
            //CALCULATE DO NOT USE ""
            Console.WriteLine(6 + 4);
            Console.WriteLine(5 / 2);
            Console.WriteLine("5 DIVIDE BY 2 IS " + "" + 5/2+ " REMAINDER " + 5%2);

            //NUMBERS
            int NUM1 = 2;
            NUM1 = NUM1 + 1;
            NUM1 += 3;

            //IMPLEMENT
            Console.WriteLine("NUM1= " + NUM1);
            int NUM2 = 2;
            NUM2++;
            Console.WriteLine("NUM2 = ");
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Min(4,2));
            Console.WriteLine(Math.Max(5,2));

            //read
            Console.ReadLine();






        }
    }
}
