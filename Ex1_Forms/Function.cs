using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Forms
{
    abstract class Function
    {
        public double a = 0, b = 0, c = 0;

        public string name;
        public abstract double Calculate(double x);
    }
}
