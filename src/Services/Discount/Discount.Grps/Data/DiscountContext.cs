using Discount.Grps.Models;
using Microsoft.EntityFrameworkCore;

namespace Discount.Grps.Data;

public class DiscountContext : DbContext
{
    public DiscountContext(DbContextOptions option)
        : base(option)
    {
    }
    public DbSet<Coupon> Coupons { get; set; } = default;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon { Id = 1, ProductName = "IPhone X", Description = "IPhone Discount", Amount = 150 },
            new Coupon { Id = 2, ProductName = "Samsung 10", Description = "Samsung Discount", Amount = 100 }
            );
    }
}
