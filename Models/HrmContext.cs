using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace HRM.Models
{
    public class HrmContext : DbContext
    {
        public HrmContext(DbContextOptions<HrmContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
