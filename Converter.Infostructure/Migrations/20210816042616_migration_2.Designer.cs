﻿// <auto-generated />
using System;
using Converter.Infostructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Converter.Infostructure.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20210816042616_migration_2")]
    partial class migration_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Converter.Core.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ccy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CcyNm_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CcyNm_RU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CcyNm_UZ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CcyNm_UZC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<float>("Diff")
                        .HasColumnType("real");

                    b.Property<int>("Nominal")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Converter.Core.Entities.CurrencyConverter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("FirstCurrencyId")
                        .HasColumnType("int");

                    b.Property<double>("FirstSum")
                        .HasColumnType("float");

                    b.Property<int>("SecondCurrencyId")
                        .HasColumnType("int");

                    b.Property<double>("SecondSum")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("CurrencyConverters");
                });

            modelBuilder.Entity("Converter.Core.Entities.CurrencyConverter", b =>
                {
                    b.HasOne("Converter.Core.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.Navigation("Currency");
                });
#pragma warning restore 612, 618
        }
    }
}
