﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class User
    {
        [Key]
        public string id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
