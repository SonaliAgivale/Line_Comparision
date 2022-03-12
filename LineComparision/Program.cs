using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineComparison lineComparison = new LineComparison();
            lineComparison.calculateLength();
            lineComparison.checkEquality();
            Console.ReadKey();
        }
    }
}
