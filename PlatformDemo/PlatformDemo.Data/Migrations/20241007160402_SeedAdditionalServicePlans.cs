using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdditionalServicePlans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 10, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 20, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 8, 9, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.InsertData(
                table: "ServicePlans",
                columns: new[] { "ServicePlanId", "DateOfPurchase" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 8, 19, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8695) },
                    { 7, new DateTime(2024, 8, 29, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8696) },
                    { 8, new DateTime(2024, 9, 8, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8697) },
                    { 9, new DateTime(2024, 9, 13, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8698) },
                    { 10, new DateTime(2024, 9, 18, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8699) },
                    { 11, new DateTime(2024, 9, 23, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8700) },
                    { 12, new DateTime(2024, 9, 28, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8701) },
                    { 13, new DateTime(2024, 10, 3, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8702) },
                    { 14, new DateTime(2024, 10, 5, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8703) },
                    { 15, new DateTime(2024, 10, 7, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8705) }
                });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 7, 1, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8822), new DateTime(2024, 7, 5, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 7, 11, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 4,
                columns: new[] { "Description", "EndTime", "ServicePlanId", "StartTime" },
                values: new object[] { "Timesheet 2 for ServicePlan 2", new DateTime(2024, 7, 16, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8826), 2, new DateTime(2024, 7, 15, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 5,
                columns: new[] { "Description", "EndTime", "ServicePlanId", "StartTime" },
                values: new object[] { "Timesheet 1 for ServicePlan 3", new DateTime(2024, 7, 22, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8834), 3, new DateTime(2024, 7, 21, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "Description", "EndTime", "ServicePlanId", "StartTime" },
                values: new object[,]
                {
                    { 6, "Timesheet 1 for ServicePlan 4", new DateTime(2024, 8, 1, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8836), 4, new DateTime(2024, 7, 31, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8835) },
                    { 7, "Timesheet 1 for ServicePlan 5", new DateTime(2024, 8, 11, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8838), 5, new DateTime(2024, 8, 10, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8837) },
                    { 8, "Timesheet 1 for ServicePlan 6", new DateTime(2024, 8, 21, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8839), 6, new DateTime(2024, 8, 20, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8839) },
                    { 9, "Timesheet 1 for ServicePlan 7", new DateTime(2024, 8, 31, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8841), 7, new DateTime(2024, 8, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8841) },
                    { 10, "Timesheet 1 for ServicePlan 8", new DateTime(2024, 9, 10, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8843), 8, new DateTime(2024, 9, 9, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8842) },
                    { 11, "Timesheet 1 for ServicePlan 9", new DateTime(2024, 9, 15, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8845), 9, new DateTime(2024, 9, 14, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8844) },
                    { 12, "Timesheet 1 for ServicePlan 10", new DateTime(2024, 9, 20, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8846), 10, new DateTime(2024, 9, 19, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8846) },
                    { 13, "Timesheet 1 for ServicePlan 11", new DateTime(2024, 9, 25, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8848), 11, new DateTime(2024, 9, 24, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8847) },
                    { 14, "Timesheet 1 for ServicePlan 12", new DateTime(2024, 9, 30, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8850), 12, new DateTime(2024, 9, 29, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8849) },
                    { 15, "Timesheet 1 for ServicePlan 13", new DateTime(2024, 10, 5, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8851), 13, new DateTime(2024, 10, 4, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8851) },
                    { 16, "Timesheet 1 for ServicePlan 14", new DateTime(2024, 10, 7, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8853), 14, new DateTime(2024, 10, 6, 0, 4, 2, 57, DateTimeKind.Local).AddTicks(8852) },
                    { 17, "Timesheet 1 for ServicePlan 15", new DateTime(2024, 10, 7, 16, 4, 2, 57, DateTimeKind.Local).AddTicks(8855), 15, new DateTime(2024, 10, 7, 14, 4, 2, 57, DateTimeKind.Local).AddTicks(8854) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 29, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 8, 18, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 9, 12, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 9, 27, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "ServicePlans",
                keyColumn: "ServicePlanId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 2, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 6, 30, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 7, 9, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 8, 19, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 4,
                columns: new[] { "Description", "EndTime", "ServicePlanId", "StartTime" },
                values: new object[] { "Timesheet 1 for ServicePlan 3", new DateTime(2024, 9, 18, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4780), 3, new DateTime(2024, 9, 17, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumn: "TimesheetId",
                keyValue: 5,
                columns: new[] { "Description", "EndTime", "ServicePlanId", "StartTime" },
                values: new object[] { "Timesheet 1 for ServicePlan 4", new DateTime(2024, 9, 29, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4782), 4, new DateTime(2024, 9, 28, 23, 46, 50, 403, DateTimeKind.Local).AddTicks(4781) });
        }
    }
}
