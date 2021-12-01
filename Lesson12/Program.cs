using System;
using System.Collections.Generic;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product { ProductName = "Молоко", ShopName = "Пятерочка" };
            Product water = new Product { ProductName = "Вода", ShopName = "Соседи" };
            Product beer = new Product { ProductName = "Пиво", ShopName = "Светофор" };
            Product cheeze = new Product { ProductName = "Сыр", ShopName = "Виталюр" };
            Product chips = new Product { ProductName = "Чипсы", ShopName = "Пятерочка" };

            Product[] prod = new Product[5] { milk, water, beer, cheeze, chips };

            Array.Sort(prod);

            Console.WriteLine("Введите название магазина с учетом регистра:");
            string x = Console.ReadLine();

            Product.CheckShop(prod, x);
        }
    }
}
