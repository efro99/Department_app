using System.ComponentModel.DataAnnotations;

namespace DepartmentApp.Models;

public class Role
{
    public int Id { get; set; }

    [Required]
    [MaxLength(2000)]
    public string? Name { get; set; }

    [Required]
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

  
}