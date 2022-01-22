using System;
using System.ComponentModel.DataAnnotations;

namespace IS413Mission4.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(4)]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Note { get; set; }
    }
}
