using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
        //Arithmetic Operators
        // Multiple Line Comment
        int x = 5;
        int y = 2;
            /*Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);*/

            //Console.WriteLine(x = y);
            //Console.WriteLine(x += y);
            //Console.WriteLine(x -= y);
            //Console.WriteLine(x *= y);
            //Console.WriteLine(x % y);
            //Console.WriteLine(x /= y);

            //Comparison Operators
            /*Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);*/

            
            Console.ReadLine();
            //Logical operators
            //&& - AND
            //||- OR (pipes)
            Console.WriteLine(x != y && y == 2);
            Console.WriteLine(x != y && y == 10);
            Console.WriteLine(x != y || y == 2);
            Console.WriteLine(!(y == 10));


                
          Console.ReadLine();

        }
    }
}
