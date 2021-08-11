namespace CalculatorCore.Infrastructure
{
    public class NumberConverter : INumberConverter
    {
        public double Convert(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }

        public string ConvertBack(double value) => $"{value}";
    }
}
