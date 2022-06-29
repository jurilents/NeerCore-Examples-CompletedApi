﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeniorTemplate.Data.Context;

#nullable disable

namespace SeniorTemplate.Data.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20220629094626_Test1")]
    partial class Test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppRefreshToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(46)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("AppRefreshTokens", (string)null);
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AppRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "c4837a69-90c9-425a-8c39-f569e669bfc6",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "b6b183d1-c8ab-491a-8370-51d205d2ad05",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permission",
                            ClaimValue = "mt",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AppUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f2c301a-77f6-4756-a97e-642274189c06",
                            Email = "aspadmin@asp.net",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ASPADMIN@ASP.NET",
                            NormalizedUserName = "ASPADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEG1N8nLfgGXAtY+27lBY5u4jjIeGCxCPtHne2qW+Yo65mfva7H819QEFXxPA954LKA==",
                            PhoneNumberConfirmed = false,
                            Registered = new DateTime(2022, 6, 29, 9, 46, 25, 945, DateTimeKind.Utc).AddTicks(9081),
                            SecurityStamp = "99b8df4f-4266-4851-85ee-5a2453f4ae70",
                            TwoFactorEnabled = false,
                            UserName = "aspadmin"
                        });
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permission",
                            ClaimValue = "*",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("smallint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.Tea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Updated")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ff57d179-490c-493a-bae5-407ff6eee180"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1014),
                            Name = "Earl Gray",
                            Price = 20m
                        },
                        new
                        {
                            Id = new Guid("f37435af-3dfe-44ff-8775-91ac440e2910"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1634),
                            Name = "Rose Tea",
                            Price = 20m
                        },
                        new
                        {
                            Id = new Guid("7a28ddd4-c32d-42ea-804a-22541d9d3823"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1636),
                            Name = "English Breakfast Tea",
                            Price = 18m
                        },
                        new
                        {
                            Id = new Guid("8634eb25-4064-4edf-a5ca-733b7067c5ac"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1638),
                            Name = "Big Sur Tea",
                            Price = 25m
                        },
                        new
                        {
                            Id = new Guid("056ac5af-30a6-4008-bdfe-17146ed91d6f"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1639),
                            Name = "Big Sur Tea",
                            Price = 25m
                        },
                        new
                        {
                            Id = new Guid("4d3275de-88c9-446d-b0cf-26e9f1879d22"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1640),
                            Name = "Jasmine Pearls",
                            Price = 41m
                        },
                        new
                        {
                            Id = new Guid("09c45f25-bfd4-4340-93a9-8a2ab708d92c"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1642),
                            Name = "Dragonwell",
                            Price = 30m
                        },
                        new
                        {
                            Id = new Guid("387a1501-cf68-4d64-945c-c616d071ab56"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1648),
                            Name = "White Peach Tea",
                            Price = 29m
                        },
                        new
                        {
                            Id = new Guid("bffacc17-0a97-41f8-ab91-b977f8be324b"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1649),
                            Name = "Vanilla Berry Tea",
                            Price = 21m
                        },
                        new
                        {
                            Id = new Guid("4c619acc-8b4b-4c61-a6c7-df965950df19"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1650),
                            Name = "Chaga Chai Mushroom Tea",
                            Price = 20m
                        },
                        new
                        {
                            Id = new Guid("5401fde4-68a6-4f42-9df5-71826b6d2bb1"),
                            Created = new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1651),
                            Name = "Naked Pu-erh Tea",
                            Price = 27m
                        });
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppRefreshToken", b =>
                {
                    b.HasOne("SeniorTemplate.Data.Entities.AppUser", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("SeniorTemplate.Data.Entities.AppRole", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserClaim", b =>
                {
                    b.HasOne("SeniorTemplate.Data.Entities.AppUser", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserLogin", b =>
                {
                    b.HasOne("SeniorTemplate.Data.Entities.AppUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserRole", b =>
                {
                    b.HasOne("SeniorTemplate.Data.Entities.AppRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorTemplate.Data.Entities.AppUser", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUserToken", b =>
                {
                    b.HasOne("SeniorTemplate.Data.Entities.AppUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppRole", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SeniorTemplate.Data.Entities.AppUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("RefreshTokens");

                    b.Navigation("Roles");

                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
