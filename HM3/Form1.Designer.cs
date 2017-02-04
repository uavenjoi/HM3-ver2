namespace HM3
{
    partial class Form1
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.checkRevers = new System.Windows.Forms.CheckBox();
            this.checkUpper = new System.Windows.Forms.CheckBox();
            this.checkSpace = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(7, 25);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(683, 152);
            this.OutputTextBox.TabIndex = 0;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(171, 194);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(519, 100);
            this.InputTextBox.TabIndex = 1;
            // 
            // checkRevers
            // 
            this.checkRevers.AutoSize = true;
            this.checkRevers.Location = new System.Drawing.Point(8, 219);
            this.checkRevers.Name = "checkRevers";
            this.checkRevers.Size = new System.Drawing.Size(63, 17);
            this.checkRevers.TabIndex = 2;
            this.checkRevers.Text = "Реверс";
            this.checkRevers.UseVisualStyleBackColor = true;
            // 
            // checkUpper
            // 
            this.checkUpper.AutoSize = true;
            this.checkUpper.Location = new System.Drawing.Point(8, 196);
            this.checkUpper.Name = "checkUpper";
            this.checkUpper.Size = new System.Drawing.Size(157, 17);
            this.checkUpper.TabIndex = 3;
            this.checkUpper.Text = "Все заглавными буквами";
            this.checkUpper.UseVisualStyleBackColor = true;
            // 
            // checkSpace
            // 
            this.checkSpace.AutoSize = true;
            this.checkSpace.Location = new System.Drawing.Point(8, 242);
            this.checkSpace.Name = "checkSpace";
            this.checkSpace.Size = new System.Drawing.Size(123, 17);
            this.checkSpace.TabIndex = 4;
            this.checkSpace.Text = "Добавить пробелы";
            this.checkSpace.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить текст";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Измененный текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkSpace);
            this.Controls.Add(this.checkUpper);
            this.Controls.Add(this.checkRevers);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Form1";
            this.Text = "РедакторТекста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.CheckBox checkRevers;
        private System.Windows.Forms.CheckBox checkUpper;
        private System.Windows.Forms.CheckBox checkSpace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

