public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public double Rating { get; set; }

    public Product(string name, double price, string description, string category, double rating)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        Rating = rating;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Ціна: {Price} грн");
        Console.WriteLine($"Опис: {Description}");
        Console.WriteLine($"Категорія: {Category}");
        Console.WriteLine($"Рейтинг: {Rating}/5");
    }
}
