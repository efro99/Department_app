using Microsoft.EntityFrameworkCore;
using DepartmentApp.Models;

namespace DepartmentApp.Data
{
    public class DepartmentsContext : DbContext
    {
        public DepartmentsContext (DbContextOptions<DepartmentsContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<User> Users => Set<User>();

         public DbSet<UserRole> UserRoles => Set<UserRole>();
        
    }
}