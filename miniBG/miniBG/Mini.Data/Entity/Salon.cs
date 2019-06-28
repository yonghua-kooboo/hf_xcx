using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class Salon : BaseModel
    {
        public string Description { get; set; }

        public string Digist { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<SalonAddress> SalonAddresses { get; set; }

        public virtual ICollection<SalonItem> SalonItems { get; set; }
    }
}
