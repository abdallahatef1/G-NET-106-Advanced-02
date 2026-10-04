namespace ADVANCED2
{
    internal class Program
    {
    //    static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    //    {
    //        var result = new List<Product>();
    //        foreach (var p in products)
    //            if (filter(p)) result.Add(p);
    //        return result;
    //    }

    //    static void PrintReport(List<Product> products, Action<Product> action)
    //    {
    //        foreach (var p in products) action(p);
    //    }

    //    static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
    //    {
    //        var result = new List<string>();
    //        foreach (var p in products) result.Add(transform(p));
    //        return result;
    //    }
    //    static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
    //    {
    //        var result = new List<Product>();
    //        foreach (var p in products)
    //            if (condition(p)) result.Add(p);
    //        return result;
    //    }

    //    static void Show(List<Product> list)
    //    {
    //        foreach (var p in list)
    //            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
    //    }

    //    static void Main(string[] args)
    //    {
    //        List<Product> catalog = new()
    //    {
    //        new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
    //        new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
    //        new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
    //        new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
          
    //    };
    //        Console.WriteLine("--- Electronics ---");
    //        Show(SearchProducts(catalog, p => p.Category == "Electronics"));

    //        Console.WriteLine("--- Under $50 ---");
    //        Show(SearchProducts(catalog, p => p.Price < 50));

    //        Console.WriteLine("--- In Stock ---");
    //        Show(SearchProducts(catalog, p => p.Stock > 0));

    //        Console.WriteLine("--- Clothing Under $100 ---");
    //        Show(SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100));

    //        Console.WriteLine("--- Short Report ---");
    //        PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

    //        Console.WriteLine("--- Detailed Report ---");
    //        PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

    //        Console.WriteLine("--- Summary List ---");
    //        foreach (var s in TransformProducts(catalog, p => $"{p.Name} (${p.Price})"))
    //            Console.WriteLine(s);

    //        Console.WriteLine("--- Price Labels ---");
    //        var labels = TransformProducts(catalog, p => p.Price > 100 ? "Expensive!" : "Affordable");
    //        for (int i = 0; i < catalog.Count; i++)
    //            Console.WriteLine($"{catalog[i].Name}: {labels[i]}");

    //        Console.WriteLine("--- Low-Stock Alert ---");
    //        foreach (var p in FilterProducts(catalog, p => p.Stock < 20))
    //            Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
        

    //}

        }
}
