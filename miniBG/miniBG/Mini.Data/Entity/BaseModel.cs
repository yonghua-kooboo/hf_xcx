using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class BaseModel
    {
        public Guid ID { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
