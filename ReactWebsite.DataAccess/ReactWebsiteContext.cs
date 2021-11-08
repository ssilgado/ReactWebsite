using System.Reflection;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ReactWebsite.DataAccess.Entities;

#nullable disable

namespace ReactWebsite.DataAccess
{
    public partial class ReactWebsiteContext : DbContext
    {
        public ReactWebsiteContext()
        {
        }

        public ReactWebsiteContext(DbContextOptions<ReactWebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceProduct> InvoiceProducts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<State> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = @"Server=sqls-reactwebsite-cus-dev.database.windows.net; Initial Catalog=sqldb-reactwebsite-cus-dev; Authentication=Active Directory Default";
                optionsBuilder.UseSqlServer(new SqlConnection(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
