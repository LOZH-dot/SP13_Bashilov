using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Forms
{
    class Line : Function
    {
        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;

            base.name = "Прямая";
        }

        public override double Calculate(double x)
            => (a * x) + b;
    }
}
