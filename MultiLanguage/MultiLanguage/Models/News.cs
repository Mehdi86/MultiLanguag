using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiLanguage.Models
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }

        
        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public Language? Language { get; set; }

        [Required]
        [MaxLength(300)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? ImageName { get; set; }

        public DateTime RegisterDate { get; set; }



    }
}
