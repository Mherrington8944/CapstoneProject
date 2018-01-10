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
    [Migration("20180102022217_dateagain")]
    partial class dateagain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProcessAPI.Models.Exam", b =>
                {
                    b.Property<int>("ExamID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExamName");

                    b.HasKey("ExamID");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("ProcessAPI.Models.Finished", b =>
                {
                    b.Property<int>("FinishedID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CompletionTime");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("StudentNumber");

                    b.HasKey("FinishedID");

                    b.ToTable("Finished");
                });

            modelBuilder.Entity("ProcessAPI.Models.Process", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("ExamName");

                    b.Property<string>("ExamNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("ProcessID");

                    b.Property<string>("ProcessName");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("StudentNumber");

                    b.Property<string>("WindowName");

                    b.HasKey("ID");

                    b.ToTable("Process");
                });

            modelBuilder.Entity("ProcessAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("StudentNumber");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ProcessAPI.Models.StudentExam", b =>
                {
                    b.Property<int>("StudentExamID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BaseURL");

                    b.Property<int?>("ExamID");

                    b.Property<int?>("FinishedID");

                    b.Property<string>("ProcessID");

                    b.Property<string>("ProcessName");

                    b.Property<int?>("StudentID");

                    b.HasKey("StudentExamID");

                    b.HasIndex("ExamID");

                    b.HasIndex("FinishedID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentExam");
                });

            modelBuilder.Entity("ProcessAPI.Models.TimeFrame", b =>
                {
                    b.Property<int>("TimeFrameID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("FullURL");

                    b.Property<DateTime>("StartTime");

                    b.Property<int?>("StudentExamID");

                    b.Property<string>("TabTitle");

                    b.Property<string>("WindowName");

                    b.HasKey("TimeFrameID");

                    b.HasIndex("StudentExamID");

                    b.ToTable("TimeFrame");
                });

            modelBuilder.Entity("ProcessAPI.Models.StudentExam", b =>
                {
                    b.HasOne("ProcessAPI.Models.Exam")
                        .WithMany("StudentExam")
                        .HasForeignKey("ExamID");

                    b.HasOne("ProcessAPI.Models.Finished")
                        .WithMany("StudentExam")
                        .HasForeignKey("FinishedID");

                    b.HasOne("ProcessAPI.Models.Student")
                        .WithMany("StudentExam")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("ProcessAPI.Models.TimeFrame", b =>
                {
                    b.HasOne("ProcessAPI.Models.StudentExam")
                        .WithMany("TimeFrame")
                        .HasForeignKey("StudentExamID");
                });
#pragma warning restore 612, 618
        }
    }
}
