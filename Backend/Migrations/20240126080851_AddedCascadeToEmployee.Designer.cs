﻿// <auto-generated />
using System;
using Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240126080851_AddedCascadeToEmployee")]
    partial class AddedCascadeToEmployee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PayGradeId")
                        .HasColumnType("integer");

                    b.Property<int?>("PersonalInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("PayGradeId");

                    b.HasIndex("PersonalInfoId");

                    b.HasIndex("RoleId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Backend.Models.PayGrade", b =>
                {
                    b.Property<int>("PayGradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PayGradeId"));

                    b.Property<int>("PayAmount")
                        .HasColumnType("integer");

                    b.HasKey("PayGradeId");

                    b.ToTable("PayGrade");
                });

            modelBuilder.Entity("Backend.Models.Performance", b =>
                {
                    b.Property<int>("PerformanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PerformanceId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<float>("Sales")
                        .HasColumnType("real");

                    b.HasKey("PerformanceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Performance");
                });

            modelBuilder.Entity("Backend.Models.PersonalInfo", b =>
                {
                    b.Property<int>("PersonalInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PersonalInfoId"));

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("RoutingNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)");

                    b.HasKey("PersonalInfoId");

                    b.ToTable("PersonalInfo");
                });

            modelBuilder.Entity("Backend.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Backend.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScheduleId"));

                    b.Property<DateTime>("FridayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FridayStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("MondayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("MondayStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("SaturdayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("SaturdayStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("SundayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("SundayStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ThursdayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ThursdayStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("TuesdayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("TuesdayStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("WednesdayEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("WednesdayStart")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Backend.Models.TimeOffRequest", b =>
                {
                    b.Property<int>("TimeOffRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TimeOffRequestId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeOffDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TimeOffRequestId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TimeOffRequest");
                });

            modelBuilder.Entity("Backend.Models.Employee", b =>
                {
                    b.HasOne("Backend.Models.PayGrade", "PayGrade")
                        .WithMany()
                        .HasForeignKey("PayGradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId");

                    b.HasOne("Backend.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.Navigation("PayGrade");

                    b.Navigation("PersonalInfo");

                    b.Navigation("Role");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Backend.Models.Performance", b =>
                {
                    b.HasOne("Backend.Models.Employee", null)
                        .WithMany("Performance")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Backend.Models.TimeOffRequest", b =>
                {
                    b.HasOne("Backend.Models.Employee", "Employee")
                        .WithMany("TimeOffRequest")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Backend.Models.Employee", b =>
                {
                    b.Navigation("Performance");

                    b.Navigation("TimeOffRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
