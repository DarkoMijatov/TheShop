using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendor.WebApi.Models
{
    public class ShoppingArticle
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
        public int ShoppingId { get; set; }
    }
}