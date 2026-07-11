using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace YourNamespace
{
    public static class JsonDatabase
    {
        private static string filePath = "orders.json";

        public static List<Product> LoadOrders()
        {
            if (!File.Exists(filePath))
                return new List<Product>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        public static void SaveOrders(List<Product> orders)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(orders));

        }
    }
}
