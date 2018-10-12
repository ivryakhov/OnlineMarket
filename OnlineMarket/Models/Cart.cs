using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Models
{
    public class Cart
    {
        [Key]
        public Guid Guid { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public DateTime CreationDate { get; set; }
    }
}