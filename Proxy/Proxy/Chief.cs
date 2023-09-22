namespace Proxy;

internal class Chief : IChief
{
    public IDictionary<int, string> GetStatuses()
    {
        Dictionary<int, string> statuses = new();

        statuses.Add(1, "готово");
        statuses.Add(2, "НЕ готово");
        statuses.Add(3, "готовиться");

        Thread.Sleep(2000);    //пауза щоб продемонструвати проксі

        return statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders = new();

        orders.Add(new Order() { Name = "Салат", StatusId = RandomizeStatusID() });
        orders.Add(new Order() { Name = "Борщ", StatusId = RandomizeStatusID() });
        orders.Add(new Order() { Name = "Капуста", StatusId = RandomizeStatusID() });
        return orders;
        
    }

    private static int RandomizeStatusID() => new Random().Next(1,4);
}

