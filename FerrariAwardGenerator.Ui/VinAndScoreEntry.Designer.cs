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
            flpScoreResults.Location = new Point(31, 267);
            flpScoreResults.Name = "flpScoreResults";
            flpScoreResults.Size = new Size(724, 545);
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
            // 
            // VinAndScoreEntry
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 947);
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
    }
}