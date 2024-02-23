using FerrariAwardGenerator.Service.ExcelImport.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FerrariAwardGenerator.Service.Tests.ExcelImport
{
    [TestClass]
    public class ExcelImportServiceTests
    {
        ExcelImportService _excelImportService;

        public ExcelImportServiceTests()
        {
            _excelImportService = new ExcelImportService();
        }

        [TestMethod]
        public void ExcelImportServiceTest_ReadExcelFile()
        {
            string filePath = "C:/Users/mattm/Downloads/FCA Class results.xls";

            var sut = _excelImportService.ReadExcelFile(filePath);

            Assert.IsNotNull(sut);
        }
    }
}

