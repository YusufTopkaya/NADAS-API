﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;

#nullable disable

namespace Nadas.API.DataAccess.Migrations
{
    [DbContext(typeof(NadasContext))]
    [Migration("20221006130814_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(3301));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(3479));

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(4119));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(4225));

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(5346));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("Rate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(5456));

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(6313));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(6421));

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AuthLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("CreatedUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(7232));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(7326));

                    b.Property<int?>("UpdatedUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuestionTag", b =>
                {
                    b.Property<int>("QuestionsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("QuestionsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("QuestionTag");
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Answer", b =>
                {
                    b.HasOne("Nadas.API.Entities.Concrete.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nadas.API.Entities.Concrete.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");

                    b.HasOne("Nadas.API.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Content");

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Question", b =>
                {
                    b.HasOne("Nadas.API.Entities.Concrete.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.HasOne("Nadas.API.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Content");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuestionTag", b =>
                {
                    b.HasOne("Nadas.API.Entities.Concrete.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nadas.API.Entities.Concrete.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nadas.API.Entities.Concrete.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}