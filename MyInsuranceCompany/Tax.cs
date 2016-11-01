using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Tax
    {
        // will be automatically generated 
        public string TaxNumber { get; set; }
        public string TaxName { get; set; }
        // will be automatically generated 
        public double Rate { get; set; }
        public string Country { get; set; }
        public DateTime ActiveFromDate { get; set; }
        public DateTime TerminatedFromDate { get; set; }
       //public string Statuss { get; set; }

        public enum Statuss //statuses
        {
            Active,
            Canceled
        }
        public Product Product { get; set; } //Product relations
    }
}