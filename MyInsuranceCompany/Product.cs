using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Product
    {
        // will be automatically generated 
        public int ProductId { get; set; }
        public string ProductName { get; set; } //db where will be saved all possible products???
        public decimal Premium { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Policy Policy { get; set; } //Policy relations
       // public string LineOfBusiness { get; set; } //LOBs
        public enum LineOfBusiness //LOBs
        {
            Transport,
            Person, 
            Liability,
            Property
        }

    }
}