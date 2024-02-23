using FerrariAwardGenerator.Service.ExcelImport.Models;
using FerrariAwardGenerator.Ui.Models;

namespace FerrariAwardGenerator.Ui
{
    public partial class VinAndScoreEntry : Form
    {
        List<ExcelImportModel> _excelResults;
        public VinAndScoreEntry(List<ExcelImportModel> excelResults)
        {
            InitializeComponent();
            _excelResults = excelResults;
        }

        private void cbVinEntry1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VinAndScoreEntry_Load(object sender, EventArgs e)
        {
            ComboItem[] comboItems = new ComboItem[_excelResults.Count + 1];
            comboItems[0] = new ComboItem { ID = 0, Text = "" };
            int i = 1;
            foreach (var excel in _excelResults)
            {
                comboItems[i] = new ComboItem { ID = i, Text = excel.SerialNumber1 };
                i++;
            }
            cbVinEntry1.DataSource = comboItems;
        }

        private void flpScoreResults_Paint(object sender, PaintEventArgs e)
        {
            flpScoreResults.FlowDirection = FlowDirection.LeftToRight;

        }

        private void btnAddSNToFinalList_Click(object sender, EventArgs e)
        {
            if(cbVinEntry1.SelectedIndex != 0 && cbVinEntry1.GetItemText(cbVinEntry1.SelectedItem) != ""
                && tbScore.Text != "")
            {
                TextBox textBox1 = new TextBox();
                textBox1.Text = cbVinEntry1.GetItemText(cbVinEntry1.SelectedItem);
                textBox1.Enabled = false;
                textBox1.Size = new Size(100, 20);

                TextBox textBox2 = new TextBox();
                textBox2.Text = tbScore.Text;
                textBox2.Enabled = false;
                textBox2.Size = new Size(100, 20);

                flpScoreResults.Controls.Add(textBox1);
                flpScoreResults.Controls.Add(textBox2);
            }
        }
    }
}
