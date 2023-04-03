using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Tutor
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Surname { get; set; }

    public int Salary { get; set; }
}