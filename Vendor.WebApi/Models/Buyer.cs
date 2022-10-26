using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Core.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        public List<Shopping> Shoppings { get; set; }
    }
}