﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RDSAMR.Infrastructure;

namespace RDSAMR.Infrastructure.Migrations
{
    [DbContext(typeof(RDSAMRContext))]
    partial class RDSAMRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RDSAMR.Domain.Entities.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("CityTbl");
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("UpdatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CountryID");

                    b.ToTable("CountryTbl");
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.Role", b =>
                {
                    b.Property<long>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoleID");

                    b.ToTable("RoleTbl");

                    b.HasData(
                        new
                        {
                            RoleID = 1L,
                            IsDeleted = false,
                            RoleName = "SuperAdmin"
                        },
                        new
                        {
                            RoleID = 2L,
                            IsDeleted = false,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleID = 3L,
                            IsDeleted = false,
                            RoleName = "Staff"
                        },
                        new
                        {
                            RoleID = 4L,
                            IsDeleted = false,
                            RoleName = "Consumer"
                        });
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("StateTbl");
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.User", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID");

                    b.ToTable("UserTbl");

                    b.HasData(
                        new
                        {
                            UserID = 1L,
                            Address = "Akurdi",
                            EmailID = "achyut.kendre@gmail.com",
                            FirstName = "Achyut",
                            IsDeleted = false,
                            LastName = "Kendre",
                            MobileNo = "89894545898",
                            PasswordHash = "AMR2006"
                        });
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.UserRole", b =>
                {
                    b.Property<long>("UserRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("RoleID")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("UserRoleID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoleTbl");

                    b.HasData(
                        new
                        {
                            UserRoleID = 1L,
                            IsDeleted = false,
                            RoleID = 1L,
                            UserID = 1L
                        });
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.City", b =>
                {
                    b.HasOne("RDSAMR.Domain.Entities.State", "State")
                        .WithMany("City")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.State", b =>
                {
                    b.HasOne("RDSAMR.Domain.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RDSAMR.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("RDSAMR.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RDSAMR.Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
