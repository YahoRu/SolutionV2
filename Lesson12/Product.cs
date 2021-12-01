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

        public override string ToString()
        {
            return $"Товар {ProductName} есть в этом магазине.";
        }
    }
}
