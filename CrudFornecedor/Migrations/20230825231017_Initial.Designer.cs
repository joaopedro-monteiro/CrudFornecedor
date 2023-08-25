﻿// <auto-generated />
using System;
using CrudFornecedor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudFornecedor.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230825231017_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudFornecedor.Models.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Cep")
                        .HasColumnType("bigint");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.Property<string>("EnderecoBairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoNumero")
                        .HasColumnType("int");

                    b.Property<string>("EnderecoRua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Especialidade")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });
#pragma warning restore 612, 618
        }
    }
}
