using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputLabel = new Label();
            this.InputSecondTextBox = new TextBox();
            this.Result = new TextBox();
            this.Output = new Label();
            this.InputFirstTextBox = new TextBox();
            this.Add = new Button();
            this.Subtract = new Button();
            this.Multiply = new Button();
            this.Divide = new Button();
            this.Pow = new Button();
            this.Sin = new Button();
            this.Abs = new Button();
            this.Sqrt = new Button();
            this.Cos = new Button();
            this.Tg = new Button();
            this.Ctg = new Button();
            this.BubbleSort = new Button();
            this.GnomeSort = new Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new Point(12, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new Size(31, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // InputSecondTextBox
            // 
            this.InputSecondTextBox.Location = new Point(146, 25);
            this.InputSecondTextBox.Name = "InputSecondTextBox";
            this.InputSecondTextBox.Size = new Size(129, 20);
            this.InputSecondTextBox.TabIndex = 2;
            this.InputSecondTextBox.KeyPress += new KeyPressEventHandler(this.InputSecondTextBoxKeyPress);
            // 
            // Result
            // 
            this.Result.Location = new Point(12, 74);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new Size(260, 20);
            this.Result.TabIndex = 4;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new Point(12, 58);
            this.Output.Name = "Output";
            this.Output.Size = new Size(39, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            // 
            // InputFirstTextBox
            // 
            this.InputFirstTextBox.BackColor = SystemColors.Window;
            this.InputFirstTextBox.Location = new Point(12, 25);
            this.InputFirstTextBox.Name = "InputFirstTextBox";
            this.InputFirstTextBox.Size = new Size(128, 20);
            this.InputFirstTextBox.TabIndex = 1;
            this.InputFirstTextBox.Tag = "";
            this.InputFirstTextBox.KeyPress += new KeyPressEventHandler(this.InputFirstTextBoxKeyPress);
            // 
            // Add
            // 
            this.Add.BackColor = Color.Orange;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = FlatStyle.Flat;
            this.Add.Location = new Point(14, 100);
            this.Add.Name = "Add";
            this.Add.Size = new Size(38, 37);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new EventHandler(this.CalculatorWithTwoArgs);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = Color.Orange;
            this.Subtract.FlatAppearance.BorderSize = 0;
            this.Subtract.FlatStyle = FlatStyle.Flat;
            this.Subtract.Location = new Point(58, 100);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new Size(38, 37);
            this.Subtract.TabIndex = 4;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new EventHandler(this.CalculatorWithTwoArgs);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = Color.Orange;
            this.Multiply.FlatAppearance.BorderSize = 0;
            this.Multiply.FlatStyle = FlatStyle.Flat;
            this.Multiply.Location = new Point(102, 100);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new Size(38, 37);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new EventHandler(this.CalculatorWithTwoArgs);
            // 
            // Divide
            // 
            this.Divide.BackColor = Color.Orange;
            this.Divide.FlatAppearance.BorderSize = 0;
            this.Divide.FlatStyle = FlatStyle.Flat;
            this.Divide.Location = new Point(146, 100);
            this.Divide.Name = "Divide";
            this.Divide.Size = new Size(38, 37);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new EventHandler(this.CalculatorWithTwoArgs);
            // 
            // Pow
            // 
            this.Pow.BackColor = Color.Orange;
            this.Pow.FlatAppearance.BorderSize = 0;
            this.Pow.FlatStyle = FlatStyle.Flat;
            this.Pow.Location = new Point(190, 100);
            this.Pow.Name = "Pow";
            this.Pow.Size = new Size(38, 37);
            this.Pow.TabIndex = 7;
            this.Pow.Text = "x^";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new EventHandler(this.CalculatorWithTwoArgs);
            // 
            // Sin
            // 
            this.Sin.BackColor = Color.Orange;
            this.Sin.FlatAppearance.BorderSize = 0;
            this.Sin.FlatStyle = FlatStyle.Flat;
            this.Sin.Location = new Point(234, 100);
            this.Sin.Name = "Sin";
            this.Sin.Size = new Size(38, 37);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new EventHandler(this.CalculatorWithOneArg);
            // 
            // Abs
            // 
            this.Abs.BackColor = Color.Orange;
            this.Abs.FlatAppearance.BorderSize = 0;
            this.Abs.FlatStyle = FlatStyle.Flat;
            this.Abs.Location = new Point(15, 143);
            this.Abs.Name = "Abs";
            this.Abs.Size = new Size(38, 37);
            this.Abs.TabIndex = 9;
            this.Abs.Text = "|x|";
            this.Abs.UseVisualStyleBackColor = false;
            this.Abs.Click += new EventHandler(this.CalculatorWithOneArg);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = Color.Orange;
            this.Sqrt.FlatAppearance.BorderSize = 0;
            this.Sqrt.FlatStyle = FlatStyle.Flat;
            this.Sqrt.Location = new Point(58, 143);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new Size(38, 37);
            this.Sqrt.TabIndex = 10;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new EventHandler(this.CalculatorWithOneArg);
            // 
            // Cos
            // 
            this.Cos.BackColor = Color.Orange;
            this.Cos.FlatAppearance.BorderSize = 0;
            this.Cos.FlatStyle = FlatStyle.Flat;
            this.Cos.Location = new Point(102, 143);
            this.Cos.Name = "Cos";
            this.Cos.Size = new Size(38, 37);
            this.Cos.TabIndex = 11;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new EventHandler(this.CalculatorWithOneArg);
            // 
            // Tg
            // 
            this.Tg.BackColor = Color.Orange;
            this.Tg.FlatAppearance.BorderSize = 0;
            this.Tg.FlatStyle = FlatStyle.Flat;
            this.Tg.Location = new Point(146, 143);
            this.Tg.Name = "Tg";
            this.Tg.Size = new Size(38, 37);
            this.Tg.TabIndex = 12;
            this.Tg.Text = "tg";
            this.Tg.UseVisualStyleBackColor = false;
            this.Tg.Click += new EventHandler(this.CalculatorWithOneArg);
            // 
            // Ctg
            // 
            this.Ctg.BackColor = Color.Orange;
            this.Ctg.FlatAppearance.BorderSize = 0;
            this.Ctg.FlatStyle = FlatStyle.Flat;
            this.Ctg.Location = new Point(190, 143);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new Size(38, 37);
            this.Ctg.TabIndex = 13;
            this.Ctg.Text = "ctg";
            this.Ctg.UseVisualStyleBackColor = false;
            this.Ctg.Click += new EventHandler(this.CalculatorWithOneArg);
            // 
            // BubbleSort
            // 
            this.BubbleSort.BackColor = Color.Orange;
            this.BubbleSort.FlatAppearance.BorderSize = 0;
            this.BubbleSort.FlatStyle = FlatStyle.Flat;
            this.BubbleSort.Location = new Point(15, 186);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new Size(81, 32);
            this.BubbleSort.TabIndex = 14;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = false;
            this.BubbleSort.Click += new EventHandler(this.ArraySort);
            // 
            // GnomeSort
            // 
            this.GnomeSort.BackColor = Color.Orange;
            this.GnomeSort.FlatAppearance.BorderSize = 0;
            this.GnomeSort.FlatStyle = FlatStyle.Flat;
            this.GnomeSort.Location = new Point(102, 186);
            this.GnomeSort.Name = "GnomeSort";
            this.GnomeSort.Size = new Size(82, 32);
            this.GnomeSort.TabIndex = 15;
            this.GnomeSort.Text = "GnomeSort";
            this.GnomeSort.UseVisualStyleBackColor = false;
            this.GnomeSort.Click += new EventHandler(this.ArraySort);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.GnomeSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.InputFirstTextBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InputSecondTextBox);
            this.Controls.Add(this.InputLabel);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InputLabel;
        private TextBox InputSecondTextBox;
        private TextBox Result;
        private Label Output;
        private TextBox InputFirstTextBox;
        private Button Add;
        private Button Subtract;
        private Button Multiply;
        private Button Divide;
        private Button Pow;
        private Button Sin;
        private Button Abs;
        private Button Sqrt;
        private Button Cos;
        private Button Tg;
        private Button Ctg;
        private Button BubbleSort;
        private Button GnomeSort;
    }
}

