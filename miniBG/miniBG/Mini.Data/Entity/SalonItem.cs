using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class SalonItem : BaseModel
    {
        public string Description { get; set; }

        public int Price { get; set; }

        public bool Display { get; set; }

        public Guid SalonID { get; set; }

        public virtual Salon Salon { get; set; }
    }
}
