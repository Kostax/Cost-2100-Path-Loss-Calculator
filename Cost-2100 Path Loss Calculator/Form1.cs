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
            btnSaveResults.Visible = true;
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
            if (!ValidateInputs())
            {
                return; // Stop calculation if inputs are invalid
            }

            // Get input values
            double distance = double.Parse(txtDistance.Text);
            double frequency = double.Parse(txtFrequency.Text);
            double transmitPower = double.Parse(txtTransmitPower.Text);
            double receiverSensitivity = double.Parse(txtReceiverSensitivity.Text);
            double antennaHeightTransmitter = double.Parse(txtAntennaHeightTransmitter.Text);
            double antennaHeightReceiver = double.Parse(txtAntennaHeightReceiver.Text);
            string environment = cmbEnvironment.SelectedItem.ToString();
            double buildingHeight = double.Parse(txtBuildingHeight.Text);
            double clutterFactor = double.Parse(txtClutterFactor.Text);

            // Select MIMO Configuration
            int numTx = 1, numRx = 1;
            if (cmbMIMO.SelectedItem != null)
            {
                string mimoConfig = cmbMIMO.SelectedItem.ToString();
                if (mimoConfig == "2x2") { numTx = 2; numRx = 2; }
                else if (mimoConfig == "4x4") { numTx = 4; numRx = 4; }
            }

            // Compute MIMO Gain
            double mimoGain = 10 * Math.Log10(numTx * numRx);

            // Set environment constants
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

            // Compute Path Loss (COST-2100 Model)
            double pathLoss = A + B * Math.Log10(distance) + C * Math.Log10(frequency) + K;

            double antennaCorrection = -20 * Math.Log10(antennaHeightTransmitter * antennaHeightReceiver);
            pathLoss += antennaCorrection;

            double buildingHeightFactor = 20 * Math.Log10(buildingHeight);
            pathLoss += buildingHeightFactor;

            double clutterAdjustment = 10 * Math.Log10(clutterFactor);
            //double clutterAdjustment = clutterFactor > 0 ? clutterFactor * 2 : 0;
            pathLoss += clutterAdjustment;

            // Adjust Receiver Sensitivity for MIMO
            double receiverSensitivityMIMO = receiverSensitivity - 10 * Math.Log10(numRx);

            // Compute Received Signal Strength
            double receivedSignalStrength = transmitPower - pathLoss;
            // Apply MIMO Gain to Received Signal Strength
            receivedSignalStrength += 10 * Math.Log10(numRx);
            // Display results
            lblResult.Text = $"Path Loss: {pathLoss:F2} dB (With MIMO)";
            lblSignalStrength.Text = $"Received Signal Strength: {receivedSignalStrength:F2} dBm";

            // Check if signal is above sensitivity threshold
            if (receivedSignalStrength >= receiverSensitivityMIMO)
            {
                lblResult.Text += "\n✅ Signal is above sensitivity threshold - Communication is possible!";
            }
            else
            {
                lblResult.Text += "\n❌ Signal is below sensitivity threshold - Communication will fail!";
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



        /*private void HighlightResults()
        {
            double minPathLoss = double.MaxValue;
            double maxPathLoss = double.MinValue;
            double minSignalStrength = double.MaxValue;
            double maxSignalStrength = double.MinValue;*/

        // Find min/max values
        /*foreach (DataGridViewRow row in dgvHistory.Rows)
        {
            if (row.Cells["PathLoss"].Value != null && row.Cells["SignalStrength"].Value != null)
            {
                double pathLoss = double.Parse(row.Cells["PathLoss"].Value.ToString());
                double signalStrength = double.Parse(row.Cells["SignalStrength"].Value.ToString());

                if (pathLoss < minPathLoss) minPathLoss = pathLoss;
                if (pathLoss > maxPathLoss) maxPathLoss = pathLoss;
                if (signalStrength < minSignalStrength) minSignalStrength = signalStrength;
                if (signalStrength > maxSignalStrength) maxSignalStrength = signalStrength;
            }
        }


       foreach (DataGridViewRow row in dgvHistory.Rows)
        {
            if (row.Cells["PathLoss"].Value != null && row.Cells["SignalStrength"].Value != null)
            {
                double pathLoss = double.Parse(row.Cells["PathLoss"].Value.ToString());
                double signalStrength = double.Parse(row.Cells["SignalStrength"].Value.ToString());

                // Highlight best values (Green)
                if (pathLoss == minPathLoss) row.Cells["PathLoss"].Style.BackColor = Color.LightGreen;
                if (signalStrength == maxSignalStrength) row.Cells["SignalStrength"].Style.BackColor = Color.LightGreen;

                // Highlight worst values (Red)
                if (pathLoss == maxPathLoss) row.Cells["PathLoss"].Style.BackColor = Color.LightCoral;
                if (signalStrength == minSignalStrength) row.Cells["SignalStrength"].Style.BackColor = Color.LightCoral;
            }
        }
    }*/


        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Calculation Results";
                saveFileDialog.FileName = "PathLossHistory.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bool fileExists = File.Exists(saveFileDialog.FileName);

                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, true))
                        {
                            // Write headers only if the file is new
                            if (!fileExists)
                            {
                                writer.WriteLine("Timestamp;Environment;MIMO;Path Loss (dB);Signal Strength (dBm)");
                            }

                            // Get Environment & MIMO Configurations
                            string environment = cmbEnvironment.SelectedItem?.ToString() ?? "Unknown";
                            string mimoConfig = cmbMIMO.SelectedItem?.ToString() ?? "1x1"; // Default 1x1

                            // Extract numeric values from labels (ignore extra text)
                            string pathLossText = lblResult.Text; // Full text from result label
                            string signalStrengthText = lblSignalStrength.Text;

                            // Extract only numeric values using regex
                            string pathLossValue = System.Text.RegularExpressions.Regex.Match(pathLossText, @"[-+]?\d*\.?\d+").Value;
                            string signalStrengthValue = System.Text.RegularExpressions.Regex.Match(signalStrengthText, @"[-+]?\d*\.?\d+").Value;

                            // Ensure correct number formatting
                            if (double.TryParse(pathLossValue, out double pathLoss) && double.TryParse(signalStrengthValue, out double receivedSignalStrength))
                            {
                                string csvLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};{environment};{mimoConfig};{pathLoss:F2};{receivedSignalStrength:F2}";
                                writer.WriteLine(csvLine);
                            }
                            else
                            {
                                MessageBox.Show("Error extracting numeric values. Results were not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        MessageBox.Show("Results saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                openFileDialog.Title = "Load Calculation History";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        // Clear rows but keep column headers
                        dgvHistory.Rows.Clear();

                        // Add columns only if they don't exist
                        if (dgvHistory.Columns.Count == 0)
                        {
                            dgvHistory.Columns.Add("Timestamp", "Timestamp");
                            dgvHistory.Columns.Add("Environment", "Environment");
                            dgvHistory.Columns.Add("MIMO", "MIMO Configuration");
                            dgvHistory.Columns.Add("PathLoss", "Path Loss (dB)");
                            dgvHistory.Columns.Add("SignalStrength", "Signal Strength (dBm)");

                            // Ensure numeric columns display properly
                            dgvHistory.Columns["PathLoss"].DefaultCellStyle.Format = "F2";
                            dgvHistory.Columns["SignalStrength"].DefaultCellStyle.Format = "F2";
                        }

                        foreach (string line in lines.Skip(1)) // Skip header row
                        {
                            string[] data = line.Split(';'); // Using ; as separator

                            if (data.Length == 5)
                            {
                                string timestamp = data[0].Trim();
                                string environment = data[1].Trim();
                                string mimoConfig = data[2].Trim();
                                if (double.TryParse(data[3].Trim(), out double pathLoss) && double.TryParse(data[4].Trim(), out double signalStrength))
                                {
                                    dgvHistory.Rows.Add(timestamp, environment, mimoConfig, pathLoss.ToString("F2"), signalStrength.ToString("F2"));
                                }
                            }
                        }

                        MessageBox.Show("History loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //HighlightResults();
        }


    }
}
