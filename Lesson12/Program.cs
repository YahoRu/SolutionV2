using System;
using System.Collections.Generic;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product { ProductName = "Молоко", ShopName = "Пятерочка" };
            Product water = new Product { ProductName = "Вода", ShopName = "Пятерочка" };
            Product beer = new Product { ProductName = "Пиво", ShopName = "Светофор" };
            Product cheeze = new Product { ProductName = "Сыр", ShopName = "Пятерочка" };
            Product chips = new Product { ProductName = "Чипсы", ShopName = "Пятерочка" };

            Product[] prod = new Product[5] { milk, water, beer, cheeze, chips };

            Array.Sort(prod);

            string x = Console.ReadLine();
            int count = 0;
            foreach (var item in prod)
            {
                if (item.ShopName == x)
                {
                    count++;
                    Console.WriteLine(item.ToString());
                }
            }
            try
            {
                if (count == 0)
                {
                    throw new NullShopExeption("Таких магазинов нет!");
                }
            }
            catch (NullShopExeption e)
            {
                Console.WriteLine($"магазина с названием {x} не существует");
            }
        }
    }
}
