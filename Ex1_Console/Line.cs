namespace Ex1_Console
{
    class Line : Function
    {
        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;

            base.name = "Прямая    ";
        }

        public override double Calculate(double x)
            => (a * x) + b;
    }
}
