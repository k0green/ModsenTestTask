using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModsenTestTask.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Plan = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Organizer = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Speaker = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
