using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class LineComparison
    {
        public double x1, x2,x3,x4,y1, y2,y3,y4,length1, length2;
       //UC1 Calculating length
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

            length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line is : " + length1);
        }

        //UC2 Check equality of lines
        public void checkEquality()
        {
            Console.WriteLine("Please Enter x , y Co-ordinates of line 2 :");
            Console.WriteLine("Please Enter values of x3 and y3");
            Console.Write("x3:", x3);
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3:", y3);
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of x4 and y4");
            Console.Write("x4:", x4);
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4:", y4);
            y4 = Convert.ToInt32(Console.ReadLine());
            length2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of the line is : " + length2);
            Console.WriteLine("----------------------------------------------");

            //bool equalityCheck = length1.Equals(length2);
            //if (equalityCheck == true)
            //    Console.WriteLine("Lengths of line 1 and line 2 are equal");
            //else
            //    Console.WriteLine("Lengths of line 1 and line 2 are not equal");

            //UC3-Comparing Lines
            double diff = length1.CompareTo(length2);
            if (diff < 0)
            {
                Console.WriteLine("Length of Line 1 is less than Line2");
            }
            if (diff > 0)
            {
                Console.WriteLine("Length of Line 1 is greater than Line2");
            }
            if (diff == 0)
            {
                Console.WriteLine("Length of Line 1 equal to Line2");
            }
        }
    }
}
