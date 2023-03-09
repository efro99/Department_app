using System.ComponentModel.DataAnnotations;

namespace DepartmentApp.Models;

public class UserRole
{
    public int ID { get; set; }

    public Role? roleID { get; set; }

    [Required]
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

  
}