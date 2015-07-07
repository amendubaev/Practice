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
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputSecondTextBox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.InputFirstTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // InputSecondTextBox
            // 
            this.InputSecondTextBox.Location = new System.Drawing.Point(146, 25);
            this.InputSecondTextBox.Name = "InputSecondTextBox";
            this.InputSecondTextBox.Size = new System.Drawing.Size(129, 20);
            this.InputSecondTextBox.TabIndex = 2;
            this.InputSecondTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputSecondTextBox_KeyPress);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 74);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(260, 20);
            this.Result.TabIndex = 4;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(12, 58);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            // 
            // InputFirstTextBox
            // 
            this.InputFirstTextBox.Location = new System.Drawing.Point(12, 25);
            this.InputFirstTextBox.Name = "InputFirstTextBox";
            this.InputFirstTextBox.Size = new System.Drawing.Size(112, 20);
            this.InputFirstTextBox.TabIndex = 1;
            this.InputFirstTextBox.Tag = "";
            this.InputFirstTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputFirstTextBox_KeyPress);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Orange;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(14, 100);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(38, 37);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.CommonCalculator);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.Orange;
            this.Subtract.FlatAppearance.BorderSize = 0;
            this.Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtract.Location = new System.Drawing.Point(58, 100);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(38, 37);
            this.Subtract.TabIndex = 4;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.CommonCalculator);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Orange;
            this.Multiply.FlatAppearance.BorderSize = 0;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Location = new System.Drawing.Point(102, 100);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(38, 37);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.CommonCalculator);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Orange;
            this.Divide.FlatAppearance.BorderSize = 0;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Location = new System.Drawing.Point(146, 100);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(38, 37);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.CommonCalculator);
            // 
            // Pow
            // 
            this.Pow.BackColor = System.Drawing.Color.Orange;
            this.Pow.FlatAppearance.BorderSize = 0;
            this.Pow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pow.Location = new System.Drawing.Point(190, 100);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(38, 37);
            this.Pow.TabIndex = 7;
            this.Pow.Text = "x^";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.PowInCalculator);
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.Color.Orange;
            this.Sin.FlatAppearance.BorderSize = 0;
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sin.Location = new System.Drawing.Point(234, 100);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(38, 37);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.SinInCalculator);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainFormLoad);
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
    }
}

