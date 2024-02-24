using FerrariAwardGenerator.Service.ExcelImport.Models;
using FerrariAwardGenerator.Service.PDFGenerator.Classes;
using FerrariAwardGenerator.Service.PDFGenerator.Services;
using FerrariAwardGenerator.Ui.Models;

namespace FerrariAwardGenerator.Ui
{
    public partial class VinAndScoreEntry : Form
    {
        private List<ExcelImportModel> _excelResults;
        private List<FinalScoreItems> _comboItems;
        private JudgingInfo _judgingInfo;
        private FerrariAwardPDFGeneratorService _pdfGeneratorService;

        public VinAndScoreEntry(List<ExcelImportModel> excelResults, JudgingInfo judgingInfo)
        {
            InitializeComponent();
            _excelResults = excelResults;
            _comboItems = new List<FinalScoreItems>();
            _judgingInfo = judgingInfo;
            _pdfGeneratorService = new FerrariAwardPDFGeneratorService();
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
            if (cbVinEntry1.SelectedIndex != 0 && cbVinEntry1.GetItemText(cbVinEntry1.SelectedItem) != ""
                && tbScore.Text != "")
            {
                TextBox textBox1 = new TextBox();
                textBox1.Text = cbVinEntry1.GetItemText(cbVinEntry1.SelectedItem);
                textBox1.Enabled = false;
                textBox1.Size = new Size(350, 20);

                TextBox textBox2 = new TextBox();
                textBox2.Text = tbScore.Text;
                textBox2.Enabled = false;
                textBox2.Size = new Size(350, 20);

                flpScoreResults.Controls.Add(textBox1);
                flpScoreResults.Controls.Add(textBox2);

                _comboItems.Add(new FinalScoreItems { SerialNumber = textBox1.Text, Score = int.Parse(tbScore.Text) });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            if(_comboItems.Count == 0)
            {
                return;
            }
            var results = GenerateScoreResultsObjects();

            //Save PDF to desktop
            _pdfGeneratorService.GenerateFerrariAwardPDF(results, _judgingInfo);

        }

        private List<ScoreResults> GenerateScoreResultsObjects()
        {
            List<ScoreResults> results = new List<ScoreResults>();
            foreach (var score in _comboItems) 
            {
                var fullRecord = _excelResults.Where(result => result.SerialNumber1 == score.SerialNumber).First();
                results.Add(new ScoreResults
                {
                    Score = score.Score,
                    SerialNumber = score.SerialNumber,
                    CarYear = fullRecord.Year1,
                    Model = fullRecord.Model1,
                    OwnerName = fullRecord.FirstName + " " + fullRecord.LastName
                });
            }

            foreach(var score in results)
            {
                SetGradeBasedOnScore(score);
            }
            return results;
        }

        private void SetGradeBasedOnScore(ScoreResults result)
        {
            if(result.Score > 90)
            {
                result.CalculatedGrade = "Platinum";
            }
            else if (result.Score <= 89 && result.Score > 80)
            {
                result.CalculatedGrade = "Gold";
            }
            else if (result.Score <= 79 && result.Score > 70)
            {
                result.CalculatedGrade = "Silver";
            }
        }
    }
}
