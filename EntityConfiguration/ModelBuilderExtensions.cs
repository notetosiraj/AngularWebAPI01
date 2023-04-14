using CRM01.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace CRM01.EntityConfiguration
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                Name = "Miller Cake",
                DisplayId = "Test001",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now,
            },
          new Employee
          {
              Id = 2,
              Name = "Gram Bell",
              DisplayId = "Test002",
              CreatedBy = 1,
              CreatedDate = DateTime.Now,
              ModifiedBy = 1,
              ModifiedDate = DateTime.Now,
          });
        }

    }
}
