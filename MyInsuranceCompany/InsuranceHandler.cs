using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class InsuranceHandler
    { 
        //atrod polisi, nomaina statusu uz nopirkts
        public void BuyInsurance(string policyId)
        {
            PolicyRepository policyRepository = new PolicyRepository();
            var policy = policyRepository.GetPolicyById(policyId);
            policy.Statuss = Statuss.Active;
            policyRepository.SavePolicy(policy);
        }

        //<Summary>
        //produktu
        //klienta dati, pec koienta pers.k. zinas masinu
        //
        //</Summary>
        public decimal GetPrice(Client client, int productId )//productid ka mainigais saja metode tikai, lidzigi ari client
        {
            //validate customer against product

            ProductRepository productRepository = new ProductRepository();
            var product = productRepository.GetProductById(productId);


            //Izveidot Polices repozitoriju un izmantot metodi 
            //Create a policy
            PolicyRepository policyRepository = new PolicyRepository();
            var policyId = policyRepository.CreateNewPolicy(product, client);

            //Return a policy
            return policyRepository.GetPolicyPriceById(policyId);

            


        }
    }
}