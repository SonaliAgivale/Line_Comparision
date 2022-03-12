using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class LineComparison
    {
        public double x1, x2, y1, y2, length;
        public void calculateLength()
        {
            Console.WriteLine("******Calculating Length*******");
            Console.WriteLine("Please Enter values of x1 and y1");
            Console.Write("x1:",x1);
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1:", y1);
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of x2 and y2");
            Console.Write("x2:", x2);
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2:", y2);
            y2 = Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line is : " + length);
        }
    }
}
