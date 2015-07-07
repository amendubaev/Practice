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

        private void CommonCalculator(object sender, EventArgs e)
        {
            double result = 0;
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            double secondField = Convert.ToDouble(InputSecondTextBox.Text);
            switch (((Button) sender).Name)
            {
                case "Add":
                    result = firstField + secondField;
                    break;
                case "Subtract":
                    result = firstField - secondField;
                    break;
                case "Multiply":
                    result = firstField * secondField;
                    break;
                case "Divide":
                    if (secondField == 0)
                    {
                        Result.Text = "Division by 0!";
                    }
                    else
                    {
                        if (firstField == 0)
                        {
                            result = 0;
                        }
                        else result = firstField/secondField;
                    }
                    break;
                default:
                    throw new Exception();
            }
            Result.Text = " " + result;
        }

        public void SinInCalculator(object sender, EventArgs e)
        {
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            Result.Text = Convert.ToString(Math.Round(Math.Sin((firstField * Math.PI)/180), 11));
        }

        private void PowInCalculator(object sender, EventArgs e)
        {
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            double secondField = Convert.ToDouble(InputSecondTextBox.Text);
            Result.Text = Convert.ToString(Math.Pow(firstField, secondField));
        }
        private void InputFirstTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void InputSecondTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
    }
}
