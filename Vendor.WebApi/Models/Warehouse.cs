﻿using Shop.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Core.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        public List<Shop> Shops { get; set; }
        public List<Article> Articles { get; set; }
        public List<SupplyOrder> SupplyOrders { get; set; }
    }
}