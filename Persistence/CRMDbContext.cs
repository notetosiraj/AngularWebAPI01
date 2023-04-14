using CRM01.Core.Model;
using CRM01.EntityConfiguration;
using CRM01.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using System.Data.Entity;

namespace CRM01.Persistence
{
    public class CRMDbContext : DbContext
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {
            //using (var context = new CRMDbContext(options))
            //{
            //    context.Database.EnsureCreated();
            //}
        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            new EmployeeEntityTypeConfiguration().Configure(modelbuilder.Entity<Employee>());
            modelbuilder.Seed();
        }

    }
}
