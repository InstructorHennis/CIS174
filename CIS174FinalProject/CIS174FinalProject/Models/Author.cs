using System.ComponentModel.DataAnnotations;

namespace CIS174FinalProject.Models;

public class Author
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    // Navigation property
    public ICollection<Book>? Books { get; set; }
}
