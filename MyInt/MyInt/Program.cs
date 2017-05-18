using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInt
{
    class Program
    {
        static void Main(string[] args)
        {
            myInt a;
            a = 5;
            a = null;
            myInt b;
            b = 4;
            myInt c;
            c = a - b;
            Console.WriteLine(c.Value);
        }
    }
}
