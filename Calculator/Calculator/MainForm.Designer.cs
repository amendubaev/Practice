﻿namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Calculate = new System.Windows.Forms.Button();
            this.OutputTexBox = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.InputFirstTextBox = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
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
            this.InputSecondTextBox.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(180, 100);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(92, 37);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // OutputTexBox
            // 
            this.OutputTexBox.Location = new System.Drawing.Point(12, 74);
            this.OutputTexBox.Name = "OutputTexBox";
            this.OutputTexBox.Size = new System.Drawing.Size(260, 20);
            this.OutputTexBox.TabIndex = 4;
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
            this.InputFirstTextBox.TabIndex = 5;
            this.InputFirstTextBox.TextChanged += new System.EventHandler(this.InputFirstTextBox_TextChanged);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 100);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(36, 37);
            this.Addition.TabIndex = 6;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(54, 100);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(36, 37);
            this.Subtract.TabIndex = 7;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(96, 100);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(36, 37);
            this.Multiply.TabIndex = 8;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(138, 100);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(36, 37);
            this.Divide.TabIndex = 9;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.InputFirstTextBox);
            this.Controls.Add(this.OutputTexBox);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.InputSecondTextBox);
            this.Controls.Add(this.InputLabel);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputSecondTextBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox OutputTexBox;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox InputFirstTextBox;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
    }
}

