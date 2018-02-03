using System;
using System.Drawing;
using System.Windows.Forms;

namespace _300960704_Rodrigo_ASS01
{
    /// <summary>
    /// Class responsible for handling the drawing panel form.
    /// </summary>
    public partial class PainterForm : Form
    {
        // Contants containing the possible brush sizes.
        private const int SMALL = 4;
        private const int MEDIUM = 8;
        private const int LARGE = 12;

        // The selected color by the user.
        private Color selectedColor;

        // The selected size by the user.
        private int selectedBrushSize;

        // Indicates if the painting is enabled or not.
        private bool paint = false;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PainterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the selected color to Red.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectColor(sender as RadioButton, Color.Red);
        }

        /// <summary>
        /// Changes the selected color to Blue.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void BlueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectColor(sender as RadioButton, Color.Blue);
        }

        /// <summary>
        /// Changes the selected color to Green.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectColor(sender as RadioButton, Color.Green);
        }

        /// <summary>
        /// Changes the selected color to Black.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void BlackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectColor(sender as RadioButton, Color.Black);
        }

        /// <summary>
        /// Selects the given color if the radio button is checked.
        /// </summary>
        /// <param name="radioButton">The radio button to validate.</param>
        /// <param name="color">The color selected by the user.</param>
        private void SelectColor(RadioButton radioButton, Color color)
        {
            if (radioButton.Checked)
            {
                selectedColor = color;
            }
        }

        /// <summary>
        /// Sets the brush size to small based on the user choice.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void SmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectSize(sender as RadioButton, SMALL);
        }

        /// <summary>
        /// Sets the brush size to medium based on the user choice.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectSize(sender as RadioButton, MEDIUM);
        }

        /// <summary>
        /// Sets the brush size to large based on the user choice.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void LargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectSize(sender as RadioButton, LARGE);
        }

        /// <summary>
        /// Selects the given color if the radio button is checked.
        /// </summary>
        /// <param name="radioButton">The radio button to validate.</param>
        /// <param name="size">The size selected by the user</param>
        private void SelectSize(RadioButton radioButton, int size)
        {
            if (radioButton.Checked)
            {
                selectedBrushSize = size;
            }
        }

        /// <summary>
        /// When the mouse is down on the panel the paiting is enabled.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void DrawingAreaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        /// <summary>
        /// When the mouse is up on the panel the paiting is disabled.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments.</param>
        private void DrawingAreaPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        /// <summary>
        /// Draws the desired figure when the user is moving the mouse with some mouse button pressed.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DrawingAreaPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Panel drawingPanel = sender as Panel;

            // Check that the paint is enabled.
            if (paint)
            {
                // Draws a circle following the mouse pointer.
                using (Graphics g = drawingPanel.CreateGraphics())
                {
                    g.FillEllipse(new SolidBrush(selectedColor), e.X, e.Y, selectedBrushSize, selectedBrushSize);
                }
            }
        }
    }
}
