using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformDemo.Data.Data
{
    public class PlatformDbContext : DbContext
    {
        public PlatformDbContext(DbContextOptions<PlatformDbContext> options) : base(options) { }

        public DbSet<ServicePlan> ServicePlans { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for ServicePlan entities
            modelBuilder.Entity<ServicePlan>().HasData(
                new ServicePlan { ServicePlanId = 1, DateOfPurchase = DateTime.Now.AddDays(-100) },
                new ServicePlan { ServicePlanId = 2, DateOfPurchase = DateTime.Now.AddDays(-90) },
                new ServicePlan { ServicePlanId = 3, DateOfPurchase = DateTime.Now.AddDays(-80) },
                new ServicePlan { ServicePlanId = 4, DateOfPurchase = DateTime.Now.AddDays(-70) },
                new ServicePlan { ServicePlanId = 5, DateOfPurchase = DateTime.Now.AddDays(-60) },
                new ServicePlan { ServicePlanId = 6, DateOfPurchase = DateTime.Now.AddDays(-50) },
                new ServicePlan { ServicePlanId = 7, DateOfPurchase = DateTime.Now.AddDays(-40) },
                new ServicePlan { ServicePlanId = 8, DateOfPurchase = DateTime.Now.AddDays(-30) },
                new ServicePlan { ServicePlanId = 9, DateOfPurchase = DateTime.Now.AddDays(-25) },
                new ServicePlan { ServicePlanId = 10, DateOfPurchase = DateTime.Now.AddDays(-20) },
                new ServicePlan { ServicePlanId = 11, DateOfPurchase = DateTime.Now.AddDays(-15) },
                new ServicePlan { ServicePlanId = 12, DateOfPurchase = DateTime.Now.AddDays(-10) },
                new ServicePlan { ServicePlanId = 13, DateOfPurchase = DateTime.Now.AddDays(-5) },
                new ServicePlan { ServicePlanId = 14, DateOfPurchase = DateTime.Now.AddDays(-3) },
                new ServicePlan { ServicePlanId = 15, DateOfPurchase = DateTime.Now.AddDays(-1) }
            );

            // Seed data for Timesheet entities related to the above ServicePlans
            modelBuilder.Entity<Timesheet>().HasData(
                new Timesheet { TimesheetId = 1, ServicePlanId = 1, StartTime = DateTime.Now.AddDays(-99), EndTime = DateTime.Now.AddDays(-98), Description = "Timesheet 1 for ServicePlan 1" },
                new Timesheet { TimesheetId = 2, ServicePlanId = 1, StartTime = DateTime.Now.AddDays(-95), EndTime = DateTime.Now.AddDays(-94), Description = "Timesheet 2 for ServicePlan 1" },
                new Timesheet { TimesheetId = 3, ServicePlanId = 2, StartTime = DateTime.Now.AddDays(-89), EndTime = DateTime.Now.AddDays(-88), Description = "Timesheet 1 for ServicePlan 2" },
                new Timesheet { TimesheetId = 4, ServicePlanId = 2, StartTime = DateTime.Now.AddDays(-85), EndTime = DateTime.Now.AddDays(-84), Description = "Timesheet 2 for ServicePlan 2" },
                new Timesheet { TimesheetId = 5, ServicePlanId = 3, StartTime = DateTime.Now.AddDays(-79), EndTime = DateTime.Now.AddDays(-78), Description = "Timesheet 1 for ServicePlan 3" },
                new Timesheet { TimesheetId = 6, ServicePlanId = 4, StartTime = DateTime.Now.AddDays(-69), EndTime = DateTime.Now.AddDays(-68), Description = "Timesheet 1 for ServicePlan 4" },
                new Timesheet { TimesheetId = 7, ServicePlanId = 5, StartTime = DateTime.Now.AddDays(-59), EndTime = DateTime.Now.AddDays(-58), Description = "Timesheet 1 for ServicePlan 5" },
                new Timesheet { TimesheetId = 8, ServicePlanId = 6, StartTime = DateTime.Now.AddDays(-49), EndTime = DateTime.Now.AddDays(-48), Description = "Timesheet 1 for ServicePlan 6" },
                new Timesheet { TimesheetId = 9, ServicePlanId = 7, StartTime = DateTime.Now.AddDays(-39), EndTime = DateTime.Now.AddDays(-38), Description = "Timesheet 1 for ServicePlan 7" },
                new Timesheet { TimesheetId = 10, ServicePlanId = 8, StartTime = DateTime.Now.AddDays(-29), EndTime = DateTime.Now.AddDays(-28), Description = "Timesheet 1 for ServicePlan 8" },
                new Timesheet { TimesheetId = 11, ServicePlanId = 9, StartTime = DateTime.Now.AddDays(-24), EndTime = DateTime.Now.AddDays(-23), Description = "Timesheet 1 for ServicePlan 9" },
                new Timesheet { TimesheetId = 12, ServicePlanId = 10, StartTime = DateTime.Now.AddDays(-19), EndTime = DateTime.Now.AddDays(-18), Description = "Timesheet 1 for ServicePlan 10" },
                new Timesheet { TimesheetId = 13, ServicePlanId = 11, StartTime = DateTime.Now.AddDays(-14), EndTime = DateTime.Now.AddDays(-13), Description = "Timesheet 1 for ServicePlan 11" },
                new Timesheet { TimesheetId = 14, ServicePlanId = 12, StartTime = DateTime.Now.AddDays(-9), EndTime = DateTime.Now.AddDays(-8), Description = "Timesheet 1 for ServicePlan 12" },
                new Timesheet { TimesheetId = 15, ServicePlanId = 13, StartTime = DateTime.Now.AddDays(-4), EndTime = DateTime.Now.AddDays(-3), Description = "Timesheet 1 for ServicePlan 13" },
                new Timesheet { TimesheetId = 16, ServicePlanId = 14, StartTime = DateTime.Now.AddDays(-2), EndTime = DateTime.Now.AddDays(-1), Description = "Timesheet 1 for ServicePlan 14" },
                new Timesheet { TimesheetId = 17, ServicePlanId = 15, StartTime = DateTime.Now.AddHours(-10), EndTime = DateTime.Now.AddHours(-8), Description = "Timesheet 1 for ServicePlan 15" }
            );
        }
    }
}
