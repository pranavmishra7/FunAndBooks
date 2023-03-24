using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Products
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
