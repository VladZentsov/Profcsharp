using CalculatorCore.Infrastructure;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace CalculatorCore.Controllers
{
    public class ControllerBuilder
    {
        Controller controller;
        public ControllerBuilder() => controller = new Controller();

        public ControllerBuilder SetModel(IModel model)
        {
            controller.Model = model;
            return this;
        }
        public ControllerBuilder SetView(IView view)
        {
            controller.View = view;
            return this;
        }

        public ControllerBuilder SetConvertor(INumberConverter convertor)
        {
            controller.Converter = convertor;
            return this;
        }

        public Controller Build() => controller;
    }
}
