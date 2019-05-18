using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class Order
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
    }
}
