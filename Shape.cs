using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Shape : ISquare
    {
        public double Square { get; protected set; }

        protected abstract bool IsValid();

        protected abstract void CalculateSquare();

        public virtual void ShowSquare()
        {
            Console.WriteLine($"Square of {GetType().Name} is {Square}" );
        }

        public void Calculate()
        {
            if (IsValid())
            {
                CalculateSquare();
                ShowSquare();
            }
        }
    }
}
