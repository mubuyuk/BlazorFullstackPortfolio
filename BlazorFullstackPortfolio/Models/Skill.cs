using System.ComponentModel.DataAnnotations;

namespace BlazorFullstackPortfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Teknologinamn är obligatoriskt")]
        [StringLength(50, ErrorMessage = "Max 50 tecken")]
        public string TechnologyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Erfarenhet är obligatoriskt")]
        public string YearsOfExperience { get; set; } = string.Empty;

        [Range(1, 100, ErrorMessage = "Skill Level måste vara mellan 1 och 100")]
        public int SkillLevel { get; set; }
    }
}
