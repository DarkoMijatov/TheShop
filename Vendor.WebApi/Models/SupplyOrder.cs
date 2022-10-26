using System.Collections.Generic;
using Shop.Core.Enums;

namespace Shop.Core.Models
{
    public class SupplyOrder
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }
        public int? WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<SupplyOrderArticle> SupplyOrderArticles { get; set; }
    }
}