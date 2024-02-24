using FerrariAwardGenerator.Service.ExcelImport.Models;
using FerrariAwardGenerator.Service.ExcelImport.Services;
using FerrariAwardGenerator.Service.PDFGenerator.Classes;

namespace FerrariAwardGenerator.Ui
{
    public partial class LandingPageForm : Form
    {
        private string? _ccj;
        private string? _judge1;
        private string? _judge2;
        private string? _judgingClassInfo;
        private string? _selectedFilePath;
        private ExcelImportService _excelImportService;

        public LandingPageForm()
        {
            InitializeComponent();
            _excelImportService = new ExcelImportService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFileSelector_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            tbSelectedFilePath.Text = dlg.FileName;
            _selectedFilePath = dlg.FileName;
        }

        private void tbCcj_TextChanged(object sender, EventArgs e)
        {
            _ccj = tbCcj.Text;
        }

        private void tbJudge1_TextChanged(object sender, EventArgs e)
        {
            _judge1 = tbJudge1.Text;
        }

        private void tbJudge2_TextChanged(object sender, EventArgs e)
        {
            _judge2 = tbJudge2.Text;
        }

        private void tbJudgingClass_TextChanged(object sender, EventArgs e)
        {
            _judgingClassInfo = tbJudgingClass.Text;
        }

        private bool CheckIfFormComplete()
        {
            if (_ccj != null && _ccj != "" &&
                _judge1 != null && _judge1 != "" &&
                _judge2 != null && _judge2 != "" &&
                _judgingClassInfo != null && _judgingClassInfo != "" &&
                _selectedFilePath != null && _selectedFilePath != "")
            {
                return true;
            }
            else
                return false;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (CheckIfFormComplete())
            {
                List<ExcelImportModel> excelFileRecords;
                try
                {
                    excelFileRecords = _excelImportService.ReadExcelFile(_selectedFilePath);
                }
                catch (Exception ex)
                {
                    lblError.Text = "An error has occured while processing the file.  Please Refer to ExcelImportModel.cs to find expected columns";
                    lblError.Visible = true;
                    return;
                }
                JudgingInfo judgingInfo = new JudgingInfo
                {
                    CCJ = _ccj,
                    Judge1Name = _judge1,
                    Judge2Name = _judge2,
                    ClassInfo = _judgingClassInfo
                };
                VinAndScoreEntry entryScreen = new VinAndScoreEntry(excelFileRecords, judgingInfo);
                entryScreen.Show();

            }
            else
            {
                lblError.Visible = true;
            }
        }


    }
}
