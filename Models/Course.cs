using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Course
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Topic { get; set; }
    public int Price { get; set; }
    public int Rating { get; set; }
}