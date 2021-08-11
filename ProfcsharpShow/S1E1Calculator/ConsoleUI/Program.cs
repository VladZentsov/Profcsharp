using CalculatorCore.Controllers;
using CalculatorCore.Infrastructure;
using CalculatorCore.Log;
using CalculatorCore.Models;
using static System.Console;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new LoggerController( 
                                     new ControllerBuilder()
                                    .SetView(new UI())
                                    .SetModel(new Model(new Mult()))
                                    .SetConvertor(new NumberConverter())
                                    .Build(),
                                new DebugLog()
                                )
                                ;

            controller.ButtonClick();
            ReadLine();
        }
    }
}
