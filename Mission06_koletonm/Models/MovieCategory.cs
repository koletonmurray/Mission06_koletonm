﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_koletonm.Models
{
    // The model for the movie catagories stored in the database
    public class MovieCategory
    {
        [Key]
        public int MovieCategoryId { get; set; }
        public string MovieCategoryName { get; set; }
    }
}
