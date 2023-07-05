using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoreLogic.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoofGuest = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "saheb123@gmail.com", "saheb", "kumar" },
                    { 2, "deepak123@gmail.com", "deepak", "kumar" }
                });

            migrationBuilder.InsertData(
                table: "BookEvents",
                columns: new[] { "Id", "BookingDate", "EventType", "NoofGuest", "UserId", "Venue" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birthday", 0, 1, null },
                    { 2, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anniversary", 0, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookEvents_UserId",
                table: "BookEvents",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookEvents");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
