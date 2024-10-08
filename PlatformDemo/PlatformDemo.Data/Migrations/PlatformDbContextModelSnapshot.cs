﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformDemo.Data.Data;

#nullable disable

namespace PlatformDemo.Data.Migrations
{
    [DbContext(typeof(PlatformDbContext))]
    partial class PlatformDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            ServicePlanId = 1,
                            DateOfPurchase = new DateTime(2024, 6, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8675)
                        },
                        new
                        {
                            ServicePlanId = 2,
                            DateOfPurchase = new DateTime(2024, 7, 10, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8691)
                        },
                        new
                        {
                            ServicePlanId = 3,
                            DateOfPurchase = new DateTime(2024, 7, 20, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8692)
                        },
                        new
                        {
                            ServicePlanId = 4,
                            DateOfPurchase = new DateTime(2024, 7, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8693)
                        },
                        new
                        {
                            ServicePlanId = 5,
                            DateOfPurchase = new DateTime(2024, 8, 9, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8694)
                        },
                        new
                        {
                            ServicePlanId = 6,
                            DateOfPurchase = new DateTime(2024, 8, 19, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8695)
                        },
                        new
                        {
                            ServicePlanId = 7,
                            DateOfPurchase = new DateTime(2024, 8, 29, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8696)
                        },
                        new
                        {
                            ServicePlanId = 8,
                            DateOfPurchase = new DateTime(2024, 9, 8, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8697)
                        },
                        new
                        {
                            ServicePlanId = 9,
                            DateOfPurchase = new DateTime(2024, 9, 13, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8698)
                        },
                        new
                        {
                            ServicePlanId = 10,
                            DateOfPurchase = new DateTime(2024, 9, 18, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8699)
                        },
                        new
                        {
                            ServicePlanId = 11,
                            DateOfPurchase = new DateTime(2024, 9, 23, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8700)
                        },
                        new
                        {
                            ServicePlanId = 12,
                            DateOfPurchase = new DateTime(2024, 9, 28, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8701)
                        },
                        new
                        {
                            ServicePlanId = 13,
                            DateOfPurchase = new DateTime(2024, 10, 3, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8702)
                        },
                        new
                        {
                            ServicePlanId = 14,
                            DateOfPurchase = new DateTime(2024, 10, 5, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8703)
                        },
                        new
                        {
                            ServicePlanId = 15,
                            DateOfPurchase = new DateTime(2024, 10, 7, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8705)
                        });
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

                    b.HasData(
                        new
                        {
                            TimesheetId = 1,
                            Description = "Timesheet 1 for ServicePlan 1",
                            EndTime = new DateTime(2024, 7, 2, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8820),
                            ServicePlanId = 1,
                            StartTime = new DateTime(2024, 7, 1, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8815)
                        },
                        new
                        {
                            TimesheetId = 2,
                            Description = "Timesheet 2 for ServicePlan 1",
                            EndTime = new DateTime(2024, 7, 6, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8822),
                            ServicePlanId = 1,
                            StartTime = new DateTime(2024, 7, 5, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8822)
                        },
                        new
                        {
                            TimesheetId = 3,
                            Description = "Timesheet 1 for ServicePlan 2",
                            EndTime = new DateTime(2024, 7, 12, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8824),
                            ServicePlanId = 2,
                            StartTime = new DateTime(2024, 7, 11, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8823)
                        },
                        new
                        {
                            TimesheetId = 4,
                            Description = "Timesheet 2 for ServicePlan 2",
                            EndTime = new DateTime(2024, 7, 16, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8826),
                            ServicePlanId = 2,
                            StartTime = new DateTime(2024, 7, 15, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8825)
                        },
                        new
                        {
                            TimesheetId = 5,
                            Description = "Timesheet 1 for ServicePlan 3",
                            EndTime = new DateTime(2024, 7, 22, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8834),
                            ServicePlanId = 3,
                            StartTime = new DateTime(2024, 7, 21, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8834)
                        },
                        new
                        {
                            TimesheetId = 6,
                            Description = "Timesheet 1 for ServicePlan 4",
                            EndTime = new DateTime(2024, 8, 1, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8836),
                            ServicePlanId = 4,
                            StartTime = new DateTime(2024, 7, 31, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8835)
                        },
                        new
                        {
                            TimesheetId = 7,
                            Description = "Timesheet 1 for ServicePlan 5",
                            EndTime = new DateTime(2024, 8, 11, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8838),
                            ServicePlanId = 5,
                            StartTime = new DateTime(2024, 8, 10, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8837)
                        },
                        new
                        {
                            TimesheetId = 8,
                            Description = "Timesheet 1 for ServicePlan 6",
                            EndTime = new DateTime(2024, 8, 21, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8839),
                            ServicePlanId = 6,
                            StartTime = new DateTime(2024, 8, 20, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8839)
                        },
                        new
                        {
                            TimesheetId = 9,
                            Description = "Timesheet 1 for ServicePlan 7",
                            EndTime = new DateTime(2024, 8, 31, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8841),
                            ServicePlanId = 7,
                            StartTime = new DateTime(2024, 8, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8841)
                        },
                        new
                        {
                            TimesheetId = 10,
                            Description = "Timesheet 1 for ServicePlan 8",
                            EndTime = new DateTime(2024, 9, 10, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8843),
                            ServicePlanId = 8,
                            StartTime = new DateTime(2024, 9, 9, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8842)
                        },
                        new
                        {
                            TimesheetId = 11,
                            Description = "Timesheet 1 for ServicePlan 9",
                            EndTime = new DateTime(2024, 9, 15, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8845),
                            ServicePlanId = 9,
                            StartTime = new DateTime(2024, 9, 14, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8844)
                        },
                        new
                        {
                            TimesheetId = 12,
                            Description = "Timesheet 1 for ServicePlan 10",
                            EndTime = new DateTime(2024, 9, 20, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8846),
                            ServicePlanId = 10,
                            StartTime = new DateTime(2024, 9, 19, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8846)
                        },
                        new
                        {
                            TimesheetId = 13,
                            Description = "Timesheet 1 for ServicePlan 11",
                            EndTime = new DateTime(2024, 9, 25, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8848),
                            ServicePlanId = 11,
                            StartTime = new DateTime(2024, 9, 24, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8847)
                        },
                        new
                        {
                            TimesheetId = 14,
                            Description = "Timesheet 1 for ServicePlan 12",
                            EndTime = new DateTime(2024, 9, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8850),
                            ServicePlanId = 12,
                            StartTime = new DateTime(2024, 9, 29, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8849)
                        },
                        new
                        {
                            TimesheetId = 15,
                            Description = "Timesheet 1 for ServicePlan 13",
                            EndTime = new DateTime(2024, 10, 5, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8851),
                            ServicePlanId = 13,
                            StartTime = new DateTime(2024, 10, 4, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8851)
                        },
                        new
                        {
                            TimesheetId = 16,
                            Description = "Timesheet 1 for ServicePlan 14",
                            EndTime = new DateTime(2024, 10, 7, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8853),
                            ServicePlanId = 14,
                            StartTime = new DateTime(2024, 10, 6, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8852)
                        },
                        new
                        {
                            TimesheetId = 17,
                            Description = "Timesheet 1 for ServicePlan 15",
                            EndTime = new DateTime(2024, 10, 7, 16, 4, 2, 57, DateTimeKind.Local).AddTicks(8855),
                            ServicePlanId = 15,
                            StartTime = new DateTime(2024, 10, 7, 14, 4, 2, 57, DateTimeKind.Local).AddTicks(8854)
                        });
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
