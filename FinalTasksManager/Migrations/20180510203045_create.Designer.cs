﻿// <auto-generated />
using FinalTasksManager;
using FinalTasksManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FinalTasksManager.Migrations
{
    [DbContext(typeof(TasksContext))]
    [Migration("20180510203045_create")]
    partial class create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalTasksManager.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FinalTasksManager.Models.ProjectLock", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("LockDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("ProjectId");

                    b.ToTable("ProjectLock");
                });

            modelBuilder.Entity("FinalTasksManager.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Deadline");

                    b.Property<bool>("IsCompleted");

                    b.Property<int>("Priority");

                    b.Property<int>("ProjectId");

                    b.Property<int?>("TaskId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FinalTasksManager.Models.ProjectLock", b =>
                {
                    b.HasOne("FinalTasksManager.Models.Project", "Project")
                        .WithOne("Lock")
                        .HasForeignKey("FinalTasksManager.Models.ProjectLock", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalTasksManager.Models.Task", b =>
                {
                    b.HasOne("FinalTasksManager.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalTasksManager.Models.Task")
                        .WithMany("SubTasks")
                        .HasForeignKey("TaskId");
                });
#pragma warning restore 612, 618
        }
    }
}