using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_PartI
{
    class Triangle
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3) 
        {
            if (IsTriangle(side1, side2, side3))
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                throw new BadTriangleException("Invalid sides!");
            }
        }

        static bool IsTriangle(double side1, double side2, double side3)
        {
            bool flag = false;
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            return area;
        }
    }
}
