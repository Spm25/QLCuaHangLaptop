﻿using System.ComponentModel.DataAnnotations;

namespace QLCuaHangLaptop.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
