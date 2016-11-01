using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Claim
    {

        // will be automatically generated 
        public string ClaimNumber { get; set; }
        public string ClaimStatuss { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string ClaimCategory { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime AccidentDate { get; set; }
        public string Description { get; set; }
       // public string LineOfBusiness { get; set; } //LOBs //public LineOfBusiness LineOfBusiness { get; set; }

        public Policy Policy { get; set; } //Policy relations
        public Client Client { get; set; } //Client relations

        public enum LineOfBusiness //LOBs
        {
            Transport,
            Person,
            Liability,
            Property
        }
    }
}