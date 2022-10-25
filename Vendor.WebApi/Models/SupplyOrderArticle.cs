using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Vendor.WebApi.Models
{
    public class SupplyOrderArticle
    {
        public int Id { get; set; }
        public int SupplyOrderId { get; set; }
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
    }
}