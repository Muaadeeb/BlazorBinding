using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }

        public double Price { get; set; }

        public List<ProductProp> ProductProperties { get; set; } = null!;
    }
}
