﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformDemo.Data.Data;

#nullable disable

namespace PlatformDemo.Data.Migrations
{
    [DbContext(typeof(PlatformDbContext))]
    [Migration("20241007154029_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlatformDemo.Data.Models.ServicePlan", b =>
                {
                    b.Property<int>("ServicePlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicePlanId"));

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.HasKey("ServicePlanId");

                    b.ToTable("ServicePlans");
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Timesheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimesheetId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicePlanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("TimesheetId");

                    b.HasIndex("ServicePlanId");

                    b.ToTable("Timesheets");
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Timesheet", b =>
                {
                    b.HasOne("PlatformDemo.Data.Models.ServicePlan", "ServicePlan")
                        .WithMany("Timesheets")
                        .HasForeignKey("ServicePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServicePlan");
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.ServicePlan", b =>
                {
                    b.Navigation("Timesheets");
                });
#pragma warning restore 612, 618
        }
    }
}
