using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Documents
    {
        //public string DocumentType { get; set; }
        public DateTime GenerationDate { get; set; }
        public string Receiver { get; set; }
        public int Period { get; set; }
        public int Version { get; set; }
        public enum DocumentType
        {
            Invoice,
            PolicyLetter,
            Terms
        }

        public Client Client { get; set; } //Client relation
        public Policy Policy { get; set; } //Policy relations
    }
}
