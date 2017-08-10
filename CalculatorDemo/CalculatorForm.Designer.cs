namespace CalculatorDemo
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.timesButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.buttonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTableLayout
            // 
            this.buttonTableLayout.ColumnCount = 4;
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.Controls.Add(this.equalsButton, 3, 4);
            this.buttonTableLayout.Controls.Add(this.decimalButton, 2, 4);
            this.buttonTableLayout.Controls.Add(this.zeroButton, 1, 4);
            this.buttonTableLayout.Controls.Add(this.plusMinusButton, 0, 4);
            this.buttonTableLayout.Controls.Add(this.plusButton, 3, 3);
            this.buttonTableLayout.Controls.Add(this.threeButton, 2, 3);
            this.buttonTableLayout.Controls.Add(this.twoButton, 1, 3);
            this.buttonTableLayout.Controls.Add(this.oneButton, 0, 3);
            this.buttonTableLayout.Controls.Add(this.minusButton, 3, 2);
            this.buttonTableLayout.Controls.Add(this.sixButton, 2, 2);
            this.buttonTableLayout.Controls.Add(this.fiveButton, 1, 2);
            this.buttonTableLayout.Controls.Add(this.fourButton, 0, 2);
            this.buttonTableLayout.Controls.Add(this.timesButton, 3, 1);
            this.buttonTableLayout.Controls.Add(this.nineButton, 2, 1);
            this.buttonTableLayout.Controls.Add(this.eightButton, 1, 1);
            this.buttonTableLayout.Controls.Add(this.sevenButton, 0, 1);
            this.buttonTableLayout.Controls.Add(this.divideButton, 3, 0);
            this.buttonTableLayout.Controls.Add(this.backspaceButton, 2, 0);
            this.buttonTableLayout.Controls.Add(this.clearButton, 0, 0);
            this.buttonTableLayout.Location = new System.Drawing.Point(2, 107);
            this.buttonTableLayout.Name = "buttonTableLayout";
            this.buttonTableLayout.RowCount = 5;
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTableLayout.Size = new System.Drawing.Size(293, 299);
            this.buttonTableLayout.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(5, 22);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(287, 64);
            this.ResultTextBox.TabIndex = 1;
            // 
            // clearButton
            // 
            this.buttonTableLayout.SetColumnSpan(this.clearButton, 2);
            this.clearButton.Location = new System.Drawing.Point(3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 53);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // backspaceButton
            // 
            this.backspaceButton.Location = new System.Drawing.Point(149, 3);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(67, 53);
            this.backspaceButton.TabIndex = 2;
            this.backspaceButton.Text = "⌫";
            this.backspaceButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(222, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(68, 53);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sevenButton.Location = new System.Drawing.Point(3, 62);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(67, 53);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eightButton.Location = new System.Drawing.Point(76, 62);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(67, 53);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nineButton.Location = new System.Drawing.Point(149, 62);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(67, 53);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            // 
            // timesButton
            // 
            this.timesButton.Location = new System.Drawing.Point(222, 62);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(68, 53);
            this.timesButton.TabIndex = 7;
            this.timesButton.Text = "x";
            this.timesButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fourButton.Location = new System.Drawing.Point(3, 121);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(67, 53);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fiveButton.Location = new System.Drawing.Point(76, 121);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(67, 53);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sixButton.Location = new System.Drawing.Point(149, 121);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(67, 53);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(222, 121);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(68, 53);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oneButton.Location = new System.Drawing.Point(3, 180);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(67, 53);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.twoButton.Location = new System.Drawing.Point(76, 180);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(67, 53);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.threeButton.Location = new System.Drawing.Point(149, 180);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(67, 53);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(222, 180);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(68, 53);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Location = new System.Drawing.Point(3, 239);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(67, 53);
            this.plusMinusButton.TabIndex = 16;
            this.plusMinusButton.Text = "±";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.zeroButton.Location = new System.Drawing.Point(76, 239);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(67, 53);
            this.zeroButton.TabIndex = 17;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.decimalButton.Location = new System.Drawing.Point(149, 239);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(67, 53);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.SkyBlue;
            this.equalsButton.Location = new System.Drawing.Point(222, 239);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(68, 53);
            this.equalsButton.TabIndex = 19;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(294, 409);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.buttonTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculatorForm_FormClosing);
            this.buttonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonTableLayout;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button timesButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button clearButton;
    }
}

