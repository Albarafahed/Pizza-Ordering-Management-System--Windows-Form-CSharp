using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YourNamespace;

public class ShoppingCartService
{
    public static int Counter = 1;
    public List<Product> Products { get; private set; } = new List<Product>();

    public List<Product> Orders { get; set; } = new List<Product>();


    public void AddProduct(Product product)
    {
        Products.Add(product);
        Orders.Add(product);
        Save();
    }

    public void RemoveProduct(int id)
    {
        Products.RemoveAll(x => x.OrderId == id);
        Orders.RemoveAll(x => x.OrderId == id);
        Save();
    }


    public ShoppingCartService()
    {
        Products = JsonDatabase.LoadOrders();
    }

    public ShoppingCartService(int id)
    {
      Orders=new List<Product>();
    }
    public void Save()
    {
        JsonDatabase.SaveOrders(Products);
    }

    public void Save(List<Product> products)
    {
        JsonDatabase.SaveOrders(products);
    }

    public int GetNextCustomerId()
    {
      
        if (Products.Count == 0)
            return 1; // أول عميل يبدأ من 1

        return Products.Max(p => p.CustomerId) + 1;
    }

    public void UpdateProductStatus(int orderId, string newStatus)
    {
        var product = Products.FirstOrDefault(p => p.OrderId == orderId);
        if (product != null)
        {
            product.Status = newStatus;
        }
    }

   

    public List<Product> GetOrdersByCustomer(int customerId)
    {
        return Products.Where(p => p.CustomerId == customerId).ToList();
    }

    public Product GetProductById(int id)
    {
        return Products.FirstOrDefault(i=> i.OrderId == id);
    }

    public List<Product> GetAllProduct()
    {
        return Products;
    }


  


    public void AddOrder(int customerId,string kind,string Name,string size,string Topping,int Amunt,string price)
    {
      
        var product = new Product
        {
            OrderId = Products.Count > 0 ?Products.Max(n => n.OrderId) + 1 : 1,
            CustomerId = customerId,
            Kind = kind,
            Name = Name,
            Size = size,
            Topping = Topping,
            Amount = Amunt,
            Price = decimal.Parse(price.Trim('$')),
            Status = "Pending"
        };

        AddProduct(product);
     


        MessageBox.Show($"{kind} order added successfully!");
      
    }

}
