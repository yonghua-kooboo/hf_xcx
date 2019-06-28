using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniBG.Models
{
    public class BaseModelVm
    {
        public Guid ID { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
