namespace Mission6.Models;

using System.ComponentModel.DataAnnotations;
    
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Primary Key

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown logic is handled in the View

        public bool Edited { get; set; } // Yes/No maps to bool

        public string? LentTo { get; set; } // Question mark means Nullable (Optional)

        [MaxLength(25, ErrorMessage = "Notes must be 25 characters or less.")]
        public string? Notes { get; set; } // Optional and limited to 25 chars
    }
