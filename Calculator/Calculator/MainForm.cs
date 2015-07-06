using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            InputFirstTextBox.KeyPress += (sen, e) => e.Handled = e.KeyChar == ';';
            InputSecondTextBox.KeyPress += (sen, e) => e.Handled = e.KeyChar == ';';
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AllInOneFunction(object sender, EventArgs e)
        {
            double result = 0;

            switch (((Button)sender).Name)
            {
                case "Addition":
                    result = Convert.ToDouble(InputFirstTextBox.Text) + Convert.ToDouble(InputSecondTextBox.Text);
                    break;
                case "Subtract":
                    result = Convert.ToDouble(InputFirstTextBox.Text) - Convert.ToDouble(InputSecondTextBox.Text);
                    break;
                case "Multiply":
                    result = Convert.ToDouble(InputFirstTextBox.Text) * Convert.ToDouble(InputSecondTextBox.Text);
                    break;
                case "Divide":
                    if (Convert.ToDouble(InputSecondTextBox.Text) == 0)
                    {
                        Result.Text = "Division by zero!";
                    }
                    else
                    {
                        result = Convert.ToDouble(InputFirstTextBox.Text) / Convert.ToDouble(InputSecondTextBox.Text);
                    }
                    break;
                default:
                    throw new Exception();
            }
            Result.Text = result.ToString();
        }
    }
}
