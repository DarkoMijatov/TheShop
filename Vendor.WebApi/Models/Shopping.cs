using System;
using System.Collections.Generic;
using Vendor.WebApi.Enums;

namespace Vendor.WebApi.Models
{
    public class Shopping
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public int BuyerId { get; set; }
        public int ShopId { get; set; }
        public List<ShoppingArticle> ShoppingArticles { get; set; }
    }
}