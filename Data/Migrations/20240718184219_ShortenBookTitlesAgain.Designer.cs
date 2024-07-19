﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using code_assessment_api.Data;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240718184219_ShortenBookTitlesAgain")]
    partial class ShortenBookTitlesAgain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("code_assessment_api.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBestSeller")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNewArrival")
                        .HasColumnType("bit");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Emanuel Larkin",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ex doloremque et voluptas. Et optio et aut delectus illo recusandae. Ullam incidunt quia et. Sequi ut occaecati ut illum voluptas repellendus quia quos aliquid. Ea qui itaque non dicta quia.",
                            GenreId = 4,
                            ISBN = "058ab78c-ac96-b13b-d0c9-53b754d82bd3",
                            Image = "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 483,
                            Publisher = "Carter, Dach and Kulas",
                            Title = "Minus consectetur ex.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        },
                        new
                        {
                            Id = 2,
                            Author = "Edmond Raynor",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Reiciendis debitis consequatur dolores omnis illum debitis voluptatem. Rerum nemo aspernatur soluta. Ab excepturi dolorem et tempora. Harum ipsam voluptate harum. Eius ab culpa repudiandae.",
                            GenreId = 2,
                            ISBN = "d08d32a5-6b13-69c5-9797-c66cc82a1aa3",
                            Image = "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 113,
                            Publisher = "Bosco, Franecki and Gusikowski",
                            Title = "Eveniet nam odit.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            Author = "Adella Upton",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sed molestiae aliquam exercitationem earum ipsum. Maxime dolor modi qui aut labore sit natus exercitationem et. Architecto at enim autem reprehenderit delectus placeat et. Modi sint molestiae et fugiat vitae quaerat quos.",
                            GenreId = 5,
                            ISBN = "1ed4ecad-0bf1-4cf4-4dd9-03bd4d28e9bb",
                            Image = "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 432,
                            Publisher = "Hane - Koepp",
                            Title = "In velit recusandae.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            Author = "Allan Kuhn",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ipsa ut velit dignissimos magnam illo. Accusantium ea ea quia et ad voluptatem. Qui blanditiis aut accusantium placeat. Iste asperiores velit et sit unde non ullam odio. Qui libero repellendus quo non.",
                            GenreId = 3,
                            ISBN = "545592bd-2533-5e3e-c259-e9974db4012f",
                            Image = "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 454,
                            Publisher = "Langworth - Rowe",
                            Title = "Eaque enim consequatur.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2024
                        },
                        new
                        {
                            Id = 5,
                            Author = "Denis Lebsack",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rerum corporis nulla nam et quos harum sapiente. Est perspiciatis fuga quaerat. Nesciunt voluptatem atque dolores esse nulla perspiciatis omnis. Provident facere autem iure dolor cumque tenetur odit. Repudiandae voluptates tempora qui sit consectetur commodi.",
                            GenreId = 4,
                            ISBN = "ddba81b5-0ff8-bfb0-6bff-f1e0ca1a4ce7",
                            Image = "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 295,
                            Publisher = "Grant LLC",
                            Title = "Reiciendis inventore ipsa.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        },
                        new
                        {
                            Id = 6,
                            Author = "Tiffany Wiegand",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rerum ut aut mollitia iusto ab. Officia excepturi reiciendis velit eos corporis enim. Velit fuga quia sapiente. Voluptates velit temporibus velit dolorem architecto. Deleniti repudiandae quia dicta dignissimos.",
                            GenreId = 4,
                            ISBN = "8e1b48f7-4c54-6355-8206-fc70f2463d03",
                            Image = "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 394,
                            Publisher = "Schmeler and Sons",
                            Title = "Est vero quis.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2024
                        },
                        new
                        {
                            Id = 7,
                            Author = "Kamille Mills",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Est non delectus non laudantium reprehenderit sed veniam rem. Eligendi sit nulla numquam. Eveniet voluptatibus mollitia et. In nihil qui repellat. Sunt quod vel dolorum quas ut quod et ut.",
                            GenreId = 5,
                            ISBN = "abba7ad0-2410-82a9-449b-9aff76b6104f",
                            Image = "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 193,
                            Publisher = "Ruecker - Parisian",
                            Title = "Hic atque quia.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        },
                        new
                        {
                            Id = 8,
                            Author = "Garrison Powlowski",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ut recusandae iure itaque consequatur incidunt mollitia. Natus suscipit et fuga. Excepturi voluptatibus ipsa est mollitia nobis numquam.",
                            GenreId = 3,
                            ISBN = "ba87dbca-9f06-e10f-cf49-3c72b7a0415d",
                            Image = "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 113,
                            Publisher = "Kiehn, Crona and Donnelly",
                            Title = "Doloribus corporis sequi.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2024
                        },
                        new
                        {
                            Id = 9,
                            Author = "Tyson Howe",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ut at et voluptas perferendis. In atque labore nobis molestiae harum assumenda dicta aut ipsum. Aliquam possimus quisquam. Consectetur dignissimos modi voluptatem placeat doloremque repudiandae in ut et. Fugiat mollitia quaerat sed tempora ex mollitia harum ullam. Voluptatem reiciendis a sint soluta.",
                            GenreId = 1,
                            ISBN = "de7ee96c-5221-e695-190d-a73dbffdd6fb",
                            Image = "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 460,
                            Publisher = "Jacobi - Schulist",
                            Title = "Pariatur consequatur rerum.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        },
                        new
                        {
                            Id = 10,
                            Author = "Mack Tremblay",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In itaque facilis molestiae repellat facilis. Illo et totam expedita nemo consequatur. Consectetur ut qui ut non maxime est accusamus. Nam ullam alias saepe ipsa ipsa consequuntur.",
                            GenreId = 1,
                            ISBN = "a588ed65-84c5-0e9f-eafb-480b6d7b7c70",
                            Image = "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000",
                            IsBestSeller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Pages = 268,
                            Publisher = "Kris and Sons",
                            Title = "Labore itaque qui.",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Year = 2023
                        });
                });

            modelBuilder.Entity("code_assessment_api.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Non-Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Self-Help"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Cookbook"
                        });
                });

            modelBuilder.Entity("code_assessment_api.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("First")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("code_assessment_api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("code_assessment_api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("code_assessment_api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("code_assessment_api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("code_assessment_api.Models.Book", b =>
                {
                    b.HasOne("code_assessment_api.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("code_assessment_api.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
