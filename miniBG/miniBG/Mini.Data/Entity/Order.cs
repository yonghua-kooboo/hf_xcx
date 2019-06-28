using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class Order : BaseModel
    {
        public decimal Price { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? SalonID { get; set; }

        public Guid CustomerID { get; set; }

        public OrderStatu OrderStatu { get; set; }

        public DateTime Start { get; set; }

        public DateTime? Complete { get; set; }

        public virtual Product Product { get; set; }

        public virtual Salon Salon { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
