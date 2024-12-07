public class Shop : ISearchable
{
    public List<Product> Products { get; set; }
    public List<User> Users { get; set; }

    public Shop()
    {
        Products = new List<Product>();
        Users = new List<User>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public List<Product> SearchByPrice(List<Product> products, double minPrice, double maxPrice)
    {
        return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
    }

    public List<Product> SearchByCategory(List<Product> products, string category)
    {
        return products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Product> SearchByRating(List<Product> products, double minRating)
    {
        return products.Where(p => p.Rating >= minRating).ToList();
    }

    public void DisplayShopInfo()
    {
        Console.WriteLine("Товари в магазині:");
        foreach (var product in Products)
        {
            product.DisplayProductInfo();
            Console.WriteLine();
        }
    }
}

