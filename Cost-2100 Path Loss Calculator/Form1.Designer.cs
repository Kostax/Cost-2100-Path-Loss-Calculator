using System;
using System.Windows.Forms;
namespace Cost_2100_Path_Loss_Calculator
{
    partial class Form1
    {

        

        private System.ComponentModel.IContainer components = null;

        
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDistance = new TextBox();
            txtFrequency = new TextBox();
            txtTransmitPower = new TextBox();
            cmbEnvironment = new ComboBox();
            txtReceiverSensitivity = new TextBox();
            txtAntennaHeightTransmitter = new TextBox();
            txtAntennaHeightReceiver = new TextBox();
            button1 = new Button();
            lblResult = new Label();
            lblSignalStrength = new Label();
            txtBuildingHeight = new TextBox();
            txtClutterFactor = new TextBox();
            label3 = new Label();
            btnReset = new Button();
            btnSaveResults = new Button();
            btnLoadResults = new Button();
            dgvHistory = new DataGridView();
            cmbMIMO = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // txtDistance
            // 
            txtDistance.BackColor = SystemColors.Control;
            txtDistance.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDistance.ForeColor = Color.Gray;
            txtDistance.Location = new Point(12, 236);
            txtDistance.Margin = new Padding(3, 2, 3, 2);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(384, 27);
            txtDistance.TabIndex = 1;
            txtDistance.Click += TextBox_Enter;
            txtDistance.Leave += TextBox_Leave;
            txtDistance.MouseHover += TextBox_MouseHover;
            // 
            // txtFrequency
            // 
            txtFrequency.BackColor = SystemColors.Control;
            txtFrequency.Font = new Font("Arial", 10.2F);
            txtFrequency.ForeColor = Color.Gray;
            txtFrequency.Location = new Point(418, 316);
            txtFrequency.Margin = new Padding(3, 2, 3, 2);
            txtFrequency.Name = "txtFrequency";
            txtFrequency.Size = new Size(384, 27);
            txtFrequency.TabIndex = 10;
            txtFrequency.Click += TextBox_Enter;
            txtFrequency.Leave += TextBox_Leave;
            txtFrequency.MouseHover += TextBox_MouseHover;
            // 
            // txtTransmitPower
            // 
            txtTransmitPower.BackColor = SystemColors.Control;
            txtTransmitPower.Font = new Font("Arial", 10.2F);
            txtTransmitPower.ForeColor = Color.Gray;
            txtTransmitPower.Location = new Point(418, 236);
            txtTransmitPower.Margin = new Padding(3, 2, 3, 2);
            txtTransmitPower.Name = "txtTransmitPower";
            txtTransmitPower.Size = new Size(384, 27);
            txtTransmitPower.TabIndex = 7;
            txtTransmitPower.Click += TextBox_Enter;
            txtTransmitPower.Leave += TextBox_Leave;
            txtTransmitPower.MouseHover += TextBox_MouseHover;
            // 
            // cmbEnvironment
            // 
            cmbEnvironment.BackColor = SystemColors.Control;
            cmbEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEnvironment.ForeColor = Color.Black;
            cmbEnvironment.FormattingEnabled = true;
            cmbEnvironment.Items.AddRange(new object[] { "Urban", "Suburban" });
            cmbEnvironment.Location = new Point(199, 144);
            cmbEnvironment.Margin = new Padding(3, 2, 3, 2);
            cmbEnvironment.Name = "cmbEnvironment";
            cmbEnvironment.Size = new Size(218, 28);
            cmbEnvironment.TabIndex = 4;
            cmbEnvironment.Click += ComboBox1_Click;
            // 
            // txtReceiverSensitivity
            // 
            txtReceiverSensitivity.BackColor = SystemColors.Control;
            txtReceiverSensitivity.Font = new Font("Arial", 10.2F);
            txtReceiverSensitivity.ForeColor = Color.Gray;
            txtReceiverSensitivity.Location = new Point(418, 276);
            txtReceiverSensitivity.Margin = new Padding(3, 2, 3, 2);
            txtReceiverSensitivity.Name = "txtReceiverSensitivity";
            txtReceiverSensitivity.Size = new Size(384, 27);
            txtReceiverSensitivity.TabIndex = 9;
            txtReceiverSensitivity.Click += TextBox_Enter;
            txtReceiverSensitivity.Leave += TextBox_Leave;
            txtReceiverSensitivity.MouseHover += TextBox_MouseHover;
            // 
            // txtAntennaHeightTransmitter
            // 
            txtAntennaHeightTransmitter.BackColor = SystemColors.Control;
            txtAntennaHeightTransmitter.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtAntennaHeightTransmitter.ForeColor = Color.Gray;
            txtAntennaHeightTransmitter.Location = new Point(13, 276);
            txtAntennaHeightTransmitter.Margin = new Padding(3, 2, 3, 2);
            txtAntennaHeightTransmitter.Name = "txtAntennaHeightTransmitter";
            txtAntennaHeightTransmitter.Size = new Size(384, 27);
            txtAntennaHeightTransmitter.TabIndex = 2;
            txtAntennaHeightTransmitter.Click += TextBox_Enter;
            txtAntennaHeightTransmitter.Leave += TextBox_Leave;
            txtAntennaHeightTransmitter.MouseHover += TextBox_MouseHover;
            // 
            // txtAntennaHeightReceiver
            // 
            txtAntennaHeightReceiver.BackColor = SystemColors.Control;
            txtAntennaHeightReceiver.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtAntennaHeightReceiver.ForeColor = Color.Gray;
            txtAntennaHeightReceiver.Location = new Point(13, 316);
            txtAntennaHeightReceiver.Margin = new Padding(3, 2, 3, 2);
            txtAntennaHeightReceiver.Name = "txtAntennaHeightReceiver";
            txtAntennaHeightReceiver.Size = new Size(384, 27);
            txtAntennaHeightReceiver.TabIndex = 3;
            txtAntennaHeightReceiver.Click += TextBox_Enter;
            txtAntennaHeightReceiver.Leave += TextBox_Leave;
            txtAntennaHeightReceiver.MouseHover += TextBox_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatAppearance.MouseOverBackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(621, 402);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(181, 43);
            button1.TabIndex = 12;
            button1.Text = ">Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.Control;
            lblResult.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(10, 486);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(386, 62);
            lblResult.TabIndex = 13;
            lblResult.Text = "Result";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Visible = false;
            // 
            // lblSignalStrength
            // 
            lblSignalStrength.BackColor = SystemColors.Control;
            lblSignalStrength.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            lblSignalStrength.ForeColor = SystemColors.ActiveCaptionText;
            lblSignalStrength.Location = new Point(418, 482);
            lblSignalStrength.Name = "lblSignalStrength";
            lblSignalStrength.Size = new Size(384, 62);
            lblSignalStrength.TabIndex = 15;
            lblSignalStrength.Text = "Signal Strength";
            lblSignalStrength.TextAlign = ContentAlignment.MiddleCenter;
            lblSignalStrength.Visible = false;
            // 
            // txtBuildingHeight
            // 
            txtBuildingHeight.BackColor = SystemColors.Control;
            txtBuildingHeight.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtBuildingHeight.ForeColor = Color.Gray;
            txtBuildingHeight.Location = new Point(13, 357);
            txtBuildingHeight.Margin = new Padding(3, 2, 3, 2);
            txtBuildingHeight.Name = "txtBuildingHeight";
            txtBuildingHeight.Size = new Size(384, 27);
            txtBuildingHeight.TabIndex = 16;
            txtBuildingHeight.Click += TextBox_Enter;
            txtBuildingHeight.Leave += TextBox_Leave;
            txtBuildingHeight.MouseHover += TextBox_MouseHover;
            // 
            // txtClutterFactor
            // 
            txtClutterFactor.BackColor = SystemColors.Control;
            txtClutterFactor.Font = new Font("Arial", 10.2F);
            txtClutterFactor.ForeColor = Color.Gray;
            txtClutterFactor.Location = new Point(418, 357);
            txtClutterFactor.Margin = new Padding(3, 2, 3, 2);
            txtClutterFactor.Name = "txtClutterFactor";
            txtClutterFactor.Size = new Size(384, 27);
            txtClutterFactor.TabIndex = 17;
            txtClutterFactor.Click += TextBox_Enter;
            txtClutterFactor.Leave += TextBox_Leave;
            txtClutterFactor.MouseHover += TextBox_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 144);
            label3.Name = "label3";
            label3.Size = new Size(180, 29);
            label3.TabIndex = 18;
            label3.Text = "Select City Density";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.FlatAppearance.BorderColor = Color.DarkCyan;
            btnReset.FlatAppearance.BorderSize = 4;
            btnReset.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(9, 402);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(147, 34);
            btnReset.TabIndex = 19;
            btnReset.Text = "Clear All";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSaveResults
            // 
            btnSaveResults.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            btnSaveResults.ForeColor = Color.Black;
            btnSaveResults.Location = new Point(632, 560);
            btnSaveResults.Margin = new Padding(3, 2, 3, 2);
            btnSaveResults.Name = "btnSaveResults";
            btnSaveResults.Size = new Size(170, 32);
            btnSaveResults.TabIndex = 20;
            btnSaveResults.Text = "Save Results";
            btnSaveResults.UseVisualStyleBackColor = true;
            btnSaveResults.Visible = false;
            btnSaveResults.Click += btnSaveResults_Click;
            // 
            // btnLoadResults
            // 
            btnLoadResults.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            btnLoadResults.ForeColor = Color.Black;
            btnLoadResults.Location = new Point(851, 498);
            btnLoadResults.Margin = new Padding(3, 2, 3, 2);
            btnLoadResults.Name = "btnLoadResults";
            btnLoadResults.Size = new Size(132, 31);
            btnLoadResults.TabIndex = 21;
            btnLoadResults.Text = "Load Results";
            btnLoadResults.UseVisualStyleBackColor = true;
            btnLoadResults.Click += btnLoadResults_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(808, 7);
            dgvHistory.Margin = new Padding(3, 2, 3, 2);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.ShowCellErrors = false;
            dgvHistory.ShowCellToolTips = false;
            dgvHistory.ShowEditingIcon = false;
            dgvHistory.ShowRowErrors = false;
            dgvHistory.Size = new Size(744, 487);
            dgvHistory.TabIndex = 22;
            // 
            // cmbMIMO
            // 
            cmbMIMO.BackColor = SystemColors.Control;
            cmbMIMO.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMIMO.ForeColor = Color.Black;
            cmbMIMO.FormattingEnabled = true;
            cmbMIMO.Items.AddRange(new object[] { "1x1", "2x2", "4x4" });
            cmbMIMO.Location = new Point(199, 183);
            cmbMIMO.Margin = new Padding(3, 2, 3, 2);
            cmbMIMO.Name = "cmbMIMO";
            cmbMIMO.Size = new Size(218, 28);
            cmbMIMO.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(69, 183);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 24;
            label4.Text = "Apply MIMO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(411, 55);
            label2.TabIndex = 26;
            label2.Text = "Cost-2100 Model ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(9, 62);
            label6.Name = "label6";
            label6.Size = new Size(412, 61);
            label6.TabIndex = 27;
            label6.Text = " Predict the propagation of radio waves in urban and suburban environments.";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1555, 725);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(cmbMIMO);
            Controls.Add(dgvHistory);
            Controls.Add(btnLoadResults);
            Controls.Add(btnSaveResults);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(txtClutterFactor);
            Controls.Add(txtBuildingHeight);
            Controls.Add(lblSignalStrength);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(txtFrequency);
            Controls.Add(txtReceiverSensitivity);
            Controls.Add(txtTransmitPower);
            Controls.Add(cmbEnvironment);
            Controls.Add(txtAntennaHeightReceiver);
            Controls.Add(txtAntennaHeightTransmitter);
            Controls.Add(txtDistance);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = SystemColors.ActiveBorder;
            Click += TextBox_Leave;
            DoubleClick += TextBox_Leave;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDistance;
        private TextBox txtFrequency;
        private TextBox txtTransmitPower;
        private ComboBox cmbEnvironment;
        private TextBox txtReceiverSensitivity;
        private TextBox txtAntennaHeightTransmitter;
        private TextBox txtAntennaHeightReceiver;
        private Button button1;
        private Label lblResult;
        private Label lblSignalStrength;
        private TextBox txtBuildingHeight;
        private TextBox txtClutterFactor;
        private Label label3;
        private Button btnReset;
        private Button btnSaveResults;
        private Button btnLoadResults;
        private DataGridView dgvHistory;
        private ComboBox cmbMIMO;
        private Label label4;
        private Label label2;
        private Label label6;
    }
}
