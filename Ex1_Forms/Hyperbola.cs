using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Forms
{
    class Hyperbola : Function
    {
        private double a = 0, b = 0;
       

        public Hyperbola(double a, double b)
        {
            this.a = a;
            this.b = b;
            base.name = "Гипербола";
        }

        public override double Calculate(double x)
            => (a / x) + b;
    }
}
