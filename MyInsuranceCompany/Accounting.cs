using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Accounting
    {
        public string PaymenteNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }
        public double Paid { get; set; }
        public string InvoiceNumber { get; set; }
        public string CustomerNumber { get; set; }
       // public string Statuss { get; set; }
        public enum Statuss
        {
            Pending,
            Paid
        }
        public Invoicing Invoicing { get; set; } //Invoicing relations
        public InvoicePlan InvoicePlan { get; set; } //InvoicePlan relations
    }
}