using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopFCSummery.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 41, 21, 278, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 41, 21, 278, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 41, 21, 278, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 41, 21, 278, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 41, 21, 278, DateTimeKind.Local).AddTicks(3768));
            //
            migrationBuilder.Sql("create proc SelectAllUsers as select * from Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 37, 27, 643, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 37, 27, 643, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 37, 27, 643, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 37, 27, 643, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "UsersOrders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 2, 8, 20, 37, 27, 643, DateTimeKind.Local).AddTicks(3949));
            //
            migrationBuilder.Sql("drop proc SelectAllUsers ");
        }
    }
}
