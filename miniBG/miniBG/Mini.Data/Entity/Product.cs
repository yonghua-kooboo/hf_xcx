using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class Product : BaseModel
    {
        public Guid ProductType { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Digist { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public bool Display { get; set; }

        public int SortIndex { get; set; }

        public virtual ICollection<ProductItem> ProductItems { get; set; }
    }
}
