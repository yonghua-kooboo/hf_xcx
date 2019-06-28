using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Data.Entity
{
    public class Customer : BaseModel
    {
        public string OpenID { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public Gender Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public string Avatar { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public virtual ICollection<CustomerAddress> Addresses { get; set; }
    }
}
