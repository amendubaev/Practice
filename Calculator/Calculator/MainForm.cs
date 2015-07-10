using System;
using System.Windows.Forms;
using Calculator.ArraySort;
using Calculator.OneArg;
using Calculator.TwoArg;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Array sorting method
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Operation тame</param>
        public void ArraySort(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputFirstTextBox.Text))
            {
                throw new Exception("Enter first argument");
            }
            string[] Split = InputFirstTextBox.Text.Split(new Char[] { ' ' });
            double[] mas = new double[Split.Length];
            for (int i = 0; i < Split.Length; i++)
            {
                mas[i] = Convert.ToDouble(Split[i]);
            }
            string nameButton = ((Button)sender).Name;
            ISorter Factory = ArraySortFactory.CreateSort(nameButton);
            double[] massive = Factory.Sort(mas);
            string result = "";
            for (int j = 0; j < massive.Length; j++)
            {
                result += Convert.ToString(massive[j] + " ");
            }
            Result.Text = result;
        }
        /// <summary>
        /// Calculator for functions with two arguments
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Operation name</param>
        private void CalculatorWithTwoArgs(object sender, EventArgs e)
        {
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            double secondField = Convert.ToDouble(InputSecondTextBox.Text);
            string nameButton = ((Button) sender).Name;
            ITwoArguments factoryForTwoArgs = OperationsFactory.CreateOperation(nameButton);
            Result.Text = factoryForTwoArgs.Calculate(firstField, secondField).ToString();

        }
        /// <summary>
        /// Calculator for functions with one argument
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Operation name</param>
        public void CalculatorWithOneArg(object sender, EventArgs e)
        {
            double firstField = Convert.ToDouble(InputFirstTextBox.Text);
            string nameButton = ((Button)sender).Name;
            IOneArgument factoryForOneArg = OperationsFactory.CreateTrigonometriaOperation(nameButton);
            Result.Text = factoryForOneArg.Calculate(firstField).ToString();
        }
        /// <summary>
        /// Ban on entry words in first field
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Symbol</param>
        private void InputFirstTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 59) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Ban on entry words in second field
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Symbol</param>
        private void InputSecondTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar!= 32) && (e.KeyChar !=59 ) &&(e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
    }
}
