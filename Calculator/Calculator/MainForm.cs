using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void InputFirstTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {

        }
        private void InputSecondTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(InputFirstTextBox.Text) + Convert.ToDouble(InputSecondTextBox.Text);
            Result.Text = result.ToString();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(InputFirstTextBox.Text) - Convert.ToDouble(InputSecondTextBox.Text);
            Result.Text = result.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(InputFirstTextBox.Text) * Convert.ToDouble(InputSecondTextBox.Text);
            Result.Text = result.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Divide_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(InputSecondTextBox.Text) == 0)
            {
                Result.Text = "Division by zero!";
            }
            else
            {
                double result = Convert.ToDouble(InputFirstTextBox.Text)/Convert.ToDouble(InputSecondTextBox.Text);
                Result.Text = result.ToString();
            }
        }
    }
}
