using Shop.Core.Models;
using System.Collections.Generic;

namespace Vendor.WebApi.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Shop> Shops { get; set; }
        public List<Article> Articles { get; set; }
    }
}