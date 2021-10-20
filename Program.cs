using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(5.6, 45.3);
            Rectangle rect2 = new Rectangle(6, 10);

            var shapes = new ISquare[] { rect1, rect2};

            foreach(var shape in shapes)
            {
                shape.Calculate();
            }            
        }


    }
}
