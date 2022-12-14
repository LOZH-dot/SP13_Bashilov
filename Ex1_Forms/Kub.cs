using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Forms
{
    class Kub : Function
    {
        private double a = 0, b = 0, c = 0;

        public Kub(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            base.name = "Парабола";
        }

        public override double Calculate(double x)
            => (a * x * x) + (b * x) + c;
    }
}
