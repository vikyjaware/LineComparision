using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    public class LineComparison
    {
        public void CalculateLength()
        {
            int X1,Y1,X2,Y2;

            Console.WriteLine("Enter the Co-ordinates of first point as A(x1,y1) : ");
            Console.Write("x1=");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of second point as B(x2,y2) : ");
            Console.Write("x2=");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            Y2 = Convert.ToInt32(Console.ReadLine());
            double Length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(" The length of line is : " + Length);

        }  

    }
}
