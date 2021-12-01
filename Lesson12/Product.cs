using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class Product : IComparable<Product>
    {
        public string ProductName { get; set; }

        public string ShopName { get; set; }

        public int CompareTo(Product other)
        {
            return ShopName.CompareTo(other.ShopName);
        }

        public static void CheckShop(Product[] product, string shopToCheck)
        {
            int shopFound = 0;
            foreach (var item in product)
            {
                if (item.ShopName == shopToCheck)
                {
                    ++shopFound;
                    Console.WriteLine(item.ToString());
                }
            }
            try
            {
                if (shopFound == 0)
                {
                    throw new NullShopException("не существует!");
                }
            }
            catch (NullShopException e)
            {
                Console.WriteLine($"магазина с названием {shopToCheck} {e.Message}");
            }
        }

        public override string ToString()
        {
            return $"Товар {ProductName} есть в этом магазине.";
        }
    }
}
