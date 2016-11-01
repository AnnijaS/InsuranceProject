using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Client
    {
        // will be automatically generated 
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
       // public string ClientType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string SocialSecurityNumber{ get; set; }
        public string BankAccountNumber { get; set; }
        //public string Gender { get; set; }
        public enum ClientType
        {
            Private,
            Commercial
        }
        public enum Gender
        {
            Male,
            Female
        }
    }
}