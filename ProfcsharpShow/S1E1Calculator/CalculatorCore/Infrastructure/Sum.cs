namespace CalculatorCore.Infrastructure
{
    public class Sum : IArithmetic
    { 
        public double Result(double x, double y) => x + y;
    }
}
