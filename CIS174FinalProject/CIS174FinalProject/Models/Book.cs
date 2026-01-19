using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIS174FinalProject.Models;

public class Book
{
    [Key]
    public string ISBN { get; set; } = string.Empty;

    [Required]
    [ForeignKey("Author")]
    public int AuthorId { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public int Year { get; set; }

    [Required]
    [ForeignKey("Genre")]
    public int GenreId { get; set; }

    // Navigation properties
    public Author? Author { get; set; }
    public Genre? Genre { get; set; }
}
