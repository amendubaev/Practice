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
            try
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
            catch
            {
                Result.Text = "Enter number!";
            }
        }
    }
}
