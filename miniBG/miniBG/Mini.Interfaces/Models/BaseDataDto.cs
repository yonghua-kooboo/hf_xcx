using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Interfaces.Models
{
    public class BaseDataDto : BaseModelDto
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Icon { get; set; }

        public string IsDefault { get; set; }
    }
}
