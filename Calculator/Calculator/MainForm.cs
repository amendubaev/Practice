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
            double result = 0;
            double firstField = Convert.ToDouble(Math.Round(Math.Sin((Convert.ToDouble(Result.Text) * Math.PI) / 180), 11));
            result = firstField;
        }

        private void PowInCalculator(object sender, EventArgs e)
        {
            string firstField = Convert.ToString(InputFirstTextBox.Text);
            string secondField = Convert.ToString(InputSecondTextBox.Text);
            Result.Text=Math.Pow(firstField,secondField)
        }
    }
}
