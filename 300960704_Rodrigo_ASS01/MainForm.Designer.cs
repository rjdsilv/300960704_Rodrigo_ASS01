namespace _300960704_Rodrigo_ASS01
{
    partial class MainForm
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
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.ShowPrinterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorButton.Location = new System.Drawing.Point(12, 12);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(136, 59);
            this.CalculatorButton.TabIndex = 0;
            this.CalculatorButton.Text = "Show Calculator";
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ShowPrinterButton
            // 
            this.ShowPrinterButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPrinterButton.Location = new System.Drawing.Point(154, 12);
            this.ShowPrinterButton.Name = "ShowPrinterButton";
            this.ShowPrinterButton.Size = new System.Drawing.Size(136, 59);
            this.ShowPrinterButton.TabIndex = 1;
            this.ShowPrinterButton.Text = "Show Printer Form";
            this.ShowPrinterButton.UseVisualStyleBackColor = true;
            this.ShowPrinterButton.Click += new System.EventHandler(this.ShowPrinterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 82);
            this.Controls.Add(this.ShowPrinterButton);
            this.Controls.Add(this.CalculatorButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Button ShowPrinterButton;
    }
}

