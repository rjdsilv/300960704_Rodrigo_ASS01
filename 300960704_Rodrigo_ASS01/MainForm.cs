using System.Windows.Forms;

namespace _300960704_Rodrigo_ASS01
{
    /// <summary>
    /// Form that will handle all other forms in the application.
    /// </summary>
    public partial class MainForm : Form
    {
        // The Calculator form to be opened.
        private CalculatorForm calculatorForm;

        private PrinterForm printerForm;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button Show Calculator is clicked, the calculator form will be instantiated and shown.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CalculatorButton_Click(object sender, System.EventArgs e)
        {
            calculatorForm = new CalculatorForm();
            calculatorForm.ShowDialog();
        }

        /// <summary>
        /// When the button Show Printer Form is clicked, the printer form will be instantiated and shown.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ShowPrinterButton_Click(object sender, System.EventArgs e)
        {
            printerForm = new PrinterForm();
            printerForm.ShowDialog();
        }
    }
}
