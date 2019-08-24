using FactoryMM.Models.CompanyPurchaseMm;
using FactoryMM.Models.CustomersOrderMm;
using FactoryMM.Models.CustommerMm;
using FactoryMM.Models.EmployeeMm;
using FactoryMM.Models.EmployeeMm.EmployeeCategoryMm;
using FactoryMM.Models.InventoryMm.MaterialInventoryMm;
using FactoryMM.Models.InventoryMm.ProductInventoryMm;
using FactoryMM.Models.ProductionMM;
using FactoryMM.Models.ReturnSels;
using FactoryMM.Models.SalesMm;
using FactoryMM.Models.SupplierMm;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<MaterialInventory> MaterialInventorys { get; set; }
        public DbSet<ProductInventory> ProductsInventorys { get; set; }
        public DbSet<CompanyPurchase> CompanyPurchases { get; set; }
        public DbSet<Production> Productions { get; set; }

        public DbSet<EmployeeCategory> EmployeeCategorys { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<Sales> Saleses { get; set; }

        public DbSet<ReturnSelse> ReturnSelses { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                modelBuilder.Seed();
        }
    }
}
