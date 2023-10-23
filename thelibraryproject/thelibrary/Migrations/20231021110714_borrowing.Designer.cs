﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using thelibrary.Data;

#nullable disable

namespace thelibrary.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20231021110714_borrowing")]
    partial class borrowing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("thelibrary.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("thelibrary.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActualBook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("thelibrary.Models.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("thelibrary.Models.BookReservation", b =>
                {
                    b.Property<int>("Resrvationid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Resrvationid"));

                    b.Property<DateTime>("Begins")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiresOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Resrvationid");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BookReservations");
                });

            modelBuilder.Entity("thelibrary.Models.BorrowBook", b =>
                {
                    b.Property<int>("BorrowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BorrowId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Booksborrowed");
                });

            modelBuilder.Entity("thelibrary.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserRoles", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        });
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserTokens", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokenMap", (string)null);
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+RoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 11,
                            ClaimType = "Permission",
                            ClaimValue = "ADD_BOOK_MANAGEMENT",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "Permission",
                            ClaimValue = "EDIT_BOOK_MANAGEMENT",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "Permission",
                            ClaimValue = "DELETE_BOOK_MANAGEMENT",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "Permission",
                            ClaimValue = "BORROW_BOOK_MANAGEMENT",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 15,
                            ClaimType = "Permission",
                            ClaimValue = "STUDENT_PAGE",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 16,
                            ClaimType = "Permission",
                            ClaimValue = "STUDENT_ADD_NEW",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 17,
                            ClaimType = "Permission",
                            ClaimValue = "STUDENT_ADD_TO_BATCH",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 18,
                            ClaimType = "Permission",
                            ClaimValue = "STUDENT_EDIT",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 19,
                            ClaimType = "Permission",
                            ClaimValue = "STUDENT_DEACTIVATE",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        },
                        new
                        {
                            Id = 20,
                            ClaimType = "Permission",
                            ClaimValue = "STUDENT_VIEW_DETAILS",
                            RoleId = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd")
                        });
                });

            modelBuilder.Entity("thelibrary.Models.Recommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserReview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("thelibrary.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("thelibrary.Models.SeatReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Begins")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiresOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("SeatStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("UserId");

                    b.ToTable("SeatReservation");
                });

            modelBuilder.Entity("thelibrary.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsInBuilt")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("UserRole", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                            ConcurrencyStamp = "3f2b89a20f98404ea7bd3e650b294b5f",
                            IsInBuilt = true,
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                            ConcurrencyStamp = "81a6f43e56484c6a9338400ac72af947",
                            IsInBuilt = true,
                            Name = "USER",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("thelibrary.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Activated")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPasswordDefault")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                            AccessFailedCount = 0,
                            Activated = false,
                            ConcurrencyStamp = "a0d7c411-ad40-49eb-82e3-38f67d1eef57",
                            CreatedOn = new DateTime(2023, 10, 21, 11, 7, 13, 873, DateTimeKind.Utc).AddTicks(6816),
                            Email = "orezioghene1@gmail.com",
                            EmailConfirmed = false,
                            IsDeleted = false,
                            IsPasswordDefault = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEN6ysxCmoXEsO27Waizg7doAAQtgW/YrfsbQrCC4A4Hpit2jJmpPtpwFBuEVS5/K+Q==",
                            PhoneNumber = "07055520420",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "17C89032-4965-4DCF-9DCF-B9F697D88820",
                            TwoFactorEnabled = false,
                            UserType = 0
                        },
                        new
                        {
                            Id = new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                            AccessFailedCount = 0,
                            Activated = true,
                            ConcurrencyStamp = "32c7e070-58f6-4422-859a-d3fc51e33500",
                            CreatedOn = new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eyiowuawibolutife@gmail.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            IsPasswordDefault = false,
                            LastLoginDate = new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "EYIOWUAWIBOLUTIFE@GMAIL.COM",
                            NormalizedUserName = "EYIOWUAWIBOLUTIFE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ23WLaNu1GlrPnjxBSdoqmLPQVn7m81G2c5OJYQKnNPhYed9tQjbs9toTBbu5jJMw==",
                            PhoneNumber = "07055520448",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "D21796E5-9EE1-4868-B217-C2E94B22CD22",
                            TwoFactorEnabled = false,
                            UserName = "eyiowuawibolutife@gmail.com",
                            UserType = 0
                        });
                });

            modelBuilder.Entity("thelibrary.Models.Book", b =>
                {
                    b.HasOne("thelibrary.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("thelibrary.Models.BookAuthor", b =>
                {
                    b.HasOne("thelibrary.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("thelibrary.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("thelibrary.Models.BookReservation", b =>
                {
                    b.HasOne("thelibrary.Models.Book", "Book")
                        .WithMany("BookReservations")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("thelibrary.Models.Users", "User")
                        .WithMany("BookReservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("thelibrary.Models.BorrowBook", b =>
                {
                    b.HasOne("thelibrary.Models.Book", "Book")
                        .WithMany("BookBorrowers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("thelibrary.Models.Users", "User")
                        .WithMany("BookBorrowers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserClaims", b =>
                {
                    b.HasOne("thelibrary.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserLogins", b =>
                {
                    b.HasOne("thelibrary.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserRoles", b =>
                {
                    b.HasOne("thelibrary.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("thelibrary.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+AppUserTokens", b =>
                {
                    b.HasOne("thelibrary.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("thelibrary.Models.IdentityModel+RoleClaims", b =>
                {
                    b.HasOne("thelibrary.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("thelibrary.Models.Recommendation", b =>
                {
                    b.HasOne("thelibrary.Models.Book", "Book")
                        .WithMany("Recommendations")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("thelibrary.Models.Users", "User")
                        .WithMany("Recommendations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("thelibrary.Models.SeatReservation", b =>
                {
                    b.HasOne("thelibrary.Models.Seat", "Seat")
                        .WithMany("SeatReservation")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("thelibrary.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("thelibrary.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("thelibrary.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookBorrowers");

                    b.Navigation("BookReservations");

                    b.Navigation("Recommendations");
                });

            modelBuilder.Entity("thelibrary.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("thelibrary.Models.Seat", b =>
                {
                    b.Navigation("SeatReservation");
                });

            modelBuilder.Entity("thelibrary.Models.Users", b =>
                {
                    b.Navigation("BookBorrowers");

                    b.Navigation("BookReservations");

                    b.Navigation("Recommendations");
                });
#pragma warning restore 612, 618
        }
    }
}
