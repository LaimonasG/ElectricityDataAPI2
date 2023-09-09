﻿// <auto-generated />
using System;
using Girteka_task.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Girteka_task.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230829170628_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Girteka_task.data.entities.NetworkObjectData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Network")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Object_GV_Type")
                        .HasColumnType("int");

                    b.Property<int>("Object_Number")
                        .HasColumnType("int");

                    b.Property<int>("Object_Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("PL_T")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Pminus")
                        .HasColumnType("float");

                    b.Property<double?>("Pplus")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Objects");
                });
#pragma warning restore 612, 618
        }
    }
}
