using System;
using System.Windows.Forms;

namespace _300960704_Rodrigo_ASS01
{
    /// <summary>
    /// Form responsible for converting the temperature from Fahrenheit to Celsius.
    /// </summary>
    public partial class FahrenheitToCelsiusForm : Form
    {
        public FahrenheitToCelsiusForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the new temperature.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertTemperatureButton_Click(object sender, EventArgs e)
        {
            string temperatureToConvert = FahrenheitTextBox.Text;

            if (string.IsNullOrWhiteSpace(temperatureToConvert))
            {
                // Displays a warning to fill the temperature value.
                MessageBox.Show(
                    "Please, enter a value in the 'Temperature in Fahrenheit' text box!",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                if (int.TryParse(temperatureToConvert, out int temperatureInFahrenheit))
                {
                    var temperatureInCelsius = (5.0f / 9.0f) * (temperatureInFahrenheit - 32.0f);
                    CelsiusValueLabel.Text = temperatureInCelsius.ToString("0.##");
                }
                else
                {
                    // Displays a warning to insert a number as a temperature.
                    MessageBox.Show(
                        "Please, enter a valid number in the 'Temperature in Fahrenheit' text box!",
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
    }
}
