using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miniBG.Models
{
    public class BaseDataVM  : BaseModelVm
    {
        [Required]
        [Display(Name = "Category")]
        public string Type { get; set; }

        [Required]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        public string IsDefault { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Icon { get; set; }
    }
}
