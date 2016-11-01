using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Policy
    {
        // will be automatically generated 
        public string PolicyId { get; set; }
        public int Period { get; set; }
        public int Version { get; set; }
        public int ProductId { get; set; }
        public Statuss Statuss { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Premium { get; set; }

        public Client Client { get; set; } //Client relations

        //Products relation

        

    }
    public enum Statuss //statuses
    {
        Draft,
        Active,
        Canceled
    }
}