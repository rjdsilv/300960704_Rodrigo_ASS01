namespace _300960704_Rodrigo_ASS01
{
    partial class PainterForm
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
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.DrawingAreaPanel = new System.Windows.Forms.Panel();
            this.ColorGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.BlackRadioButton);
            this.ColorGroupBox.Controls.Add(this.GreenRadioButton);
            this.ColorGroupBox.Controls.Add(this.BlueRadioButton);
            this.ColorGroupBox.Controls.Add(this.RedRadioButton);
            this.ColorGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(118, 145);
            this.ColorGroupBox.TabIndex = 0;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "  Color  ";
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(25, 113);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(62, 23);
            this.BlackRadioButton.TabIndex = 3;
            this.BlackRadioButton.Text = "Black";
            this.BlackRadioButton.UseVisualStyleBackColor = true;
            this.BlackRadioButton.CheckedChanged += new System.EventHandler(this.BlackRadioButton_CheckedChanged);
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(25, 84);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(66, 23);
            this.GreenRadioButton.TabIndex = 2;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.Text = "Green";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.GreenRadioButton_CheckedChanged);
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(25, 55);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(56, 23);
            this.BlueRadioButton.TabIndex = 1;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.Text = "Blue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.BlueRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(25, 26);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(52, 23);
            this.RedRadioButton.TabIndex = 0;
            this.RedRadioButton.TabStop = true;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.LargeRadioButton);
            this.SizeGroupBox.Controls.Add(this.MediumRadioButton);
            this.SizeGroupBox.Controls.Add(this.SmallRadioButton);
            this.SizeGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeGroupBox.Location = new System.Drawing.Point(13, 173);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(118, 116);
            this.SizeGroupBox.TabIndex = 4;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "  Size  ";
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(25, 84);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(63, 23);
            this.LargeRadioButton.TabIndex = 2;
            this.LargeRadioButton.TabStop = true;
            this.LargeRadioButton.Text = "Large";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.LargeRadioButton_CheckedChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(25, 55);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(80, 23);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(25, 26);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(62, 23);
            this.SmallRadioButton.TabIndex = 0;
            this.SmallRadioButton.TabStop = true;
            this.SmallRadioButton.Text = "Small";
            this.SmallRadioButton.UseVisualStyleBackColor = true;
            this.SmallRadioButton.CheckedChanged += new System.EventHandler(this.SmallRadioButton_CheckedChanged);
            // 
            // DrawingAreaPanel
            // 
            this.DrawingAreaPanel.BackColor = System.Drawing.Color.White;
            this.DrawingAreaPanel.Location = new System.Drawing.Point(144, 16);
            this.DrawingAreaPanel.Name = "DrawingAreaPanel";
            this.DrawingAreaPanel.Size = new System.Drawing.Size(395, 292);
            this.DrawingAreaPanel.TabIndex = 5;
            this.DrawingAreaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingAreaPanel_MouseDown);
            this.DrawingAreaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingAreaPanel_MouseMove);
            this.DrawingAreaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingAreaPanel_MouseUp);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.DrawingAreaPanel);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.ColorGroupBox);
            this.Name = "PainterForm";
            this.Text = "Drawing Panel";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton BlackRadioButton;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton SmallRadioButton;
        private System.Windows.Forms.Panel DrawingAreaPanel;
    }
}