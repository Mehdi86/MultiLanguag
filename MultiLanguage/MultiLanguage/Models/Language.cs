using System.ComponentModel.DataAnnotations;

namespace MultiLanguage.Models
{
    public class Language
    {
        [Key]
        public int LandId { get; set; }

        [Required]
        public string? LanguageTitle { get; set; }


        public List<News>? News { get; set; }
    }
}
