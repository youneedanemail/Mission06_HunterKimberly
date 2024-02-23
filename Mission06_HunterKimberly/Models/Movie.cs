using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_HunterKimberly.Models
{
    public class Movie
    {
        [Key]                                           // creates primary key
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryID")]                      // Creates Foreign Key
        public int? CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }        // do i need this check
        [Required]
        public string Title { get; set; }
        [Range(1888,4000)]                              // Start at first movie and anticipate longevity of app
        [Required]
        public int Year { get; set; }   
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25)]                              // sets textbox length
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes {  get; set; }

    }
}
