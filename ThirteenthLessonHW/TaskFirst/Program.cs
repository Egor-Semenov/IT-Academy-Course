using System;

namespace TaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];

            Product product1 = new Product() {ShopName = "Lemon", ProductName = "Fork" };

            Product product2 = new Product() { ShopName = "Green", ProductName = "Spoon" };

            Product product3= new Product() { ShopName = "Green", ProductName = "Phone" };

            Product product4 = new Product() { ShopName = "Lemon", ProductName = "TV" };

            Product product5 = new Product() { ShopName = "Apple", ProductName = "Food" };

            products[0] = product1;
            products[1] = product2;
            products[2] = product3;
            products[3] = product4;
            products[4] = product5;

            

            products.Sort();

            foreach (var item in products)
            {

                Console.WriteLine(item.ProductName + " " + item.ShopName);
                
            }

            Console.WriteLine("");

            try
            {
                products.SearchShopItems("Gren");
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("");

            try
            {
                products.SearchShopItems("Green");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}


