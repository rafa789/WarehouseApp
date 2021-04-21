using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Data
{
    public class Producto
    {
        public int id { get; set; }
        [Required]
        public string sku_number { get; set; }
        [Required]
        public string description { get; set; }
        public DateTime creation_date { get; set; }
        public bool status { get; set; }
        public int quantity { get; set; }
    }
}
