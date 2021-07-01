using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi_Project.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200,MinimumLength =10, ErrorMessage ="HeadLine characters should be between 10 and 200")]
        public string Headline { get; set; }
        [Required]
        [StringLength(2000, MinimumLength = 50, ErrorMessage = "Review text characters should be between 50 and 2000")]
        public string ReviewText { get; set; }
        [Required]
        [Range(1,5,ErrorMessage = "rating must be between 1 and 5 starts")]
        public int Rating { get; set; }
        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }

    }
}
    