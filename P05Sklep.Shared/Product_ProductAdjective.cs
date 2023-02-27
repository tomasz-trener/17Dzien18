using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace P05Sklep.Shared
{
    public class Product_ProductAdjective
    {
         
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public ProductAdjective ProductAdjective { get; set; }
        public int ProductAdjectiveId { get; set; }

        [Column(TypeName ="decimal(6,2)")]
        public double Price { get; set; }

    }
}
