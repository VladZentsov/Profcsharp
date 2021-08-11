namespace CalculatorCore.Views
{
    public interface IView
    {
        string FirstNumber { get; }
        string SecondNumber { get; }
        string Result { set; }
    }
}
