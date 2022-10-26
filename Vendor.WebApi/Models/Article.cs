using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal SupplierPrice { get; set; }
        public int Quantity { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }
        public int? WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<ShoppingArticle> ShoppingArticles { get; set; }
        public List<SupplyOrderArticle> SupplyOrderArticles { get; set; }
    }
}