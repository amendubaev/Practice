using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private void CalculatorWithTwoArgs(object sender, EventArgs e)
        {
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            double secondField = Convert.ToDouble(InputSecondTextBox.Text);
            string nameButton = ((Button) sender).Name;
            ITwoArguments factoryForTwoArgs = OperationsFactory.CreateOperation(nameButton);
            Result.Text = factoryForTwoArgs.Calculate(firstField, secondField).ToString();

        }

        public void CalculatorWithOneArg(object sender, EventArgs e)
        {
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            string nameButton = ((Button)sender).Name;
            IOneArgument factoryForOneArg = OperationsFactory.CreateTrigonometriaOperation(nameButton);
            Result.Text = factoryForOneArg.Calculate(firstField).ToString();
        }


        private void InputFirstTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void InputSecondTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
    }
}
