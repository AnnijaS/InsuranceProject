using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class ProductRepository
    {
        public ProductRepository()
        {
            var allProducts=CreateProduct();
            this._products.AddRange(allProducts);//katrreiz kad izveidos productu repository, tas tiks aizpildits ar tiem divainajiem maniem produktiem
        }

        private List<Product> _products = new List<Product>();//1 privats mainigais _products, productus iegus no metodes

        public Product GetProductById(int id)
        {
            //return _products.FirstOrDefault(x => x.ProductNumber == id);
            //viens ^^ vai otrs variants >>
            foreach (var product in _products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return null;
        }
        private static List<Product> CreateProduct()
        {
            return new List<Product>()
            {
                new Product()
                {
                    ProductName= "Liability basic",
                    StartDate = new DateTime(2016,9, 9, 16, 40, 0), //StartDate, Enddate
                    ProductId = 1,
                     Premium = 50
                    //LoBs
                },
                new Product()
                {
                    ProductName= "Liability Standard",
                     ProductId = 2,
                     Premium = 20
                },
                new Product()
                {
                    ProductName= "Liability Super",
                     ProductId = 3,
                     Premium = 30
                },
                 new Product()
                {
                    ProductName= "Property-building",
                     ProductId = 4,
                     Premium = 50
                },
                 new Product()
                {
                    ProductName= "TPL",
                     ProductId = 5,
                     Premium = 60
                },
                 new Product()
                {
                    ProductName= "Business travel",
                     ProductId = 6,
                     Premium = 30
                },
                 new Product()
                {
                    ProductName= "Health basic",
                     ProductId = 7,
                     Premium = 30
                },
                 new Product()
                {
                    ProductName= "Health Standard",
                     ProductId = 8,
                     Premium = 40
                },
                 new Product()
                {
                    ProductName= "Health Super",
                     ProductId = 9,
                     Premium = 70
                },

            };
        }
        //public AddProduct 
        //polisu repozitorija, 2 metodes, izveidot jaunu un izgut info(?) vai ko tur???
        public Product AddProduct(string name, decimal price)
        {
            var newProduct =new Product();
            newProduct.ProductName = name;
            newProduct.Premium = price;
            this._products.Add(newProduct);
            return newProduct;
        }
    }
   
}