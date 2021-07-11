using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DL.Entities
{
    public partial class DemoDBContext : DbContext
    {
        public DemoDBContext()
        {
        }

        public DemoDBContext(DbContextOptions<DemoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<LineItemOrder> LineItemOrders { get; set; }
        public virtual DbSet<LineItemProduct> LineItemProducts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }
        public virtual DbSet<StoreFrontLineItem> StoreFrontLineItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.Address)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ListofOrderId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ListofOrder_Id");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.Property(e => e.LineItemId).HasColumnName("LineItem_Id");

                entity.Property(e => e.Product)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineItemOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LineItem_Orders");

                entity.Property(e => e.LineItemOrdersId).HasColumnName("LineItem_Orders_Id");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.HasOne(d => d.LineItemOrders)
                    .WithMany()
                    .HasForeignKey(d => d.LineItemOrdersId)
                    .HasConstraintName("FK__LineItem___LineI__17F790F9");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__LineItem___Order__18EBB532");
            });

            modelBuilder.Entity<LineItemProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LineItem_Products");

                entity.Property(e => e.LineItemProductId).HasColumnName("LineItem_Product_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.LineItemProductNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.LineItemProductId)
                    .HasConstraintName("FK__LineItem___LineI__151B244E");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__LineItem___Produ__160F4887");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Order_Id");

                entity.Property(e => e.OrderLineItems)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Total_Price");

                entity.HasOne(d => d.OrderNavigation)
                    .WithOne(p => p.Order)
                    .HasForeignKey<Order>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("foreign_key_Customer");

                entity.HasOne(d => d.Order1)
                    .WithOne(p => p.Order)
                    .HasForeignKey<Order>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("foreign_key_StoreFront");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Product_Price");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__StoreFro__A0F15B61EE954E4D");

                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreId).HasColumnName("Store_Id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Inventory)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ListofOrderId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ListofOrder_Id");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreFrontLineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StoreFront_LineItems");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_Id");

                entity.Property(e => e.LineItemStoreId).HasColumnName("LineItem_Store_Id");

                entity.HasOne(d => d.LineItem)
                    .WithMany()
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK__StoreFron__LineI__1332DBDC");

                entity.HasOne(d => d.LineItemStore)
                    .WithMany()
                    .HasForeignKey(d => d.LineItemStoreId)
                    .HasConstraintName("FK__StoreFron__LineI__123EB7A3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
