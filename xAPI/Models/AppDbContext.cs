using Microsoft.EntityFrameworkCore;
using xAPI.Models;

namespace xAPI.Models
{
    // class: AppDbContext | tables to migrate/update in database
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CustomerDetailsModel> Customers { get; set; }
        public DbSet<InvoiceDetailsModel> Invoices { get; set; }
        public DbSet<InventoryDetailsModel> Inventory { get; set; }
        public DbSet<InvoiceItemDetailsModel> InvoiceItems { get; set; }
        public DbSet<InventoryItemDetailsModel> InventoryItems { get; set; }
        public DbSet<EmployeeDetailsModel> Employees {get; set;}
    }
}