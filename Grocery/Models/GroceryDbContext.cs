using Microsoft.EntityFrameworkCore;
using Online_Grocery.Entitities;
using Online_Grocey.Models;
using Online_Grocery.Models;

namespace Grocery.Models
{
    public class GroceryDbContext : DbContext
    {
        public GroceryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Compare> Compares { get; set; }
        public DbSet<CustomerReview> CustomerReviews { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserStatus> UserStatuss { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WishList> wishLists { get; set; }
        public DbSet<Online_Grocey.Models.OrderStatus> OrderStatus { get; set; } = default!;
        public DbSet<UserAccount> UserAccounts { get; set; }
          public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Online_Grocery.Models.LoginViewModel> LoginViewModel { get; set; } = default!;
        public DbSet<Online_Grocery.Models.RegistrationViewModel> RegistrationViewModel { get; set; } = default!;
       

    }
}
