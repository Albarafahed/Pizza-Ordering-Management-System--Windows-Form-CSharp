

public class Product
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public string Kind { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Size { get; set; }
    public string Topping { get; set; }
    public int Amount { get; set; }
    public string Status { get; set; }

    public bool IsPrinted { get; set; }=false;
}
