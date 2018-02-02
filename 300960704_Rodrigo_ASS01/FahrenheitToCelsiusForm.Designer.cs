namespace _300960704_Rodrigo_ASS01
{
    partial class FahrenheitToCelsiusForm
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
            this.FahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.CelsiusValueLabel = new System.Windows.Forms.Label();
            this.ConvertTemperatureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrenheitTextBox
            // 
            this.FahrenheitTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitTextBox.Location = new System.Drawing.Point(12, 35);
            this.FahrenheitTextBox.Name = "FahrenheitTextBox";
            this.FahrenheitTextBox.Size = new System.Drawing.Size(333, 33);
            this.FahrenheitTextBox.TabIndex = 0;
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.AutoSize = true;
            this.FahrenheitLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitLabel.Location = new System.Drawing.Point(8, 13);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(191, 19);
            this.FahrenheitLabel.TabIndex = 1;
            this.FahrenheitLabel.Text = "Temperature in Fahrenheits:";
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusLabel.Location = new System.Drawing.Point(12, 84);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(162, 19);
            this.CelsiusLabel.TabIndex = 2;
            this.CelsiusLabel.Text = "Temperature in Celsius:";
            // 
            // CelsiusValueLabel
            // 
            this.CelsiusValueLabel.AutoSize = true;
            this.CelsiusValueLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.CelsiusValueLabel.Location = new System.Drawing.Point(12, 103);
            this.CelsiusValueLabel.Name = "CelsiusValueLabel";
            this.CelsiusValueLabel.Size = new System.Drawing.Size(0, 27);
            this.CelsiusValueLabel.TabIndex = 3;
            // 
            // ConvertTemperatureButton
            // 
            this.ConvertTemperatureButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertTemperatureButton.Location = new System.Drawing.Point(100, 143);
            this.ConvertTemperatureButton.Name = "ConvertTemperatureButton";
            this.ConvertTemperatureButton.Size = new System.Drawing.Size(157, 41);
            this.ConvertTemperatureButton.TabIndex = 4;
            this.ConvertTemperatureButton.Text = "Convert Temperature";
            this.ConvertTemperatureButton.UseVisualStyleBackColor = true;
            this.ConvertTemperatureButton.Click += new System.EventHandler(this.ConvertTemperatureButton_Click);
            // 
            // FahrenheitToCelsiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 196);
            this.Controls.Add(this.ConvertTemperatureButton);
            this.Controls.Add(this.CelsiusValueLabel);
            this.Controls.Add(this.CelsiusLabel);
            this.Controls.Add(this.FahrenheitLabel);
            this.Controls.Add(this.FahrenheitTextBox);
            this.Name = "FahrenheitToCelsiusForm";
            this.Text = "Fahrenheit to Celsius Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FahrenheitTextBox;
        private System.Windows.Forms.Label FahrenheitLabel;
        private System.Windows.Forms.Label CelsiusLabel;
        private System.Windows.Forms.Label CelsiusValueLabel;
        private System.Windows.Forms.Button ConvertTemperatureButton;
    }
}