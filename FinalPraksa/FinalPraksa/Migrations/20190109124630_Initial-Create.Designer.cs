﻿// <auto-generated />
using System;
using FinalPraksa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalPraksa.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190109124630_Initial-Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalPraksa.Models.Device", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("FinalPraksa.Models.DeviceType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceId");

                    b.Property<long?>("DeviceId1");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId1");

                    b.ToTable("DeviceTypes");
                });

            modelBuilder.Entity("FinalPraksa.Models.DeviceTypeProperty", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceTypeId");

                    b.Property<long>("DeviceTypeId1");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceTypeId1");

                    b.ToTable("DeviceTypeProperties");
                });

            modelBuilder.Entity("FinalPraksa.Models.DeviceType", b =>
                {
                    b.HasOne("FinalPraksa.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId1");
                });

            modelBuilder.Entity("FinalPraksa.Models.DeviceTypeProperty", b =>
                {
                    b.HasOne("FinalPraksa.Models.DeviceType", "DeviceType")
                        .WithMany()
                        .HasForeignKey("DeviceTypeId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}