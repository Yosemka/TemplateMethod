using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Rectangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        protected override bool IsValid()
        {
            return A > 0 && B > 0;
        }

        protected override void CalculateSquare()
        {
            Square = A * B;
        }
    }
}
