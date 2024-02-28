namespace FerrariAwardGenerator.Ui
{
    partial class SuccessMessage
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
            lblSuccess = new Label();
            lblSavedAt = new Label();
            btnExitProgram = new Button();
            SuspendLayout();
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Font = new Font("Segoe UI", 20F);
            lblSuccess.Location = new Point(59, 28);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(696, 62);
            lblSuccess.TabIndex = 0;
            lblSuccess.Text = "Award PDF Successfully created!";
            // 
            // lblSavedAt
            // 
            lblSavedAt.AutoSize = true;
            lblSavedAt.Font = new Font("Segoe UI", 9F);
            lblSavedAt.Location = new Point(12, 120);
            lblSavedAt.MaximumSize = new Size(1000, 100);
            lblSavedAt.Name = "lblSavedAt";
            lblSavedAt.Size = new Size(145, 30);
            lblSavedAt.TabIndex = 1;
            lblSavedAt.Text = "PDF saved to: ";
            // 
            // btnExitProgram
            // 
            btnExitProgram.Location = new Point(272, 271);
            btnExitProgram.Name = "btnExitProgram";
            btnExitProgram.Size = new Size(247, 101);
            btnExitProgram.TabIndex = 2;
            btnExitProgram.Text = "Start New Class Award Sheet";
            btnExitProgram.UseVisualStyleBackColor = true;
            btnExitProgram.Click += btnExitProgram_Click;
            // 
            // SuccessMessage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitProgram);
            Controls.Add(lblSavedAt);
            Controls.Add(lblSuccess);
            Name = "SuccessMessage";
            Text = "SuccessMessage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSuccess;
        private Label lblSavedAt;
        private Button btnExitProgram;
    }
}