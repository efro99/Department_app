using System.ComponentModel.DataAnnotations;

namespace DepartmentApp.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public DateTime? Logon { get; set; }

    [Required]
    [MaxLength(2000)]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(2000)]
    public string? LastName { get; set; }

    public Department? UserDepartment  { get; set; }
    
    [Required]
    public DateTime? StartDate { get; set; }

    [Required]
    public DateTime? EndDate { get; set; }
}