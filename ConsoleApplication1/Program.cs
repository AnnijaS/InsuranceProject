using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInsuranceCompany;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var repo = new ProductRepository();

            while (true)
            {
                Console.WriteLine("Enter 1 to add new product, enter 2 to create new policy");
                var userChoice = Console.ReadLine();
                int usersChoiceAsInt;
                bool parseSuccess = Int32.TryParse(userChoice, out usersChoiceAsInt);//atgriez vai izdevies parverst stringu par ciparinu
                if (parseSuccess == false)
                {
                    continue;//ja lietotajs ievada stulbibas, paprasa no jauna sakt visu ievadi
                }

                if (usersChoiceAsInt == 1)
                {
                    Console.WriteLine("Enter the name of your product");
                    var nameOfProduct = Console.ReadLine();
                    Console.WriteLine("Enter the price of your product");
                    var priceOfProduct = Console.ReadLine();
                    int priceOfProductAsInt;
                    bool priceParseSuccess = Int32.TryParse(priceOfProduct, out priceOfProductAsInt);//atgriez vai izdevies parverst stringu par ciparinu
                    if (priceParseSuccess == false)
                    {
                        Console.WriteLine("failed to add product, wrong price entered");
                        continue;//ja lietotajs ievada stulbibas, paprasa no jauna sakt visu ievadi
                    }

                    repo.AddProduct(nameOfProduct, priceOfProductAsInt);
                }
                else if (usersChoiceAsInt == 2)
                {
                    
                }
                
            }

            
        }
    }
}
