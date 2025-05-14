using System;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_QLKS.Models;

public partial class QlkhachsanContext : DbContext
{
    public QlkhachsanContext() { }

    public QlkhachsanContext(DbContextOptions<QlkhachsanContext> options)
        : base(options) { }

    public virtual DbSet<Booking> Bookings { get; set; }
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<Permission> Permissions { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Room> Rooms { get; set; }
    public virtual DbSet<Service> Services { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<RolePermission> Role_Permissions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
#warning Move connection string out of source code. Use appsettings.json or environment variables instead.
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=DANIEL-PHUNG;Initial Catalog=QLKHACHSAN;Integrated Security=True;Trust Server Certificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureBooking(modelBuilder);
        ConfigureBranch(modelBuilder);
        ConfigureCustomer(modelBuilder);
        ConfigureOrder(modelBuilder);
        ConfigurePayment(modelBuilder);
        ConfigurePermission(modelBuilder);
        ConfigureRole(modelBuilder);
        ConfigureRoom(modelBuilder);
        ConfigureService(modelBuilder);
        ConfigureUser(modelBuilder);
        ConfigureRolePermission(modelBuilder);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    private void ConfigureBooking(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId);

            entity.ToTable("BOOKINGS");

            entity.Property(e => e.CheckInDate).HasColumnType("datetime");
            entity.Property(e => e.CheckOutDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Room)
                .WithMany(p => p.Bookings)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
    }

    private void ConfigureBranch(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId);
            entity.ToTable("BRANCHES");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });
    }

    private void ConfigureCustomer(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId);
            entity.ToTable("CUSTOMERS");

            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IdentityCard).HasMaxLength(20);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });
    }

    private void ConfigureOrder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId);
            entity.ToTable("ORDERS");

            entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Booking)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.BookingId);

            entity.HasOne(d => d.Service)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
    }

    private void ConfigurePayment(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId);
            entity.ToTable("PAYMENTS");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus).HasMaxLength(20);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalRoomPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalServicePrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Booking)
                .WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.CreatedByNavigation)
                .WithMany(p => p.Payments)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
    }

    private void ConfigurePermission(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PermissionId);
            entity.ToTable("PERMISSIONS");

            entity.Property(e => e.PermissionName).HasMaxLength(100);
        });
    }

    private void ConfigureRole(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId);
            entity.ToTable("ROLES");

            entity.Property(e => e.RoleName).HasMaxLength(50);
        });
    }

    private void ConfigureRoom(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId);
            entity.ToTable("ROOMS");

            entity.Property(e => e.RoomNumber).HasMaxLength(10);
            entity.Property(e => e.RoomType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.PricePerDay).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Branch)
                .WithMany(p => p.Rooms)
                .HasForeignKey(d => d.BranchId);
        });
    }

    private void ConfigureService(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId);
            entity.ToTable("SERVICES");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });
    }

    private void ConfigureUser(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId);
            entity.ToTable("USERS");

            entity.HasIndex(e => e.Username).IsUnique();

            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);

            entity.HasOne(d => d.Branch)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
    }

    private void ConfigureRolePermission(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.ToTable("ROLE_PERMISSIONS");

            entity.HasKey(e => new { e.RoleId, e.PermissionId });

            entity.HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleId)
                .HasConstraintName("FK__ROLE_PERM__RoleI__4D94879B");

            entity.HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionId)
                .HasConstraintName("FK__ROLE_PERM__Permi__4E88ABD4");
        });
    }
}
