using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendor.WebApi.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Article> Articles { get; set; }
    }
}