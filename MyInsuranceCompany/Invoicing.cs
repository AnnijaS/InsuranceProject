using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Invoicing
    {
        // will be automatically generated 
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Currency { get; set; }
        public double Invoiced { get; set; }
        public double Paid{ get; set; }
        public double Refund{ get; set; }
        public double Balance{ get; set; }

        public Policy Policy { get; set; } //Policy relations
        public Client Client { get; set; } //Client relations
    }
}