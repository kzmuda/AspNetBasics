using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal DefaultPrice { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }
    }
}
