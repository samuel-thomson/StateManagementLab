﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementLab.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public User(string username, string password) 
        {
            this.UserName = username;
            this.Password = password;
        }
        public User()
        {

        }
    }

}
