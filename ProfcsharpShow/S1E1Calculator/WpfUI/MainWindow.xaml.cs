using CalculatorCore.Controllers;
using CalculatorCore.Infrastructure;
using CalculatorCore.Models;
using CalculatorCore.Views;
using System.Windows;

namespace WpfUI
{
    public partial class MainWindow : Window, IWpfView
    {
        public string FirstNumber => tbFirstNumber.Text;
        public string SecondNumber => tbSecondNumber.Text;
        public string Result { set => tbResult.Text = value; }

        public MainWindow()
        {
            InitializeComponent();

            var controller = new ControllerBuilder()
                              .SetView(this)
                              .SetModel(new Model(new Sum()))
                              .SetConvertor(new NumberConverter())
                              .Build();

            btnResult.Click += delegate { controller.ButtonClick(); };
        }

        public void ToDoAction(string msg) => MessageBox.Show("Wuf");
    }
}
