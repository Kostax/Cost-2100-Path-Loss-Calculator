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
            label1 = new Label();
            label2 = new Label();
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
            SuspendLayout();
            // 
            // txtDistance
            // 
            txtDistance.BackColor = SystemColors.Control;
            txtDistance.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDistance.ForeColor = Color.Gray;
            txtDistance.Location = new Point(52, 248);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(410, 27);
            txtDistance.TabIndex = 1;
            txtDistance.Click += TextBox_Enter;
            txtDistance.Leave += TextBox_Leave;
            // 
            // txtFrequency
            // 
            txtFrequency.BackColor = SystemColors.Control;
            txtFrequency.Font = new Font("Arial", 10.2F);
            txtFrequency.ForeColor = Color.Gray;
            txtFrequency.Location = new Point(504, 314);
            txtFrequency.Name = "txtFrequency";
            txtFrequency.Size = new Size(410, 27);
            txtFrequency.TabIndex = 10;
            txtFrequency.Click += TextBox_Enter;
            txtFrequency.Leave += TextBox_Leave;
            // 
            // txtTransmitPower
            // 
            txtTransmitPower.BackColor = SystemColors.Control;
            txtTransmitPower.Font = new Font("Arial", 10.2F);
            txtTransmitPower.ForeColor = Color.Gray;
            txtTransmitPower.Location = new Point(504, 248);
            txtTransmitPower.Name = "txtTransmitPower";
            txtTransmitPower.Size = new Size(410, 27);
            txtTransmitPower.TabIndex = 7;
            txtTransmitPower.Click += TextBox_Enter;
            txtTransmitPower.Leave += TextBox_Leave;
            // 
            // cmbEnvironment
            // 
            cmbEnvironment.BackColor = SystemColors.Control;
            cmbEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEnvironment.ForeColor = Color.Black;
            cmbEnvironment.FormattingEnabled = true;
            cmbEnvironment.Items.AddRange(new object[] { "Urban", "Suburban" });
            cmbEnvironment.Location = new Point(430, 177);
            cmbEnvironment.Name = "cmbEnvironment";
            cmbEnvironment.Size = new Size(249, 28);
            cmbEnvironment.TabIndex = 4;
            cmbEnvironment.Click += ComboBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 55);
            label1.TabIndex = 5;
            label1.Text = "Cost-2100 Model ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(51, 64);
            label2.Name = "label2";
            label2.Size = new Size(411, 81);
            label2.TabIndex = 6;
            label2.Text = " Predict the propagation of radio waves in urban and suburban environments.";
            // 
            // txtReceiverSensitivity
            // 
            txtReceiverSensitivity.BackColor = SystemColors.Control;
            txtReceiverSensitivity.Font = new Font("Arial", 10.2F);
            txtReceiverSensitivity.ForeColor = Color.Gray;
            txtReceiverSensitivity.Location = new Point(504, 281);
            txtReceiverSensitivity.Name = "txtReceiverSensitivity";
            txtReceiverSensitivity.Size = new Size(410, 27);
            txtReceiverSensitivity.TabIndex = 9;
            txtReceiverSensitivity.Click += TextBox_Enter;
            txtReceiverSensitivity.Leave += TextBox_Leave;
            // 
            // txtAntennaHeightTransmitter
            // 
            txtAntennaHeightTransmitter.BackColor = SystemColors.Control;
            txtAntennaHeightTransmitter.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtAntennaHeightTransmitter.ForeColor = Color.Gray;
            txtAntennaHeightTransmitter.Location = new Point(52, 281);
            txtAntennaHeightTransmitter.Name = "txtAntennaHeightTransmitter";
            txtAntennaHeightTransmitter.Size = new Size(410, 27);
            txtAntennaHeightTransmitter.TabIndex = 2;
            txtAntennaHeightTransmitter.Click += TextBox_Enter;
            txtAntennaHeightTransmitter.Leave += TextBox_Leave;
            // 
            // txtAntennaHeightReceiver
            // 
            txtAntennaHeightReceiver.BackColor = SystemColors.Control;
            txtAntennaHeightReceiver.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtAntennaHeightReceiver.ForeColor = Color.Gray;
            txtAntennaHeightReceiver.Location = new Point(52, 314);
            txtAntennaHeightReceiver.Name = "txtAntennaHeightReceiver";
            txtAntennaHeightReceiver.Size = new Size(410, 27);
            txtAntennaHeightReceiver.TabIndex = 3;
            txtAntennaHeightReceiver.Click += TextBox_Enter;
            txtAntennaHeightReceiver.Leave += TextBox_Leave;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(726, 390);
            button1.Name = "button1";
            button1.Size = new Size(188, 41);
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
            lblResult.Location = new Point(52, 462);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(410, 82);
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
            lblSignalStrength.Location = new Point(504, 462);
            lblSignalStrength.Name = "lblSignalStrength";
            lblSignalStrength.Size = new Size(360, 82);
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
            txtBuildingHeight.Location = new Point(52, 347);
            txtBuildingHeight.Name = "txtBuildingHeight";
            txtBuildingHeight.Size = new Size(410, 27);
            txtBuildingHeight.TabIndex = 16;
            txtBuildingHeight.Click += TextBox_Enter;
            txtBuildingHeight.Leave += TextBox_Leave;
            // 
            // txtClutterFactor
            // 
            txtClutterFactor.BackColor = SystemColors.Control;
            txtClutterFactor.Font = new Font("Arial", 10.2F);
            txtClutterFactor.ForeColor = Color.Gray;
            txtClutterFactor.Location = new Point(504, 347);
            txtClutterFactor.Name = "txtClutterFactor";
            txtClutterFactor.Size = new Size(410, 27);
            txtClutterFactor.TabIndex = 17;
            txtClutterFactor.Click += TextBox_Enter;
            txtClutterFactor.Leave += TextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 161);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(251, 177);
            label3.Name = "label3";
            label3.Size = new Size(173, 29);
            label3.TabIndex = 18;
            label3.Text = "Select City Density:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.FlatAppearance.BorderColor = Color.DarkCyan;
            btnReset.FlatAppearance.BorderSize = 4;
            btnReset.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(51, 414);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(168, 33);
            btnReset.TabIndex = 19;
            btnReset.Text = "Clear All";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(938, 556);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEnvironment);
            Controls.Add(txtAntennaHeightReceiver);
            Controls.Add(txtAntennaHeightTransmitter);
            Controls.Add(txtDistance);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = SystemColors.ActiveBorder;
            Click += TextBox_Leave;
            DoubleClick += TextBox_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDistance;
        private TextBox txtFrequency;
        private TextBox txtTransmitPower;
        private ComboBox cmbEnvironment;
        private Label label1;
        private Label label2;
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
    }
}
