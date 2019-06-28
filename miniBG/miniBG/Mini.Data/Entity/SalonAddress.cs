using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class SalonAddress : Address
    {
        public Guid SalonID { get; set; }

        public string Compere { get; set; }

        public virtual Salon Salon { get; set; }
    }
}
