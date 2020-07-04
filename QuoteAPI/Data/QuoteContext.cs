using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Data
{
    public class QuoteContext : DbContext
    {
        public QuoteContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Client { get; set; }
        public DbSet<CodeCategory> CodeCategory { get; set; }
        public DbSet<CodeList> CodeList { get; set; }
        public DbSet<Drapery> Drapery { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<JobType> JobType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderdetail> PurchaseOrderdetail { get; set; }
        public DbSet<PurchaseStock> PurchaseStock { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierLogin> SupplierLogin { get; set; }
        public DbSet<SupplierOrder> SupplierOrder { get; set; }

    }
}
