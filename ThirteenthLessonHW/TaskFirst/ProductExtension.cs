using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst
{
    public static class ProductExtension
    {
        public static void Sort(this Product[] products)
        {
            for (int i = 1; i < products.Length; i++)
            {
                for (int j = 0; j < products.Length - 1; j++)
                {
                    if (string.Compare(products[j].ShopName, products[j + 1].ShopName) > 0)
                    {
                        var temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }

        public static void SearchShopItems(this Product[] products , string shopName)
        {
            int count = 0;
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].ShopName == shopName)
                {
                    
                    Console.WriteLine(products[i].ProductName);
                    count++;
                }
            }

            if(count == 0)
            {
                throw new MyException($"Магазина с названием {shopName} не существует");
            }
        }
    }
}
