using System;
using System.Collections.Generic;
using Shop.Core.Enums;

namespace Shop.Core.Models
{
    public class Shopping
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public int? BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public List<ShoppingArticle> ShoppingArticles { get; set; }
    }
}