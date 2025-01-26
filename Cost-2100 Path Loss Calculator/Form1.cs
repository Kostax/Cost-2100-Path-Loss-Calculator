using System.Diagnostics.Metrics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Cost_2100_Path_Loss_Calculator
{
    public partial class Form1 : Form
    {
        private const string DistancePlaceholder = "Enter Distance(0.1 to 100 km)";
        private const string FrequencyPlaceholder = "Enter Frequency(100 to 10,000 MHz)";
        private const string TransmitPowerPlaceholder = "Enter Transmit Power(-100 to 50 dBm)";
        private const string ReceiverSensitivityPlaceholder = "Enter Receiver Sensitivity(-120 to 0 dBm)";
        private const string AntennaHeightTransmitterPlaceholder = "Enter Transmitter Antenna Height (1 to 250 Meters)";
        private const string AntennaHeightReceiverPlaceholder = "Enter Receiver Antenna Height (1 to 300 Meters)";
        private const string BuildingHeightPlaceholder = "Enter Average Building Height (Meters 1 to 200 Meters)";
        private const string ClutterFactorPlaceholder = "Enter Clutter Factor(0.1 to 6 dBm)";


        public Form1()
        {
            InitializeComponent();



            //Set the placeholder text in the Tag property for each TextBox

            txtDistance.Tag = DistancePlaceholder;
            txtFrequency.Tag = FrequencyPlaceholder;
            txtTransmitPower.Tag = TransmitPowerPlaceholder;
            txtReceiverSensitivity.Tag = ReceiverSensitivityPlaceholder;
            txtAntennaHeightTransmitter.Tag = AntennaHeightTransmitterPlaceholder;
            txtAntennaHeightReceiver.Tag = AntennaHeightReceiverPlaceholder;
            txtBuildingHeight.Tag = BuildingHeightPlaceholder;
            txtClutterFactor.Tag = ClutterFactorPlaceholder;

            // Set the placeholder text and color initially
            SetPlaceholderText();





        }

        private void ShowResults()
        {

            lblResult.Visible = true;
            lblSignalStrength.Visible = true;

        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {

            cmbEnvironment.DroppedDown = true;  // Open the drop-down list

        }

        // Set initial placeholder text for all TextBoxes
        private void SetPlaceholderText()
        {
            SetPlaceholderForTextBox(txtDistance);
            SetPlaceholderForTextBox(txtFrequency);
            SetPlaceholderForTextBox(txtTransmitPower);
            SetPlaceholderForTextBox(txtReceiverSensitivity);
            SetPlaceholderForTextBox(txtAntennaHeightTransmitter);
            SetPlaceholderForTextBox(txtAntennaHeightReceiver);
            SetPlaceholderForTextBox(txtBuildingHeight);
            SetPlaceholderForTextBox(txtClutterFactor);
        }

        // Set placeholder text in the TextBox if it's empty
        private void SetPlaceholderForTextBox(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray; // Placeholder text color
            }
        }


        // Handle Enter event (when the user clicks inside the TextBox)
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Gray; // Reset text color
            }
        }


        // Handle Leave event (when the user clicks outside the TextBox)
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString(); // Restore placeholder text
                textBox.ForeColor = Color.Gray; // Placeholder color
            }
        }



        private bool HighlightEmptyFields()
        {
            bool allFieldsFilled = true; // Flag to track if all fields are filled

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {


                    if (string.IsNullOrWhiteSpace(textBox.Text) || (textBox.Tag != null && textBox.Text == textBox.Tag.ToString())) // Check if the TextBox is empty or placeholdered
                    {
                        textBox.BackColor = Color.Red; // Highlight empty TextBox in red
                        allFieldsFilled = false;      // Mark as incomplete
                    }

                    else
                    {
                        textBox.BackColor = SystemColors.Window; // Reset background for filled TextBox
                    }

                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1) // Check if no item is selected
                    {
                        comboBox.BackColor = Color.Red; // Highlight empty ComboBox in red
                        allFieldsFilled = false;       // Mark as incomplete
                    }
                    else
                    {
                        comboBox.BackColor = SystemColors.Window; // Reset background for filled ComboBox
                    }
                }
            }

            return allFieldsFilled; // Return whether all fields are valid
        }


        private bool ValidateInputs()
        {
            double value;

            // Validate distance (in kilometers, reasonable range 0.1 to 100 km)
            if (!double.TryParse(txtDistance.Text, out value) || value < 0.1 || value > 100)
            {
                MessageBox.Show("Please enter a valid distance in kilometers (0.1 to 100 km).");
                txtDistance.Focus();
                return false;
            }

            // Validate frequency (in MHz, reasonable range 100 to 10,000 MHz)
            if (!double.TryParse(txtFrequency.Text, out value) || value < 100 || value > 10000)
            {
                MessageBox.Show("Please enter a valid frequency in MHz (100 to 10,000 MHz).");
                txtFrequency.Focus();
                return false;
            }

            // Validate transmit power (in dBm, reasonable range -100 to 50 dBm)
            if (!double.TryParse(txtTransmitPower.Text, out value) || value < -100 || value > 50)
            {
                MessageBox.Show("Please enter a valid transmit power in dBm (-100 to 50 dBm).");
                txtTransmitPower.Focus();
                return false;
            }

            // Validate receiver sensitivity (in dBm, reasonable range -120 to 0 dBm)
            if (!double.TryParse(txtReceiverSensitivity.Text, out value) || value < -120 || value > 0)
            {
                MessageBox.Show("Please enter a valid receiver sensitivity in dBm (-120 to 0 dBm).");
                txtReceiverSensitivity.Focus();
                return false;
            }

            // Validate antenna height (in meters, reasonable range 1 to 250 m)
            if (!double.TryParse(txtAntennaHeightTransmitter.Text, out value) || value < 1 || value > 250)
            {
                MessageBox.Show("Please enter a valid transmitter antenna height in meters (1 to 250 m).");
                txtAntennaHeightTransmitter.Focus();
                return false;
            }

            if (!double.TryParse(txtAntennaHeightReceiver.Text, out value) || value < 1 || value > 300)
            {
                MessageBox.Show("Please enter a valid receiver antenna height in meters (1 to 300 m).");
                txtAntennaHeightReceiver.Focus();
                return false;
            }

            // Validate building height (in meters, reasonable range 1 to 200 m)
            if (!double.TryParse(txtBuildingHeight.Text, out value) || value < 1 || value > 200)
            {
                MessageBox.Show("Please enter a valid building height in meters (1 to 200 m).");
                txtBuildingHeight.Focus();
                return false;
            }

            // Validate clutter factor (unitless multiplier, reasonable range 0.1 to 6)
            if (!string.IsNullOrWhiteSpace(txtClutterFactor.Text) && txtClutterFactor.Text != txtClutterFactor.Tag?.ToString())
            {



                // Try to parse the value only if the field is not empty or placeholder
                if (!double.TryParse(txtClutterFactor.Text, out value))
                {
                    MessageBox.Show("Please enter a valid numeric value for the Clutter Factor.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Exit if the input is invalid
                }


                // Ensure the value is within the valid range
                if (value <= 0.1 || value > 6)
                {
                    MessageBox.Show("Clutter Factor must be between 0.1 and 6.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Exit if the value is out of range
                }



                return true; // All inputs are valid
            }
            else
            {
                txtClutterFactor.Text = "0.1";
                return true;
            }
        }



        private const double Urban_A = 120;
        private const double Urban_B = 30;
        private const double Urban_C = 2;
        private const double Urban_K = 0;

        private const double Suburban_A = 130;
        private const double Suburban_B = 32;
        private const double Suburban_C = 2.5;
        private const double Suburban_K = 0;


        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Call HighlightEmptyFields and check if all fields are filled

            if (!ValidateInputs())
            {
                return; // Stop calculation
            }
            else
                MessageBox.Show("All fields are valid. Proceeding with calculation.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // Get input values
            double distance = double.Parse(txtDistance.Text);
            double frequency = double.Parse(txtFrequency.Text);
            double transmitPower = double.Parse(txtTransmitPower.Text); // Transmit power in dBm
            double receiverSensitivity = double.Parse(txtReceiverSensitivity.Text); // Receiver sensitivity in dBm
            double antennaHeightTransmitter = double.Parse(txtAntennaHeightTransmitter.Text); // Transmitter antenna height in meters
            double antennaHeightReceiver = double.Parse(txtAntennaHeightReceiver.Text); // Receiver antenna height in meters
            string environment = cmbEnvironment.SelectedItem.ToString();
            double BuildingHeight = double.Parse(txtBuildingHeight.Text);
            double ClutterFactor = double.Parse(txtClutterFactor.Text);













            // Set constants based on environment
            double A, B, C, K;

            if (environment == "Urban")
            {
                A = Urban_A;
                B = Urban_B;
                C = Urban_C;
                K = Urban_K;
            }
            else if (environment == "Suburban")
            {
                A = Suburban_A;
                B = Suburban_B;
                C = Suburban_C;
                K = Suburban_K;
            }
            else
            {
                MessageBox.Show("Please select a valid environment.");
                return;
            }



            // Path Loss Calculation
            double pathLoss = A + B * Math.Log10(distance) + C * Math.Log10(frequency) + K;

            // Adjust path loss based on antenna heights,buildings height and clutter factor
            double antennaCorrection = (antennaHeightTransmitter * antennaHeightReceiver) / distance;
            double buildingHeightFactor = BuildingHeight * 0.5;
            double clutterAdjustment = ClutterFactor > 0 ? ClutterFactor * 2 : 0;
            pathLoss += antennaCorrection + buildingHeightFactor + clutterAdjustment;

            // Display the result
            lblResult.Text = "Path Loss: " + pathLoss.ToString("F2") + " dB";

            // Optional: Calculate signal strength at receiver (taking transmit power into account)
            double receivedSignalStrength = transmitPower - pathLoss;
            lblSignalStrength.Text = "Received Signal Strength: " + receivedSignalStrength.ToString("F2") + " dBm";

            // Optional: Check if the received signal is above receiver sensitivity
            if (receivedSignalStrength >= receiverSensitivity)
            {
                lblResult.Text += "\nSignal is above sensitivity threshold!";
            }
            else
            {
                lblResult.Text += "\nSignal is below sensitivity threshold.";
            }

            ShowResults();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            {
                txtDistance.Clear();
                txtFrequency.Clear();
                txtTransmitPower.Clear();
                txtReceiverSensitivity.Clear();
                txtAntennaHeightTransmitter.Clear();
                txtAntennaHeightReceiver.Clear();
                txtBuildingHeight.Clear();
                txtClutterFactor.Clear();
                cmbEnvironment.SelectedIndex = -1; // Or default to the first option
                lblResult.Visible = false;
                lblSignalStrength.Visible = false;


                SetPlaceholderForTextBox(txtDistance);
                SetPlaceholderForTextBox(txtFrequency);
                SetPlaceholderForTextBox(txtTransmitPower);
                SetPlaceholderForTextBox(txtReceiverSensitivity);
                SetPlaceholderForTextBox(txtAntennaHeightTransmitter);
                SetPlaceholderForTextBox(txtAntennaHeightReceiver);
                SetPlaceholderForTextBox(txtBuildingHeight);
                SetPlaceholderForTextBox(txtClutterFactor);
            }
        }
    }
}
