using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace VuelingFaktory.Domain
{
    public class OrderService
    {
        public OrderInfo GetOrder()
        {
            string fileName = "C:\\Users\\yaise\\source\\repos\\VuelingFaktory\\VuelingFaktory\\Configuration\\orderdata.json";
            FileStream openStream = File.OpenRead(fileName);
            
            return JsonSerializer.DeserializeAsync<OrderInfo>(openStream).Result;
        }
    }
}
