using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Grupp6_ovning.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Request>().HasData(new Request { RequestId = 1, TypeOfRequest = "Pending" });
            builder.Entity<Request>().HasData(new Request { RequestId = 2, TypeOfRequest = "Approved" });
            builder.Entity<Request>().HasData(new Request { RequestId = 3, TypeOfRequest = "Denied" });

            builder.Entity<LeaveType>().HasData(new LeaveType { LeaveTypeId = 1, TypeName = "Vabb" });
            builder.Entity<LeaveType>().HasData(new LeaveType { LeaveTypeId = 2, TypeName = "Semester" });
            builder.Entity<LeaveType>().HasData(new LeaveType { LeaveTypeId = 3, TypeName = "Sjuk" });
        }

    }
}
