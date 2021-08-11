using CalculatorCore.Views;

namespace ConsoleUI
{
    using static System.Console;

    class UI : IConsoleView
    {
        public string FirstNumber
        {
            get
            {
                Write("FirstNumber: ");
                return ReadLine();
            }
        }
        public string SecondNumber
        {
            get
            {
                Write("SecondNumber: ");
                return ReadLine();
            }
        }
        public string Result
        {
            set => WriteLine($"Result: {value}");
        }

        public void WelcomeAction(string msg) => WriteLine("Hi");
    }
}
