using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServicePlans",
                columns: new[] { "ServicePlanId", "DateOfPurchase" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 29, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4590) },
                    { 2, new DateTime(2024, 8, 18, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4605) },
                    { 3, new DateTime(2024, 9, 12, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4606) },
                    { 4, new DateTime(2024, 9, 27, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4607) },
                    { 5, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4608) },
                    { 6, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4609) },
                    { 7, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4610) },
                    { 8, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4611) },
                    { 9, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4612) },
                    { 10, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4613) },
                    { 11, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4614) },
                    { 12, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4615) },
                    { 13, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4616) },
                    { 14, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4617) },
                    { 15, new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4618) },
                });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "Description", "EndTime", "ServicePlanId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Timesheet 1 for ServicePlan 1", new DateTime(2024, 7, 1, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4775), 1, new DateTime(2024, 6, 30, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4774) },
                    { 2, "Timesheet 2 for ServicePlan 1", new DateTime(2024, 7, 10, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4777), 1, new DateTime(2024, 7, 9, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4776) },
                    { 3, "Timesheet 1 for ServicePlan 2", new DateTime(2024, 8, 20, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4778), 2, new DateTime(2024, 8, 19, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4778) },
                    { 4, "Timesheet 1 for ServicePlan 3", new DateTime(2024, 9, 18, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4780), 3, new DateTime(2024, 9, 17, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4779) },
                    { 5, "Timesheet 1 for ServicePlan 4", new DateTime(2024, 9, 29, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4782), 4, new DateTime(2024, 9, 28, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4781) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 4);
        }
    }
}
