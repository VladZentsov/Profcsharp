using CalculatorCore.Log;
using System;

namespace CalculatorCore.Controllers
{
    public class LoggerController : BaseController
    {
        BaseController bc;
        ILog log;

        public LoggerController(BaseController controller, ILog log = null)
        {
            bc = controller;
            this.log = log;
        }

        public override void ButtonClick()
        {
            log.Log($"ButtonClick pressed at {DateTime.Now}");
            bc.ButtonClick();
        }
    }
}
