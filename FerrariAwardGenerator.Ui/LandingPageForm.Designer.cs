namespace FerrariAwardGenerator.Ui
{
    partial class LandingPageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcomeButton = new Label();
            lblAuthorInfo = new Label();
            btnFileSelector = new Button();
            tbSelectedFilePath = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            lblCcj = new Label();
            lblJudge1 = new Label();
            lblJudge2 = new Label();
            tbCcj = new TextBox();
            tbJudge1 = new TextBox();
            tbJudge2 = new TextBox();
            tbJudgingClass = new TextBox();
            lblJudgingClass = new Label();
            btnNextStep = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblWelcomeButton
            // 
            lblWelcomeButton.AutoSize = true;
            lblWelcomeButton.Font = new Font("Segoe UI", 28F);
            lblWelcomeButton.Location = new Point(515, 52);
            lblWelcomeButton.Name = "lblWelcomeButton";
            lblWelcomeButton.Size = new Size(1424, 88);
            lblWelcomeButton.TabIndex = 0;
            lblWelcomeButton.Text = "Welcome to the Ferrari Award Generator Utility!";
            // 
            // lblAuthorInfo
            // 
            lblAuthorInfo.AutoSize = true;
            lblAuthorInfo.Location = new Point(1, 9);
            lblAuthorInfo.Name = "lblAuthorInfo";
            lblAuthorInfo.Size = new Size(420, 30);
            lblAuthorInfo.TabIndex = 1;
            lblAuthorInfo.Text = "Created by mattmandery@gmail.com | 2024";
            // 
            // btnFileSelector
            // 
            btnFileSelector.Location = new Point(1035, 517);
            btnFileSelector.Name = "btnFileSelector";
            btnFileSelector.Size = new Size(353, 79);
            btnFileSelector.TabIndex = 2;
            btnFileSelector.Text = "Please select excel file to be imported";
            btnFileSelector.UseVisualStyleBackColor = true;
            btnFileSelector.Click += btnFileSelector_Click;
            // 
            // tbSelectedFilePath
            // 
            tbSelectedFilePath.Location = new Point(1412, 561);
            tbSelectedFilePath.Name = "tbSelectedFilePath";
            tbSelectedFilePath.ReadOnly = true;
            tbSelectedFilePath.Size = new Size(823, 35);
            tbSelectedFilePath.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCcj
            // 
            lblCcj.AutoSize = true;
            lblCcj.Font = new Font("Segoe UI", 14F);
            lblCcj.Location = new Point(170, 325);
            lblCcj.Name = "lblCcj";
            lblCcj.Size = new Size(71, 45);
            lblCcj.TabIndex = 4;
            lblCcj.Text = "CCJ";
            // 
            // lblJudge1
            // 
            lblJudge1.AutoSize = true;
            lblJudge1.Font = new Font("Segoe UI", 14F);
            lblJudge1.Location = new Point(145, 473);
            lblJudge1.Name = "lblJudge1";
            lblJudge1.Size = new Size(133, 45);
            lblJudge1.TabIndex = 5;
            lblJudge1.Text = "Judge 1";
            // 
            // lblJudge2
            // 
            lblJudge2.AutoSize = true;
            lblJudge2.Font = new Font("Segoe UI", 14F);
            lblJudge2.Location = new Point(145, 615);
            lblJudge2.Name = "lblJudge2";
            lblJudge2.Size = new Size(133, 45);
            lblJudge2.TabIndex = 6;
            lblJudge2.Text = "Judge 2";
            // 
            // tbCcj
            // 
            tbCcj.Location = new Point(294, 335);
            tbCcj.Name = "tbCcj";
            tbCcj.Size = new Size(362, 35);
            tbCcj.TabIndex = 7;
            tbCcj.TextChanged += tbCcj_TextChanged;
            // 
            // tbJudge1
            // 
            tbJudge1.Location = new Point(294, 483);
            tbJudge1.Name = "tbJudge1";
            tbJudge1.Size = new Size(362, 35);
            tbJudge1.TabIndex = 8;
            tbJudge1.TextChanged += tbJudge1_TextChanged;
            // 
            // tbJudge2
            // 
            tbJudge2.Location = new Point(294, 625);
            tbJudge2.Name = "tbJudge2";
            tbJudge2.Size = new Size(362, 35);
            tbJudge2.TabIndex = 9;
            tbJudge2.TextChanged += tbJudge2_TextChanged;
            // 
            // tbJudgingClass
            // 
            tbJudgingClass.Location = new Point(1352, 321);
            tbJudgingClass.Name = "tbJudgingClass";
            tbJudgingClass.Size = new Size(883, 35);
            tbJudgingClass.TabIndex = 11;
            tbJudgingClass.TextChanged += tbJudgingClass_TextChanged;
            // 
            // lblJudgingClass
            // 
            lblJudgingClass.AutoSize = true;
            lblJudgingClass.Font = new Font("Segoe UI", 14F);
            lblJudgingClass.Location = new Point(1096, 311);
            lblJudgingClass.Name = "lblJudgingClass";
            lblJudgingClass.Size = new Size(217, 45);
            lblJudgingClass.TabIndex = 10;
            lblJudgingClass.Text = "Judging Class";
            // 
            // btnNextStep
            // 
            btnNextStep.BackColor = SystemColors.Highlight;
            btnNextStep.Font = new Font("Segoe UI", 16F);
            btnNextStep.Location = new Point(804, 672);
            btnNextStep.Name = "btnNextStep";
            btnNextStep.Size = new Size(1353, 112);
            btnNextStep.TabIndex = 12;
            btnNextStep.Text = "Next Step!";
            btnNextStep.UseVisualStyleBackColor = false;
            btnNextStep.Click += btnNextStep_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblError.ForeColor = Color.Crimson;
            lblError.Location = new Point(694, 192);
            lblError.Name = "lblError";
            lblError.Size = new Size(1001, 38);
            lblError.TabIndex = 13;
            lblError.Text = "Please enter all forms and select a valid file before moving on to next step!";
            lblError.Visible = false;
            // 
            // LandingPageForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2332, 817);
            Controls.Add(lblError);
            Controls.Add(btnNextStep);
            Controls.Add(tbJudgingClass);
            Controls.Add(lblJudgingClass);
            Controls.Add(tbJudge2);
            Controls.Add(tbJudge1);
            Controls.Add(tbCcj);
            Controls.Add(lblJudge2);
            Controls.Add(lblJudge1);
            Controls.Add(lblCcj);
            Controls.Add(tbSelectedFilePath);
            Controls.Add(btnFileSelector);
            Controls.Add(lblAuthorInfo);
            Controls.Add(lblWelcomeButton);
            Name = "LandingPageForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeButton;
        private Label lblAuthorInfo;
        private Button btnFileSelector;
        private TextBox tbSelectedFilePath;
        private OpenFileDialog openFileDialog1;
        private Label lblCcj;
        private Label lblJudge1;
        private Label lblJudge2;
        private TextBox tbCcj;
        private TextBox tbJudge1;
        private TextBox tbJudge2;
        private TextBox tbJudgingClass;
        private Label lblJudgingClass;
        private Button btnNextStep;
        private Label lblError;
    }
}
