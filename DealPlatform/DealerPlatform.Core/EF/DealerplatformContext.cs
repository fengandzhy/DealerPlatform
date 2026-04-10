using System;
using System.Collections.Generic;
using DealerPlatform.Demain.Domains;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace DealerPlatform.Core.EF;

public partial class DealerplatformContext : DbContext
{
    public DealerplatformContext()
    {
    }

    public DealerplatformContext(DbContextOptions<DealerplatformContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customerinvoice> Customerinvoices { get; set; }

    public virtual DbSet<Customerpwd> Customerpwds { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productphoto> Productphotos { get; set; }

    public virtual DbSet<Productsale> Productsales { get; set; }

    public virtual DbSet<Productsaleareadiff> Productsaleareadiffs { get; set; }

    public virtual DbSet<Saleorderdetail> Saleorderdetails { get; set; }

    public virtual DbSet<Saleordermaster> Saleordermasters { get; set; }

    public virtual DbSet<Saleorderprogress> Saleorderprogresses { get; set; }

    public virtual DbSet<Shoppingcart> Shoppingcarts { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;database=dealerplatform;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerNo).HasName("PRIMARY");

            entity
                .ToTable("customers")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_Customers_Id").IsUnique();

            entity.Property(e => e.CustomerNo).HasMaxLength(40);
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.AreaName).HasMaxLength(100);
            entity.Property(e => e.AreaNo).HasMaxLength(40);
            entity.Property(e => e.BankAccount).HasMaxLength(40);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BankNo).HasMaxLength(40);
            entity.Property(e => e.City).HasMaxLength(40);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerNote).HasMaxLength(500);
            entity.Property(e => e.Ein).HasMaxLength(40);
            entity.Property(e => e.Fax).HasMaxLength(40);
            entity.Property(e => e.FirstAreaName).HasMaxLength(100);
            entity.Property(e => e.FirstAreaNo).HasMaxLength(40);
            entity.Property(e => e.HeadImgUrl).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OpenId).HasMaxLength(40);
            entity.Property(e => e.OwnerWorkerName).HasMaxLength(100);
            entity.Property(e => e.OwnerWorkerNo).HasMaxLength(40);
            entity.Property(e => e.OwnerWorkerTel).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Province).HasMaxLength(40);
            entity.Property(e => e.Tel).HasMaxLength(40);
        });

        modelBuilder.Entity<Customerinvoice>(entity =>
        {
            entity.HasKey(e => new { e.CustomerNo, e.InvoiceNo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("customerinvoices")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_CustomerInvoices_Id").IsUnique();

            entity.Property(e => e.CustomerNo).HasMaxLength(40);
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceAccount).HasMaxLength(40);
            entity.Property(e => e.InvoiceAddress).HasMaxLength(100);
            entity.Property(e => e.InvoiceBank).HasMaxLength(100);
            entity.Property(e => e.InvoiceEin).HasMaxLength(40);
            entity.Property(e => e.InvoicePhone).HasMaxLength(40);
        });

        modelBuilder.Entity<Customerpwd>(entity =>
        {
            entity.HasKey(e => e.CustomerNo).HasName("PRIMARY");

            entity
                .ToTable("customerpwds")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_CustomerPwds_id").IsUnique();

            entity.Property(e => e.CustomerNo).HasMaxLength(40);
            entity.Property(e => e.CustomerPwd).HasMaxLength(40);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => new { e.SysNo, e.ProductNo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("products")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_Products_Id").IsUnique();

            entity.Property(e => e.SysNo).HasMaxLength(100);
            entity.Property(e => e.ProductNo).HasMaxLength(100);
            entity.Property(e => e.BelongTypeName).HasMaxLength(100);
            entity.Property(e => e.BelongTypeNo).HasMaxLength(40);
            entity.Property(e => e.Brand).HasMaxLength(100);
            entity.Property(e => e.Color).HasMaxLength(100);
            entity.Property(e => e.ColorPattern).HasMaxLength(100);
            entity.Property(e => e.Grade).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.Origin).HasMaxLength(100);
            entity.Property(e => e.Pattern).HasMaxLength(100);
            entity.Property(e => e.Process).HasMaxLength(100);
            entity.Property(e => e.ProductBzgg)
                .HasMaxLength(100)
                .HasColumnName("ProductBZGG");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.ProductNote).HasMaxLength(500);
            entity.Property(e => e.Specification).HasMaxLength(100);
            entity.Property(e => e.SurfaceMaterial).HasMaxLength(100);
            entity.Property(e => e.Thickness).HasMaxLength(100);
            entity.Property(e => e.TypeName).HasMaxLength(40);
            entity.Property(e => e.TypeNo).HasMaxLength(40);
            entity.Property(e => e.UnitName).HasMaxLength(100);
            entity.Property(e => e.UnitNo).HasMaxLength(100);
        });

        modelBuilder.Entity<Productphoto>(entity =>
        {
            entity.HasKey(e => e.ProductNo).HasName("PRIMARY");

            entity
                .ToTable("productphotos")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_ProductPhotos_Id").IsUnique();

            entity.Property(e => e.ProductNo).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductPhotoUrl).HasMaxLength(100);
            entity.Property(e => e.SysNo).HasMaxLength(40);
        });

        modelBuilder.Entity<Productsale>(entity =>
        {
            entity.HasKey(e => new { e.SysNo, e.ProductNo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("productsales")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_ProductSales_Id").IsUnique();

            entity.Property(e => e.SysNo).HasMaxLength(100);
            entity.Property(e => e.ProductNo).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StockNo).HasMaxLength(40);
        });

        modelBuilder.Entity<Productsaleareadiff>(entity =>
        {
            entity.HasKey(e => new { e.SysNo, e.ProductNo, e.StockNo, e.AreaNo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity
                .ToTable("productsaleareadiffs")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_ProductSaleAreaDiffs_Id").IsUnique();

            entity.Property(e => e.SysNo).HasMaxLength(100);
            entity.Property(e => e.ProductNo).HasMaxLength(100);
            entity.Property(e => e.StockNo).HasMaxLength(40);
            entity.Property(e => e.AreaNo).HasMaxLength(40);
            entity.Property(e => e.FirstAreaNo).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Saleorderdetail>(entity =>
        {
            entity.HasKey(e => e.SaleOrderGuid).HasName("PRIMARY");

            entity
                .ToTable("saleorderdetails")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_SaleOrderDetails_Id").IsUnique();

            entity.Property(e => e.SaleOrderGuid).HasMaxLength(40);
            entity.Property(e => e.CustomerNo).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InputDate).HasColumnType("datetime(3)");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.ProductNo).HasMaxLength(40);
            entity.Property(e => e.ProductPhotoUrl).HasMaxLength(200);
            entity.Property(e => e.SaleOrderNo).HasMaxLength(40);
        });

        modelBuilder.Entity<Saleordermaster>(entity =>
        {
            entity.HasKey(e => e.SaleOrderNo).HasName("PRIMARY");

            entity
                .ToTable("saleordermasters")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_SaleOrderMasters_Id").IsUnique();

            entity.Property(e => e.SaleOrderNo).HasMaxLength(40);
            entity.Property(e => e.CustomerNo).HasMaxLength(40);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime(3)");
            entity.Property(e => e.EditUserNo).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InputDate).HasColumnType("datetime(3)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(40);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.StockNo).HasMaxLength(40);
        });

        modelBuilder.Entity<Saleorderprogress>(entity =>
        {
            entity.HasKey(e => new { e.SaleOrderNo, e.ProgressGuid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("saleorderprogresses")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_SaleOrderProgresses_Id").IsUnique();

            entity.Property(e => e.SaleOrderNo).HasMaxLength(40);
            entity.Property(e => e.ProgressGuid).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StepName).HasMaxLength(100);
            entity.Property(e => e.StepTime).HasColumnType("datetime(3)");
        });

        modelBuilder.Entity<Shoppingcart>(entity =>
        {
            entity.HasKey(e => e.CartGuid).HasName("PRIMARY");

            entity
                .ToTable("shoppingcarts")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_ShoppingCarts_Id").IsUnique();

            entity.Property(e => e.CartGuid).HasMaxLength(40);
            entity.Property(e => e.CustomerNo).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductNo).HasMaxLength(40);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.StockNo).HasName("PRIMARY");

            entity
                .ToTable("stocks")
                .UseCollation("utf8mb4_0900_ai_ci");

            entity.HasIndex(e => e.Id, "UK_Stocks_Id").IsUnique();

            entity.Property(e => e.StockNo).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StockLinkman).HasMaxLength(40);
            entity.Property(e => e.StockName).HasMaxLength(100);
            entity.Property(e => e.StockPhone).HasMaxLength(40);
            entity.Property(e => e.StockTel).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
