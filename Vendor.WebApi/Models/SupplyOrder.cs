using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendor.WebApi.Enums;

namespace Vendor.WebApi.Models
{
    public class SupplyOrder
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public int SupplierId { get; set; }
        public int? ShopId { get; set; }
        public int? WarehouseId { get; set; }
        public List<SupplyOrderArticle> Articles { get; set; }
    }
}