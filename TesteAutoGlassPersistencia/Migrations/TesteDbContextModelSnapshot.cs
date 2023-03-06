﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteAutoGlassPersistencia.Padrao;

#nullable disable

namespace TesteAutoGlassPersistencia.Migrations
{
    [DbContext(typeof(TesteDbContext))]
    partial class TesteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TesteAutoGlassPersistencia.Model.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"));

                    b.Property<string>("CNPJFornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodigoFornecedor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataValidade")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoFornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Situacao")
                        .HasColumnType("bit");

                    b.HasKey("Codigo");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
