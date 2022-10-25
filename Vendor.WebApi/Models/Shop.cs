using Shop.Core.Models;
using System.Collections.Generic;

namespace Vendor.WebApi.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int WarehouseId { get; set; }
        public List<Article> Articles { get; set; } 
    }
}