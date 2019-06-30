﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mini.Interfaces.Models
{
    public class UserDto : BaseModelDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public string Avatar { get; set; }

        public string PhoneNumber { get; set; }

        public ActiveStatu ActiveStatu { get; set; }

        public string Password { get; set; }
    }
}
