using System.ComponentModel.DataAnnotations;

namespace DepartmentApp.Models;

public class Department
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string? Name { get; set; }

    [MaxLength(1000)]
    public string? Description { get; set; }
    
    public Boolean? Status { get; set; }
}