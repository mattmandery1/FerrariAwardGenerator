using FerrariAwardGenerator.Service.ExcelImport.Models;
using Ganss.Excel;
using System.Data;

namespace FerrariAwardGenerator.Service.ExcelImport.Services
{
    public class ExcelImportService
    {

        public ExcelImportService()
        {

        }

        public List<ExcelImportModel> ReadExcelFile(string filePath)
        {
            var excelMapper = new ExcelMapper(filePath);
            var books = excelMapper.Fetch<ExcelImportModel>().ToList();
            return books;
        }
    }
}
