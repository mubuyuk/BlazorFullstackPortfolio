using System.ComponentModel.DataAnnotations;

namespace BlazorFullstackPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Projektnamn är obligatoriskt")]
        public string ProjectName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Beskrivning är obligatoriskt")]
        public string? Description { get; set; }


        public string? TechnologiesUsed { get; set; }
    }
}
