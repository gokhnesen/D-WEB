﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DüWEB.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Degree { get; set; }
        public string Email { get; set; }
        public string Profile { get; set; }
        public  string Link { get; set; }

    }
}
