using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Mission06_HunterKimberly.Models
{
    public class Movie
    {
        [Key]       // creates primary key
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(1888,4000)]
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? Lent_To { get; set; }
        [StringLength(25)]  // sets textbox length
        public string? Notes {  get; set; }

    }
}
