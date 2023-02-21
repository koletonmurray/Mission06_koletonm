using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_koletonm.Models
{
    // The model for adding a movie to the database
    public class AddMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(0, 3000)]
        public ushort Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
        

        // Build foreign key relationship between categoryid in both movies and moviecategories tables
        [Required]
        public int CategoryId { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
