namespace CalculatorCore.Controllers
{
    public class Controller : BaseController
    {
        public override void ButtonClick()
        {
            var a = Converter.Convert(View.FirstNumber);
            var b = Converter.Convert(View.SecondNumber);
            View.Result = Converter.ConvertBack(Model.Execute(a, b));
        }
    } 
}
