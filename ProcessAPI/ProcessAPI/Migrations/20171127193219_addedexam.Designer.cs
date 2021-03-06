﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProcessAPI.Models;
using System;

namespace ProcessAPI.Migrations
{
    [DbContext(typeof(ProcessContext))]
    [Migration("20171127193219_addedexam")]
    partial class addedexam
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProcessAPI.Models.Exam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExamName");

                    b.HasKey("ID");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("ProcessAPI.Models.Process", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExamName");

                    b.Property<int>("ExamNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("ProcessID");

                    b.Property<string>("ProcessName");

                    b.Property<int>("StudentNumber");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("WindowName");

                    b.HasKey("ID");

                    b.ToTable("Process");
                });

            modelBuilder.Entity("ProcessAPI.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
