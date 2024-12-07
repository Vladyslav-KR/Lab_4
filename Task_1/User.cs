
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Order> PurchaseHistory { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
        PurchaseHistory = new List<Order>();
    }

    public void AddToHistory(Order order)
    {
        PurchaseHistory.Add(order);
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Логін: {Username}");
        Console.WriteLine("Історія покупок:");
        foreach (var order in PurchaseHistory)
        {
            Console.WriteLine($"- Замовлення {order.OrderId} на суму {order.TotalPrice} грн");
        }
    }
}

