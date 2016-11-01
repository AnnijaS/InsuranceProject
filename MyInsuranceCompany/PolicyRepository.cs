using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class PolicyRepository
    {

        //This is were we are going to store all data 
        private readonly List<Policy> _policy = CreatePolicy();

        private static List<Policy> CreatePolicy()
        {
            return new List<Policy>()
                   {
                       new Policy()
                       {
                           PolicyId = "1",
                           StartDate =  new DateTime(2016, 9, 23),
                           EndDate = new DateTime(2017, 9, 22),
                           Premium = 20,
                           Version = 1,
                         //  Client = "My car 1"
                       },
                      new Policy()
                       {
                           PolicyId = "2",
                           StartDate =  new DateTime(2016, 10, 1),
                           EndDate = new DateTime(2017, 9, 30),
                           Premium = 20,
                           Version = 1,
                          // Client = "My car 2"
                       },
                      new Policy()
                       {
                            PolicyId = "3",
                           StartDate =  new DateTime(2016, 10, 6),
                           EndDate = new DateTime(2017, 10, 5),
                           Premium = 20,
                           Version = 1,
                          // Client = "My car 3"
                       }
                   };
        }


        public string CreateNewPolicy(Product product, Client client)
        {
            DateTime today = DateTime.Today;
            //Create new Policy 
            //return _policy.FirstOrDefault(x => x.PolicyNumber == number);
            Policy policy = new Policy()
            {
                PolicyId = Guid.NewGuid().ToString(),
                StartDate = today,
                EndDate = today.AddYears(1),
                Premium = product.Premium,
                Version = 1,
                Client = client,
                Statuss= Statuss.Draft
            };
            //policy.Client = client; var ari said rakstit

            _policy.Add(policy);
            return policy.PolicyId;
        }

        public decimal GetPolicyPriceById(string policyId)
        {
            Policy policy = _policy.FirstOrDefault(x => x.PolicyId == policyId);
            //return _policy.FirstOrDefault(x => x.PolicyNumber == policyNumber).Premium;
            if (policy != null)
            {
                return policy.Premium;
            }
            else
            {
                // throw new ApplicationException("Policy with "+ policyNumber +" not found");
                throw new ApplicationException($"Policy with {policyId} not found");
            }
        }

        public Policy GetPolicyById(string policyId)
        {
            Policy policy = _policy.FirstOrDefault(x => x.PolicyId == policyId);
            if (policy != null)
            {
                return policy;
            }
            else
            {
                // throw new ApplicationException("Policy with "+ policyNumber +" not found");
                throw new ApplicationException($"Policy with {policyId} not found");
            }
            }

        public void SavePolicy(Policy newPolicy)
        {
            //atrast polisi pec id
            var oldPolicy = GetPolicyById(newPolicy.PolicyId);
            //izdzest esoso polisi pec id
            _policy.Remove(oldPolicy);
            //pievienot jaunu polisi 
            _policy.Add(newPolicy);
        }
    }
}