using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrariAwardGenerator.Service.ExcelImport.Models
{
    public class ExcelImportModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FcaMemberNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public int RegisterNumberofFerraris { get; set; }
        public string Ferrari1 { get; set; }
        public int Year1 { get; set; }
        public string Model1 { get; set; }
        public string SerialNumber1 { get; set; }
        public string BodyStyle { get; set; }
        public string Coachbuild { get; set; }
        public string CarColor1 { get; set; }
    }
}
