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
        [JsonProperty(PropertyName = "First Name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "Last Name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "FCA Member Number")]
        public int FcaMemberNumber { get; set; }

        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "ZIP")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "Register Number")]
        public int RegisterNumber { get; set; }

        [JsonProperty(PropertyName = "Ferrari 1")]
        public string Ferrari1 { get; set; }

        [JsonProperty(PropertyName = "Year 1")]
        public int Year1 { get; set; }

        [JsonProperty(PropertyName = "Model 1")]
        public string Model1 { get; set; }

        [JsonProperty(PropertyName = "Serial Number 1")]
        public string SerialNumber1 { get; set; }

        [JsonProperty(PropertyName = "Body Style")]
        public string BodyStyle { get; set; }

        [JsonProperty(PropertyName = "Coachbuild")]
        public string Coachbuild { get; set; }

        [JsonProperty(PropertyName = "Car Color 1")]
        public string CarColor1 { get; set; }
    }
}
