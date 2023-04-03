using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class User
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Surname { get; set; }

    [Display(Name = "Monthly Fee")]
    public int MonthlyFee { get; set; }
}