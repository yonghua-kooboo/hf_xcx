using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class Address : BaseModel
    {
        public string AddressType { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string Street { get; set; }
    }
}
