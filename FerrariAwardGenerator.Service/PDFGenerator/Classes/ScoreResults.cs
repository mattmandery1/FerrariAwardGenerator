using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrariAwardGenerator.Service.PDFGenerator.Classes
{
    public class ScoreResults
    {
        public double Score { get; set; }
        public string CalculatedGrade { get; set; }
        public string SerialNumber { get; set; }
        public string OwnerName { get; set; }
        public int CarYear { get; set; }
        public string Model { get; set; }

    }
}
