using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class InvoicePlan
    {
        public string InvoiceNumber { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime FirstReminderDate { get; set; }
        public DateTime FirstReminderDueDate { get; set; }
        public DateTime FirstWarningDate { get; set; }
        public DateTime CancellationDate { get; set; }
    }
}