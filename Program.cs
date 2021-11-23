using System;
using System.IO;
using OnlineStoreLibrary;

namespace OnlineStoreApp
{
    class Program
    {         
        static OnlineStore S = new();
        static void Main(string[] args)
        {                        
            int option = 0;

            while (option != 5)
            {
                Console.WriteLine("You selected to: " + option);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nyou chose to add products to inventory");

                        int ProductQuantity = 0;                     
                        decimal ProductPrice = 0.00M;
                        string ProductDescription = "None yet!";                       
                        string ProductBrand = "Nothing yet!";

                        Console.WriteLine("\nhow many are in stock?\n");
                        ProductQuantity = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("what is the price?\n");
                        ProductPrice = decimal.Parse(Console.ReadLine());
                       
                        Console.WriteLine("enter the brand name\n");
                        ProductBrand = (Console.ReadLine());

                        Console.WriteLine("enter details about the product\n");
                        ProductDescription = Console.ReadLine();

                        Products newProduct = new Products(ProductQuantity, ProductPrice, ProductBrand, ProductDescription);
                        S.ProductsList.Add(newProduct);
                        S.PrintInventory(S);
                        break;

                    case 2:
                        Console.WriteLine("what product do you want to view?\n");
                        S.PrintInventory(S);
                        int item = int.Parse(Console.ReadLine());
                        S.OnlineStoreList.Add(S.ProductsList[item]);
                        S.PrintInventory(S);
                        break;

                    case 3:
                        S.PrintCheckOut(S);
                        Console.WriteLine("The total cost is: R" + S.CheckOut());
                        
                        break;

                    case 4:
                        S.PrintReceipt();
                        Console.WriteLine("check your desktop for the text file receipt");
                        break;

                    default:
                        break;
                }
                option = S.OptionSelect();            
            }
        }
    }
}
