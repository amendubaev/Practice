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

        private float value = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InputFirstTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
           InputFirstTextBox.Text = " ";
           InputFirstTextBox.Text = (value + float.Parse(InputFirstTextBox.Text)).ToString();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }
    }
}
