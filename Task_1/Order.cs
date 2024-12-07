public class Order
{
    public static int OrderCounter = 1;
    public int OrderId { get; set; }
    public List<Product> Products { get; set; }
    public Dictionary<Product, int> Quantities { get; set; }
    public double TotalPrice { get; set; }
    public string Status { get; set; }

    public Order(List<Product> products, Dictionary<Product, int> quantities)
    {
        OrderId = OrderCounter++;
        Products = products;
        Quantities = quantities;
        TotalPrice = CalculateTotalPrice();
        Status = "Очікується";
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var item in Quantities)
        {
            total += item.Key.Price * item.Value;
        }
        return total;
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine($"Замовлення {OrderId} (Статус: {Status})");
        foreach (var item in Quantities)
        {
            Console.WriteLine($"{item.Key.Name}: {item.Value} шт.");
        }
        Console.WriteLine($"Загальна вартість: {TotalPrice} грн");
    }
}