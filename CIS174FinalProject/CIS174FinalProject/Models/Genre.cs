using System.ComponentModel.DataAnnotations;

namespace CIS174FinalProject.Models;

public class Genre
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;

    // Navigation property
    public ICollection<Book>? Books { get; set; }
}
