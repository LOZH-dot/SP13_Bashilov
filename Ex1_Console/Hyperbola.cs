namespace Ex1_Console
{
    class Hyperbola : Function
    {
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
