﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalogAPI.Data;

namespace ProductCatalogAPI.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20190710020728_Intial")]
    partial class Intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.catalog_brand_hilo", "'catalog_brand_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_item_hilo", "'catalog_item_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_type_hilo", "'catalog_type_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCatalogAPI.Domain.CatalogBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_brand_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogBrands");
                });

            modelBuilder.Entity("ProductCatalogAPI.Domain.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_item_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("CatalogBrandId");

                    b.Property<int>("CatalogTypeId");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PictureUrl");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CatalogBrandId");

                    b.HasIndex("CatalogTypeId");

                    b.ToTable("CatalogItem");
                });

            modelBuilder.Entity("ProductCatalogAPI.Domain.CatalogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_type_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Catalogtype");
                });

            modelBuilder.Entity("ProductCatalogAPI.Domain.CatalogItem", b =>
                {
                    b.HasOne("ProductCatalogAPI.Domain.CatalogBrand", "CatalogBrand")
                        .WithMany()
                        .HasForeignKey("CatalogBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductCatalogAPI.Domain.CatalogType", "CatalogType")
                        .WithMany()
                        .HasForeignKey("CatalogTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
