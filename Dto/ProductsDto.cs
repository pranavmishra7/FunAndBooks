using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ProductsDto
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryDto Category { get; set; }
    }
}
