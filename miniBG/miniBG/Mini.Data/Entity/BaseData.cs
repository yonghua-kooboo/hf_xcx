using Mini.Data.Entity;
using System;

namespace Mini.Data
{
    public class BaseData : BaseModel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Icon { get; set; }

        public string IsDefault { get; set; }
    }
}
