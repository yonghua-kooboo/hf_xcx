using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Interfaces.Models
{
    public class BaseModelDto
    {
        public Guid ID { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
