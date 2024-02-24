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
            var selectedSN = cbVinEntry1.GetItemText(cbVinEntry1.SelectedItem);
            var excelResultsforSelectedSn = _excelResults.Where(x => x.SerialNumber1 == selectedSN).FirstOrDefault();
            if(excelResultsforSelectedSn != null)
            {
                tbFirstName.Text = excelResultsforSelectedSn.FirstName;
                tbLastName.Text = excelResultsforSelectedSn.LastName;
                tbAddress.Text = excelResultsforSelectedSn.Address;
                tbCity.Text = excelResultsforSelectedSn.City;
                tbState.Text = excelResultsforSelectedSn.State;
                tbCarColor.Text = excelResultsforSelectedSn.CarColor1;
                tbCarModel.Text = excelResultsforSelectedSn.Model1;
                tbSerialNumber.Text = excelResultsforSelectedSn.SerialNumber1;
                tbCarYear.Text = excelResultsforSelectedSn.Year1.ToString();
                tbCarStyle.Text = excelResultsforSelectedSn.BodyStyle1;
            }
            else
            {
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbAddress.Text = "";
                tbCity.Text = "";
                tbState.Text = "";
                tbCarColor.Text = "";
                tbCarModel.Text = "";
                tbSerialNumber.Text = "";
                tbCarYear.Text = "";
                tbCarStyle.Text = "";
            }
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

                cbVinEntry1.SelectedIndex = 0;
                cbVinEntry1.SelectedValue = "";
                tbScore.Text = "";
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
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + _judgingInfo.ClassInfo + ".pdf";
            _pdfGeneratorService.GenerateFerrariAwardPDF(results, _judgingInfo, savePath);
            SuccessMessage success = new SuccessMessage(savePath);
            success.Show();

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
            if(result.Score >= 90)
            {
                result.CalculatedGrade = "Platinum";
            }
            else if (result.Score < 90 && result.Score >= 80)
            {
                result.CalculatedGrade = "Gold";
            }
            else if (result.Score < 80 && result.Score >= 70)
            {
                result.CalculatedGrade = "Silver";
            }
            else
            {
                result.CalculatedGrade = "N/A";
            }
        }
    }
}
