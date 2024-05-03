﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using golf_scorecard.Data;

#nullable disable

namespace golf_scorecard.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240426120234_changed-db-layout")]
    partial class changeddblayout
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("golf_scorecard.Server.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nacka GK",
                            Par = 72
                        });
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Man"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Woman"
                        });
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.Hole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseRefId")
                        .HasColumnType("int");

                    b.Property<int>("HoleIndex")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseRefId");

                    b.ToTable("Holes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseRefId = 1,
                            HoleIndex = 10,
                            Number = 1,
                            Par = 4
                        },
                        new
                        {
                            Id = 2,
                            CourseRefId = 1,
                            HoleIndex = 6,
                            Number = 2,
                            Par = 3
                        },
                        new
                        {
                            Id = 3,
                            CourseRefId = 1,
                            HoleIndex = 14,
                            Number = 3,
                            Par = 5
                        },
                        new
                        {
                            Id = 4,
                            CourseRefId = 1,
                            HoleIndex = 4,
                            Number = 4,
                            Par = 4
                        },
                        new
                        {
                            Id = 5,
                            CourseRefId = 1,
                            HoleIndex = 8,
                            Number = 5,
                            Par = 5
                        },
                        new
                        {
                            Id = 6,
                            CourseRefId = 1,
                            HoleIndex = 18,
                            Number = 6,
                            Par = 3
                        },
                        new
                        {
                            Id = 7,
                            CourseRefId = 1,
                            HoleIndex = 2,
                            Number = 7,
                            Par = 4
                        },
                        new
                        {
                            Id = 8,
                            CourseRefId = 1,
                            HoleIndex = 16,
                            Number = 8,
                            Par = 4
                        },
                        new
                        {
                            Id = 9,
                            CourseRefId = 1,
                            HoleIndex = 12,
                            Number = 9,
                            Par = 3
                        },
                        new
                        {
                            Id = 10,
                            CourseRefId = 1,
                            HoleIndex = 11,
                            Number = 10,
                            Par = 4
                        },
                        new
                        {
                            Id = 11,
                            CourseRefId = 1,
                            HoleIndex = 13,
                            Number = 11,
                            Par = 5
                        },
                        new
                        {
                            Id = 12,
                            CourseRefId = 1,
                            HoleIndex = 3,
                            Number = 12,
                            Par = 4
                        },
                        new
                        {
                            Id = 13,
                            CourseRefId = 1,
                            HoleIndex = 9,
                            Number = 13,
                            Par = 3
                        },
                        new
                        {
                            Id = 14,
                            CourseRefId = 1,
                            HoleIndex = 1,
                            Number = 14,
                            Par = 4
                        },
                        new
                        {
                            Id = 15,
                            CourseRefId = 1,
                            HoleIndex = 17,
                            Number = 15,
                            Par = 4
                        },
                        new
                        {
                            Id = 16,
                            CourseRefId = 1,
                            HoleIndex = 15,
                            Number = 16,
                            Par = 3
                        },
                        new
                        {
                            Id = 17,
                            CourseRefId = 1,
                            HoleIndex = 5,
                            Number = 17,
                            Par = 5
                        },
                        new
                        {
                            Id = 18,
                            CourseRefId = 1,
                            HoleIndex = 7,
                            Number = 18,
                            Par = 4
                        });
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.SlopeRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("CR")
                        .HasColumnType("real");

                    b.Property<int>("CourseRefId")
                        .HasColumnType("int");

                    b.Property<int>("GenderRefId")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ScratchValue")
                        .HasColumnType("real");

                    b.Property<float>("Slope")
                        .HasColumnType("real");

                    b.Property<int>("TeeRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseRefId");

                    b.HasIndex("GenderRefId");

                    b.HasIndex("TeeRefId");

                    b.ToTable("SlopeRatings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CR = 69f,
                            CourseRefId = 1,
                            GenderRefId = 1,
                            Info = "Nacka Yellow Man",
                            ScratchValue = -2f,
                            Slope = 124f,
                            TeeRefId = 1
                        },
                        new
                        {
                            Id = 2,
                            CR = 65.3f,
                            CourseRefId = 1,
                            GenderRefId = 1,
                            Info = "Nacka Red Man",
                            ScratchValue = -5.7f,
                            Slope = 117f,
                            TeeRefId = 2
                        },
                        new
                        {
                            Id = 3,
                            CR = 74.5f,
                            CourseRefId = 1,
                            GenderRefId = 2,
                            Info = "Nacka Yellow Woman",
                            ScratchValue = 3.5f,
                            Slope = 131f,
                            TeeRefId = 1
                        },
                        new
                        {
                            Id = 4,
                            CR = 70f,
                            CourseRefId = 1,
                            GenderRefId = 2,
                            Info = "Nacka Red Woman",
                            ScratchValue = -1f,
                            Slope = 122f,
                            TeeRefId = 2
                        });
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.Tee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Tees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Yellow"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Red"
                        });
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.Hole", b =>
                {
                    b.HasOne("golf_scorecard.Server.Models.Course", "Course")
                        .WithMany("Holes")
                        .HasForeignKey("CourseRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.SlopeRating", b =>
                {
                    b.HasOne("golf_scorecard.Server.Models.Course", "Course")
                        .WithMany("SlopeRatings")
                        .HasForeignKey("CourseRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("golf_scorecard.Server.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("golf_scorecard.Server.Models.Tee", "Tee")
                        .WithMany()
                        .HasForeignKey("TeeRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Gender");

                    b.Navigation("Tee");
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.Tee", b =>
                {
                    b.HasOne("golf_scorecard.Server.Models.Course", null)
                        .WithMany("Tees")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("golf_scorecard.Server.Models.Course", b =>
                {
                    b.Navigation("Holes");

                    b.Navigation("SlopeRatings");

                    b.Navigation("Tees");
                });
#pragma warning restore 612, 618
        }
    }
}