namespace FerrariAwardGenerator.Ui
{
    partial class VinAndScoreEntry
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
            lblUserDirections = new Label();
            cbVinEntry1 = new ComboBox();
            tbScore = new TextBox();
            flpScoreResults = new FlowLayoutPanel();
            lblSNHelpText = new Label();
            lblScoreHelperText = new Label();
            btnAddSNToFinalList = new Button();
            btnGeneratePDF = new Button();
            lblHelperText1 = new Label();
            lblHelperText2 = new Label();
            lblSelectedSNInfoHeader = new Label();
            lblFirstName = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            lblLastName = new Label();
            tbAddress = new TextBox();
            lblAddress = new Label();
            tbCity = new TextBox();
            lblCity = new Label();
            tbState = new TextBox();
            lblState = new Label();
            tbCarYear = new TextBox();
            lblCarYear = new Label();
            tbCarModel = new TextBox();
            lblCarModel = new Label();
            tbCarStyle = new TextBox();
            lblCarBodyStyle = new Label();
            tbSerialNumber = new TextBox();
            lblSerialNumber = new Label();
            tbCarColor = new TextBox();
            lblCarColor = new Label();
            SuspendLayout();
            // 
            // lblUserDirections
            // 
            lblUserDirections.AutoSize = true;
            lblUserDirections.Font = new Font("Segoe UI", 12F);
            lblUserDirections.Location = new Point(58, 20);
            lblUserDirections.MaximumSize = new Size(700, 0);
            lblUserDirections.Name = "lblUserDirections";
            lblUserDirections.Size = new Size(660, 114);
            lblUserDirections.TabIndex = 0;
            lblUserDirections.Text = "Select a VIN of an award winner and enter the score they received.  You do not need to worry about entering the scores in order.";
            lblUserDirections.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbVinEntry1
            // 
            cbVinEntry1.AutoCompleteMode = AutoCompleteMode.Append;
            cbVinEntry1.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbVinEntry1.DisplayMember = "Text";
            cbVinEntry1.FormattingEnabled = true;
            cbVinEntry1.Location = new Point(31, 223);
            cbVinEntry1.Name = "cbVinEntry1";
            cbVinEntry1.Size = new Size(399, 38);
            cbVinEntry1.TabIndex = 1;
            cbVinEntry1.ValueMember = "ID";
            cbVinEntry1.SelectedIndexChanged += cbVinEntry1_SelectedIndexChanged;
            // 
            // tbScore
            // 
            tbScore.Location = new Point(482, 223);
            tbScore.Name = "tbScore";
            tbScore.Size = new Size(254, 35);
            tbScore.TabIndex = 2;
            // 
            // flpScoreResults
            // 
            flpScoreResults.Location = new Point(31, 308);
            flpScoreResults.Name = "flpScoreResults";
            flpScoreResults.Size = new Size(724, 504);
            flpScoreResults.TabIndex = 3;
            flpScoreResults.Paint += flpScoreResults_Paint;
            // 
            // lblSNHelpText
            // 
            lblSNHelpText.AutoSize = true;
            lblSNHelpText.Location = new Point(31, 190);
            lblSNHelpText.Name = "lblSNHelpText";
            lblSNHelpText.Size = new Size(196, 30);
            lblSNHelpText.TabIndex = 4;
            lblSNHelpText.Text = "Type or look for SN:";
            // 
            // lblScoreHelperText
            // 
            lblScoreHelperText.AutoSize = true;
            lblScoreHelperText.Location = new Point(482, 190);
            lblScoreHelperText.Name = "lblScoreHelperText";
            lblScoreHelperText.Size = new Size(304, 30);
            lblScoreHelperText.TabIndex = 5;
            lblScoreHelperText.Text = "Enter the score the SN received";
            // 
            // btnAddSNToFinalList
            // 
            btnAddSNToFinalList.Location = new Point(31, 830);
            btnAddSNToFinalList.Name = "btnAddSNToFinalList";
            btnAddSNToFinalList.Size = new Size(331, 87);
            btnAddSNToFinalList.TabIndex = 6;
            btnAddSNToFinalList.Text = "Add SN and Score to the award list.";
            btnAddSNToFinalList.UseVisualStyleBackColor = true;
            btnAddSNToFinalList.Click += btnAddSNToFinalList_Click;
            // 
            // btnGeneratePDF
            // 
            btnGeneratePDF.Location = new Point(441, 830);
            btnGeneratePDF.Name = "btnGeneratePDF";
            btnGeneratePDF.Size = new Size(311, 87);
            btnGeneratePDF.TabIndex = 7;
            btnGeneratePDF.Text = "Generate Award PDF";
            btnGeneratePDF.UseVisualStyleBackColor = true;
            btnGeneratePDF.Click += btnGeneratePDF_Click;
            // 
            // lblHelperText1
            // 
            lblHelperText1.AutoSize = true;
            lblHelperText1.Location = new Point(31, 275);
            lblHelperText1.Name = "lblHelperText1";
            lblHelperText1.Size = new Size(308, 30);
            lblHelperText1.TabIndex = 8;
            lblHelperText1.Text = "Award Winning Serial Numbers:";
            lblHelperText1.Click += label1_Click;
            // 
            // lblHelperText2
            // 
            lblHelperText2.AutoSize = true;
            lblHelperText2.Location = new Point(398, 275);
            lblHelperText2.Name = "lblHelperText2";
            lblHelperText2.Size = new Size(213, 30);
            lblHelperText2.TabIndex = 9;
            lblHelperText2.Text = "Award Winning Score";
            // 
            // lblSelectedSNInfoHeader
            // 
            lblSelectedSNInfoHeader.AutoSize = true;
            lblSelectedSNInfoHeader.Location = new Point(950, 20);
            lblSelectedSNInfoHeader.Name = "lblSelectedSNInfoHeader";
            lblSelectedSNInfoHeader.Size = new Size(242, 30);
            lblSelectedSNInfoHeader.TabIndex = 10;
            lblSelectedSNInfoHeader.Text = "Selected Vin Information";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(830, 104);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(124, 30);
            lblFirstName.TabIndex = 11;
            lblFirstName.Text = "First Name: ";
            // 
            // tbFirstName
            // 
            tbFirstName.Enabled = false;
            tbFirstName.Location = new Point(1006, 99);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(261, 35);
            tbFirstName.TabIndex = 12;
            // 
            // tbLastName
            // 
            tbLastName.Enabled = false;
            tbLastName.Location = new Point(1006, 149);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(261, 35);
            tbLastName.TabIndex = 14;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(830, 154);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(123, 30);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name: ";
            // 
            // tbAddress
            // 
            tbAddress.Enabled = false;
            tbAddress.Location = new Point(1006, 200);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(261, 35);
            tbAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(830, 205);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(98, 30);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address: ";
            // 
            // tbCity
            // 
            tbCity.Enabled = false;
            tbCity.Location = new Point(1006, 256);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(261, 35);
            tbCity.TabIndex = 18;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(830, 261);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(53, 30);
            lblCity.TabIndex = 17;
            lblCity.Text = "City:";
            // 
            // tbState
            // 
            tbState.Enabled = false;
            tbState.Location = new Point(1006, 303);
            tbState.Name = "tbState";
            tbState.Size = new Size(261, 35);
            tbState.TabIndex = 20;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(830, 308);
            lblState.Name = "lblState";
            lblState.Size = new Size(70, 30);
            lblState.TabIndex = 19;
            lblState.Text = "State: ";
            // 
            // tbCarYear
            // 
            tbCarYear.Enabled = false;
            tbCarYear.Location = new Point(1006, 364);
            tbCarYear.Name = "tbCarYear";
            tbCarYear.Size = new Size(261, 35);
            tbCarYear.TabIndex = 22;
            // 
            // lblCarYear
            // 
            lblCarYear.AutoSize = true;
            lblCarYear.Location = new Point(830, 369);
            lblCarYear.Name = "lblCarYear";
            lblCarYear.Size = new Size(100, 30);
            lblCarYear.TabIndex = 21;
            lblCarYear.Text = "Car Year: ";
            // 
            // tbCarModel
            // 
            tbCarModel.Enabled = false;
            tbCarModel.Location = new Point(1006, 423);
            tbCarModel.Name = "tbCarModel";
            tbCarModel.Size = new Size(261, 35);
            tbCarModel.TabIndex = 24;
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Location = new Point(830, 428);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(120, 30);
            lblCarModel.TabIndex = 23;
            lblCarModel.Text = "Car Model: ";
            // 
            // tbCarStyle
            // 
            tbCarStyle.Enabled = false;
            tbCarStyle.Location = new Point(1006, 482);
            tbCarStyle.Name = "tbCarStyle";
            tbCarStyle.Size = new Size(261, 35);
            tbCarStyle.TabIndex = 26;
            // 
            // lblCarBodyStyle
            // 
            lblCarBodyStyle.AutoSize = true;
            lblCarBodyStyle.Font = new Font("Segoe UI", 9F);
            lblCarBodyStyle.Location = new Point(830, 485);
            lblCarBodyStyle.Name = "lblCarBodyStyle";
            lblCarBodyStyle.Size = new Size(119, 30);
            lblCarBodyStyle.TabIndex = 25;
            lblCarBodyStyle.Text = "Body Style: ";
            // 
            // tbSerialNumber
            // 
            tbSerialNumber.Enabled = false;
            tbSerialNumber.Location = new Point(1006, 537);
            tbSerialNumber.Name = "tbSerialNumber";
            tbSerialNumber.Size = new Size(261, 35);
            tbSerialNumber.TabIndex = 28;
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.AutoSize = true;
            lblSerialNumber.Location = new Point(830, 542);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(156, 30);
            lblSerialNumber.TabIndex = 27;
            lblSerialNumber.Text = "Serial Number: ";
            // 
            // tbCarColor
            // 
            tbCarColor.Enabled = false;
            tbCarColor.Location = new Point(1006, 602);
            tbCarColor.Name = "tbCarColor";
            tbCarColor.Size = new Size(261, 35);
            tbCarColor.TabIndex = 30;
            // 
            // lblCarColor
            // 
            lblCarColor.AutoSize = true;
            lblCarColor.Location = new Point(830, 607);
            lblCarColor.Name = "lblCarColor";
            lblCarColor.Size = new Size(110, 30);
            lblCarColor.TabIndex = 29;
            lblCarColor.Text = "Car Color: ";
            // 
            // VinAndScoreEntry
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 947);
            Controls.Add(tbCarColor);
            Controls.Add(lblCarColor);
            Controls.Add(tbSerialNumber);
            Controls.Add(lblSerialNumber);
            Controls.Add(tbCarStyle);
            Controls.Add(lblCarBodyStyle);
            Controls.Add(tbCarModel);
            Controls.Add(lblCarModel);
            Controls.Add(tbCarYear);
            Controls.Add(lblCarYear);
            Controls.Add(tbState);
            Controls.Add(lblState);
            Controls.Add(tbCity);
            Controls.Add(lblCity);
            Controls.Add(tbAddress);
            Controls.Add(lblAddress);
            Controls.Add(tbLastName);
            Controls.Add(lblLastName);
            Controls.Add(tbFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblSelectedSNInfoHeader);
            Controls.Add(lblHelperText2);
            Controls.Add(lblHelperText1);
            Controls.Add(btnGeneratePDF);
            Controls.Add(btnAddSNToFinalList);
            Controls.Add(lblScoreHelperText);
            Controls.Add(lblSNHelpText);
            Controls.Add(flpScoreResults);
            Controls.Add(tbScore);
            Controls.Add(cbVinEntry1);
            Controls.Add(lblUserDirections);
            Name = "VinAndScoreEntry";
            Text = "VinAndScoreEntry";
            Load += VinAndScoreEntry_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserDirections;
        private ComboBox cbVinEntry1;
        private TextBox tbScore;
        private FlowLayoutPanel flpScoreResults;
        private Label lblSNHelpText;
        private Label lblScoreHelperText;
        private Button btnAddSNToFinalList;
        private Button btnGeneratePDF;
        private Label lblHelperText1;
        private Label lblHelperText2;
        private Label lblSelectedSNInfoHeader;
        private Label lblFirstName;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label lblLastName;
        private TextBox tbAddress;
        private Label lblAddress;
        private TextBox tbCity;
        private Label lblCity;
        private TextBox tbState;
        private Label lblState;
        private TextBox tbCarYear;
        private Label lblCarYear;
        private TextBox tbCarModel;
        private Label lblCarModel;
        private TextBox tbCarStyle;
        private Label lblCarBodyStyle;
        private TextBox tbSerialNumber;
        private Label lblSerialNumber;
        private TextBox tbCarColor;
        private Label lblCarColor;
    }
}