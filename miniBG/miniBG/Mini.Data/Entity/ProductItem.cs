using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class ProductItem : BaseModel
    {
        public string Description { get; set; }

        public int Price { get; set; }

        public bool Display { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public Guid ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
