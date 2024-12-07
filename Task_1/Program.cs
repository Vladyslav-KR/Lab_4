using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Встановлення кодування для кирилиці
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Створення магазину
        Shop shop = new Shop();

        // Додавання товарів
        Product product1 = new Product("Ноутбук", 15000, "Потужний ноутбук для роботи та ігор", "Електроніка", 4.5);
        Product product2 = new Product("Телефон", 8000, "Смарт телефон з гарною камерою", "Електроніка", 4.7);
        Product product3 = new Product("Книга", 200, "Навчальна книга з програмування", "Книги", 5);
        shop.AddProduct(product1);
        shop.AddProduct(product2);
        shop.AddProduct(product3);

        // Створення користувача
        User user = new User("vlad1123", "password123");
        shop.AddUser(user);

        // Додавання замовлення
        var quantities = new Dictionary<Product, int>
        {
            { product1, 1 },
            { product3, 2 }
        };
        Order order = new Order(new List<Product> { product1, product3 }, quantities);
        user.AddToHistory(order);

        // Пошук товарів за ціною
        var foundByPrice = shop.SearchByPrice(shop.Products, 5000, 15000);
        Console.WriteLine("Товари, що відповідають діапазону цін 5000-15000 грн:");
        foreach (var product in foundByPrice)
        {
            product.DisplayProductInfo();
            Console.WriteLine();
        }

        // Пошук товарів за категорією
        var foundByCategory = shop.SearchByCategory(shop.Products, "Електроніка");
        Console.WriteLine("Товари в категорії 'Електроніка':");
        foreach (var product in foundByCategory)
        {
            product.DisplayProductInfo();
            Console.WriteLine();
        }

        // Виведення історії покупок користувача
        user.DisplayUserInfo();
    }
}

