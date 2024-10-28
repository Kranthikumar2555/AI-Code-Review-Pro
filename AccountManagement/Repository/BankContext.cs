using CourseManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagement.Repository;

public class BankContext : DbContext
{
    public BankContext(DbContextOptions<BankContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<BankTransfer> BankTransfers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Customize your model if needed
        modelBuilder.Entity<Account>().ToTable("Accounts");
        modelBuilder.Entity<BankTransfer>().ToTable("BankTransfers");
    }
}
