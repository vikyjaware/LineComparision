using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    public class LineComparison
    {
        public void Length()
        {
            double X1, Y1, X2, Y2, X3, Y3, X4, Y4 ;

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
            double Length1 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(" The length of Line1 is : " + Length1);

            Console.WriteLine("Enter the Co-ordinates of third point as C(x3,y3) : ");
            Console.Write("x3=");
            X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3=");
            Y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of fourth point as D(x4,y4) : ");
            Console.Write("x4=");
            X4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4=");
            Y4 = Convert.ToInt32(Console.ReadLine());
            double Length2 = Math.Sqrt(Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2));
            Console.WriteLine(" The length of Line2 is : " + Length2);

            if (Length1 == Length2)
            {
                Console.WriteLine("The length of both the lines is same ");
            }
            if (Length1<Length2)
            {
                Console.WriteLine("The length of Line1 is less than the length of Line2 ");
            }
            if (Length1 > Length2)
            {
                Console.WriteLine("The length of Line1 is greater than the length of Line2 ");
            }
        }
    }
}