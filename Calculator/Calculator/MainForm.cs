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
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InputFirstTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void InputSecondTextBox_TextChanged(object sender, EventArgs e)
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

        private void Calculate_Click(object sender, EventArgs e)
        {
            
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(InputFirstTextBox.Text) * Convert.ToDouble(InputSecondTextBox.Text);
            Result.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(InputFirstTextBox.Text) / Convert.ToDouble(InputSecondTextBox.Text);
            Result.Text = result.ToString();
        }
    }
}
