using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrariAwardGenerator.Ui
{
    public partial class SuccessMessage : Form
    {
        public SuccessMessage(string savePath)
        {
            InitializeComponent();
            SetSaveLabelInfo(savePath);
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(1);
            this.Close();
        }

        private void SetSaveLabelInfo(string savePath)
        {
            lblSavedAt.MaximumSize = new Size(1000, 0);
            lblSavedAt.AutoSize = true;
            lblSavedAt.Text = "PDF saved to: " + savePath;
        }
    }
}
