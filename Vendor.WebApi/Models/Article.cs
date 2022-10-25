using System;
using System.Collections.Generic;
using Vendor.WebApi.Models;

namespace Shop.Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal SupplierPrice { get; set; }
        public int Quantity { get; set; }
        public int BuyerId { get; set; }
        public int? ShopId { get; set; }
        public int? WarehouseId { get; set; }
        public int? SupplierId { get; set; }
        public List<ShoppingArticle> ShoppingArticles { get; set; }
    }
}