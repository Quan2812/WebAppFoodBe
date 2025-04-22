using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Entitys
{
	public class Context : DbContext
	{
		public DbSet<Account> Accounts { get; set; }

		public DbSet<News> News { get; set; } // Thêm DbSet cho bảng Tin tức
		public DbSet<Decentralization> Decentralizations { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<ProductReview> ProductReviews { get; set; }

		public DbSet<OrderStatus> OrderStatuses { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<ServiceType> ServiceTypes { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<SevicerReview> SevicerReviews { get; set; }

		public DbSet<ReservationDetailsService> ReservationDetailsServices { get; set; }
		public DbSet<Booking> Bookings { get; set; }

		public DbSet<Payment> Payments { get; set; }
		public DbSet<PaymentOrder> PaymentOrders { get; set; }

		public DbSet<Contact> Contacts { get; set; }

		public DbSet<Info> Infos { get; set; }

		public DbSet<Slides> Slides { get; set; }
		public DbSet<Slide> Slide { get; set; }

		public DbSet<ImagePage> ImagePages { get; set; }

		public DbSet<Voucher> Vouchers { get; set; }
		public DbSet<VoucherUser> VoucherUsers { get; set; }

		public DbSet<Carts> Carts { get; set; }

		public DbSet<CartItem> CartItems { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Account>()
			.Property(a => a.CreatedAt)
			.HasDefaultValueSql("GETDATE()")
			.ValueGeneratedOnAdd();

			modelBuilder.Entity<Account>()
				.Property(a => a.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<News>()
			.Property(a => a.CreatedAt)
			.HasDefaultValueSql("GETDATE()")
			.ValueGeneratedOnAdd();

			modelBuilder.Entity<News>()
				.Property(a => a.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Decentralization>()
				.Property(d => d.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Decentralization>()
				.Property(d => d.UpdateAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<User>()
				.Property(u => u.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<User>()
				.Property(u => u.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Staff>()
				.Property(s => s.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Staff>()
				.Property(s => s.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<ProductType>()
				.Property(p => p.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<ProductType>()
				.Property(p => p.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Product>()
				.Property(p => p.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Product>()
				.Property(p => p.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<ProductImage>()
				.Property(p => p.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<ProductImage>()
				.Property(p => p.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<ProductReview>()
				.Property(p => p.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<ProductReview>()
				.Property(p => p.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<ReservationDetailsService>()
				.Property(r => r.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<ReservationDetailsService>()
				.Property(r => r.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Booking>()
				.Property(b => b.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Booking>()
				.Property(b => b.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Payment>()
				.Property(p => p.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Payment>()
				.Property(p => p.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Contact>()
				.Property(c => c.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Contact>()
				.Property(c => c.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Info>()
				.Property(i => i.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Info>()
				.Property(i => i.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Slides>()
				.Property(s => s.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Slides>()
				.Property(s => s.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<ImagePage>()
				.Property(i => i.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<ImagePage>()
				.Property(i => i.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<PaymentOrder>()
				.Property(p => p.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<PaymentOrder>()
				.Property(p => p.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Order>()
				.Property(o => o.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Order>()
				.Property(o => o.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Voucher>()
				.Property(v => v.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Voucher>()
				.Property(v => v.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<VoucherUser>()
				.Property(v => v.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<VoucherUser>()
				.Property(v => v.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();

			modelBuilder.Entity<Carts>()
				.Property(v => v.CreatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Carts>()
				.Property(v => v.UpdatedAt)
				.HasDefaultValueSql("GETDATE()")
				.ValueGeneratedOnUpdate();
		}



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("Server=localhost,1433; Database=quanbh; User Id=sa; Password=\"Quan@2812$\"; TrustServerCertificate=True; MultipleActiveResultSets=True;");
			optionsBuilder.UseSqlServer("Server=103.57.221.133,1433; Database=quanbh; User Id=sa; Password=1231234; TrustServerCertificate=True; MultipleActiveResultSets=True;");
			//optionsBuilder.UseSqlServer("Server=localhost,1433; Database=quanbh; User Id=sa; Password=1231234; TrustServerCertificate=True; MultipleActiveResultSets=True;");
		}
	}
}
