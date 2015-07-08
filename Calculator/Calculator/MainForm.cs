using System;
using System.Collections.Generic;
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
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 59) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void InputSecondTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar!= 32) && (e.KeyChar !=59 ) &&(e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
    }
}
