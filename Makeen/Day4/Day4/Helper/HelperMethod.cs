using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Helper
{
    internal class HelperMethod
    {
        public static void print<T>(T X)
        {
            Console.WriteLine($" datatype is : {typeof(T)}");
        }

        public static void print(string x)
        {
            Console.WriteLine($" datatype is  : {typeof(string)}");
            Console.WriteLine(x);
        
        }

    }
}
