using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
/*The Price property has been decorated with the Column attribute, which specifies the precision of the values that will be stored in the
 * databse. The column attribute tells Entity Framework Core which SQL type should be used in the db to store price values. In this case,
 * the decimal(8,2)type will allow a total of eight digits, including the 2 following the decimal point.
 * */
