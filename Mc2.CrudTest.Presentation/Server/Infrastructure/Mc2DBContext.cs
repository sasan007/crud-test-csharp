using Mc2.CrudTest.Presentation.Server.Domain.Customer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mc2.CrudTest.Presentation.Server.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

    }
}
