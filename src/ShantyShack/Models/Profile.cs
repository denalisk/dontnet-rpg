﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShantyShack.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Character> Characters { get; set; }

    }
}
