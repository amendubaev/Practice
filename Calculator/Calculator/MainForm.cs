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
        /// <param name="sender">
        /// Button sender 
        /// </param>
        /// <param name="e">
        /// Operation name
        /// </param>
        public void ArraySort(object sender, EventArgs e)
        {
            try
            {
                double[] mas = ValidationArrays.GetArray(InputFirstTextBox);
                string nameButton = ((Button) sender).Name;
                ISorter Factory = ArraySortFactory.CreateSort(nameButton);
                double[] massive = Factory.Sort(mas);
                string result = "";
                for (int j = 0; j < massive.Length; j++)
                {
                    result += Convert.ToString(massive[j] + " ");
                }
                Result.Text = result;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calculator for functions with two arguments
        /// </summary>
        /// <param name="sender">
        /// Button sender
        /// </param>
        /// <param name="e">
        /// Operation name
        /// </param>
        private void CalculatorWithTwoArgs(object sender, EventArgs e)
        {
            try
            {
                double firstField = ValidationNumbers.GetNumber(InputFirstTextBox);
                double secondField = ValidationNumbers.GetNumber(InputSecondTextBox);
                string nameButton = ((Button)sender).Name;
                ITwoArguments factoryForTwoArgs = OperationsFactory.CreateOperation(nameButton);
                Result.Text = factoryForTwoArgs.Calculate(firstField, secondField).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        /// <summary>
        /// Calculator for functions with one argument
        /// </summary>
        /// <param name="sender">
        /// Button sender
        /// </param>
        /// <param name="e">
        /// Operation name
        /// </param>
        public void CalculatorWithOneArg(object sender, EventArgs e)
        {
            try
            {
                double firstField = Convert.ToDouble(InputFirstTextBox.Text);
                string nameButton = ((Button)sender).Name;
                IOneArgument factoryForOneArg = OperationsFactory.CreateTrigonometriaOperation(nameButton);
                Result.Text = factoryForOneArg.Calculate(firstField).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
