using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypesOfTours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfTour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfTours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfTransports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfTransport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfTransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTour = table.Column<string>(nullable: true),
                    Route = table.Column<string>(nullable: true),
                    TypeOfTourId = table.Column<int>(nullable: false),
                    DateOfStart = table.Column<DateTime>(nullable: false),
                    DateOfFinish = table.Column<DateTime>(nullable: false),
                    TypeOfTransportId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TypesOfTransportId = table.Column<int>(nullable: true),
                    TypesOfTourId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_TypesOfTours_TypesOfTourId",
                        column: x => x.TypesOfTourId,
                        principalTable: "TypesOfTours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tours_TypesOfTransports_TypesOfTransportId",
                        column: x => x.TypesOfTransportId,
                        principalTable: "TypesOfTransports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    NumberOfPeople = table.Column<int>(nullable: false),
                    Sum = table.Column<double>(nullable: false),
                    TourId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Tours_TourId1",
                        column: x => x.TourId1,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TourId1",
                table: "Reservations",
                column: "TourId1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TypesOfTourId",
                table: "Tours",
                column: "TypesOfTourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TypesOfTransportId",
                table: "Tours",
                column: "TypesOfTransportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TypesOfTours");

            migrationBuilder.DropTable(
                name: "TypesOfTransports");
        }
    }
}
