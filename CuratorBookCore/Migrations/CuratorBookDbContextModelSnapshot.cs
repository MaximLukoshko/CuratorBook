﻿// <auto-generated />
using CuratorBook.Models;
using CuratorBookCore.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CuratorBookCore.Migrations
{
    [DbContext(typeof(CuratorBookDbContext))]
    partial class CuratorBookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CuratorBookCore.Data.Tables.AnswerRows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FormId");

                    b.Property<int>("GroupId");

                    b.Property<bool>("ISHidden");

                    b.Property<bool>("IsFreezed");

                    b.HasKey("Id");

                    b.ToTable("AnswerRows");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Controls", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Controls");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Forms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.Property<int>("PageId");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.FormsControls", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerId")
                        .HasMaxLength(50);

                    b.Property<int>("ControlId");

                    b.Property<int>("FormId");

                    b.Property<int?>("FormsId");

                    b.HasKey("Id");

                    b.HasIndex("ControlId");

                    b.HasIndex("FormsId");

                    b.ToTable("FormsControls");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.FormsSchema.AnswerValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerRowsId");

                    b.Property<int>("ControlId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AnswerRowsId");

                    b.ToTable("AnswerValues");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Groups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Course");

                    b.Property<string>("GroupCode")
                        .HasMaxLength(10);

                    b.Property<int>("SpecialityId");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Interviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Messages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("NotifyViaEmail");

                    b.Property<int>("ReceiverGroupId");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("SentDate");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverGroupId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Pages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.PagesRights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PageId");

                    b.Property<int>("RightId");

                    b.Property<int?>("RolesId");

                    b.HasKey("Id");

                    b.HasIndex("RightId");

                    b.HasIndex("RolesId");

                    b.ToTable("PagesRights");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Rights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Rights");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.RolesRights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Permission");

                    b.Property<int>("RightId");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RightId");

                    b.ToTable("RolesRights");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Specialities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(30);

                    b.Property<int>("GroupId");

                    b.Property<string>("Login")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .HasMaxLength(20);

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.UsersRights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Permission");

                    b.Property<int>("RightId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RightId");

                    b.ToTable("UsersRights");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Forms", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Pages", "Page")
                        .WithMany("Forms")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.FormsControls", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Controls", "Type")
                        .WithMany()
                        .HasForeignKey("ControlId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CuratorBookCore.Data.Tables.Forms")
                        .WithMany("Controls")
                        .HasForeignKey("FormsId");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.FormsSchema.AnswerValues", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.AnswerRows")
                        .WithMany("Answers")
                        .HasForeignKey("AnswerRowsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Groups", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Specialities", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Messages", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Groups", "ReceiverGroup")
                        .WithMany()
                        .HasForeignKey("ReceiverGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CuratorBookCore.Data.Tables.Users", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CuratorBookCore.Data.Tables.Users", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.PagesRights", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Rights", "Right")
                        .WithMany()
                        .HasForeignKey("RightId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CuratorBookCore.Data.Tables.Roles")
                        .WithMany("Rights")
                        .HasForeignKey("RolesId");
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.RolesRights", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Rights", "Right")
                        .WithMany()
                        .HasForeignKey("RightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.Users", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Groups", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CuratorBookCore.Data.Tables.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CuratorBookCore.Data.Tables.UsersRights", b =>
                {
                    b.HasOne("CuratorBookCore.Data.Tables.Rights", "Right")
                        .WithMany()
                        .HasForeignKey("RightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
