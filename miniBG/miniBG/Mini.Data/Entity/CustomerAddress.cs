using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class CustomerAddress : Address
    {
        public Guid CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
