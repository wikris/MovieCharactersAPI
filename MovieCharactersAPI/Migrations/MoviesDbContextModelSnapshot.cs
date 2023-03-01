﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCharactersAPI.Models;

#nullable disable

namespace MovieCharactersAPI.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    partial class MoviesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieCharacter", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("MovieCharacter");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CharacterId = 2
                        },
                        new
                        {
                            MovieId = 2,
                            CharacterId = 1
                        },
                        new
                        {
                            MovieId = 3,
                            CharacterId = 1
                        },
                        new
                        {
                            MovieId = 4,
                            CharacterId = 3
                        },
                        new
                        {
                            MovieId = 4,
                            CharacterId = 4
                        },
                        new
                        {
                            MovieId = 4,
                            CharacterId = 5
                        },
                        new
                        {
                            MovieId = 4,
                            CharacterId = 6
                        });
                });

            modelBuilder.Entity("MovieCharactersAPI.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alias")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Spider Ham",
                            Gender = "Pig",
                            Name = "Peter Porker",
                            Picture = "https://www.shutterstock.com/image-vector/cartoon-pig-thumb-up-vector-260nw-277426448.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Harry Plopper",
                            Gender = "Pig",
                            Name = "Harry Porker",
                            Picture = "https://static.simpsonswiki.com/images/7/7a/Plopper.png"
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Peter",
                            Gender = "Pig",
                            Name = "Peter Griffin",
                            Picture = "https://static.wikia.nocookie.net/familyguy/images/a/aa/FamilyGuy_Single_PeterDrink_R7.jpg/revision/latest/scale-to-width-down/1000?cb=20200526171842"
                        },
                        new
                        {
                            Id = 4,
                            Alias = "Lois",
                            Gender = "Female",
                            Name = "Lois Griffin",
                            Picture = "https://static.wikia.nocookie.net/familyguy/images/7/7c/FamilyGuy_Single_LoisPose_R7.jpg/revision/latest/scale-to-width-down/1000?cb=20200526171843"
                        },
                        new
                        {
                            Id = 5,
                            Alias = "Meg",
                            Gender = "Unknown",
                            Name = "Meg Griffin",
                            Picture = "https://static.wikia.nocookie.net/familyguy/images/1/1b/FamilyGuy_Single_MegMakeup_R7.jpg/revision/latest/scale-to-width-down/350?cb=20200526171840"
                        },
                        new
                        {
                            Id = 6,
                            Alias = "Chris",
                            Gender = "Male",
                            Name = "Chris Griffin",
                            Picture = "https://static.wikia.nocookie.net/familyguy/images/e/ee/FamilyGuy_Single_ChrisText_R7.jpg/revision/latest/scale-to-width-down/350?cb=20200526171839"
                        });
                });

            modelBuilder.Entity("MovieCharactersAPI.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Franchises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Marvel Cinematic Universe (MCU) is an American media franchise.",
                            Name = "Marvel Cinematic Universe"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Funny cartoons for family.",
                            Name = "Family Guy"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Funny cartoons for family.",
                            Name = "The Simpsons"
                        });
                });

            modelBuilder.Entity("MovieCharactersAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Kristian Wink",
                            FranchiseId = 3,
                            Genre = "Sci-fi, Fantasy, Food",
                            Picture = "https://static.simpsonswiki.com/images/archive/7/7a/20110905195950%21Plopper.png",
                            ReleaseYear = 2099,
                            Title = "Harry Plopper and the bacon in the owen",
                            Trailer = "https://www.youtube.com/watch?v=MQBUfxrDN4Q&themeRefresh=1"
                        },
                        new
                        {
                            Id = 2,
                            Director = "Marco Angeli",
                            FranchiseId = 1,
                            Genre = "Sci-fi, Fantasy, Horror",
                            Picture = "https://static.wikia.nocookie.net/marveldatabase/images/f/f6/Spider-Ham_Vol_1_1_Textless.jpg/revision/latest/scale-to-width-down/1000?cb=20190911100619",
                            ReleaseYear = 2080,
                            Title = "Spider-Ham: Caught in a Ham",
                            Trailer = "https://www.youtube.com/watch?v=MY15_rcd-IQ"
                        },
                        new
                        {
                            Id = 3,
                            Director = "Marco Angeli",
                            FranchiseId = 1,
                            Genre = "Sci-fi, Fantasy, Horror",
                            Picture = "http://www.localhero.org.uk/wp-content/uploads/2011/06/ringohamblack.jpg",
                            ReleaseYear = 2081,
                            Title = "Spider-Ham 2: Revenge of the pork",
                            Trailer = "https://www.youtube.com/watch?v=MY15_rcd-IQ"
                        },
                        new
                        {
                            Id = 4,
                            Director = "Greg Colton",
                            FranchiseId = 2,
                            Genre = "Animation, Comedy",
                            Picture = "https://www.wired.com/images_blogs/underwire/2009/12/familyguy_somethingsomethin.jpg",
                            ReleaseYear = 2080,
                            Title = "Family Guy: Star wars",
                            Trailer = "https://www.imdb.com/video/vi4188209433/?playlistId=tt0888817&ref_=tt_pr_ov_vi"
                        });
                });

            modelBuilder.Entity("MovieCharacter", b =>
                {
                    b.HasOne("MovieCharactersAPI.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieCharactersAPI.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieCharactersAPI.Models.Movie", b =>
                {
                    b.HasOne("MovieCharactersAPI.Models.Franchise", "Franchise")
                        .WithMany("Movies")
                        .HasForeignKey("FranchiseId");

                    b.Navigation("Franchise");
                });

            modelBuilder.Entity("MovieCharactersAPI.Models.Franchise", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
