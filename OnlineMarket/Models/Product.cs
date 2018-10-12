using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Models
{
    public class Product
    {
        [Key]
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }        
    }
}