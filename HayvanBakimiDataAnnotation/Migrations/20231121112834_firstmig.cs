using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBakimiDataAnnotation.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakicilar",
                columns: table => new
                {
                    BakiciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakicilar", x => x.BakiciId);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    SahipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.SahipId);
                });

            migrationBuilder.CreateTable(
                name: "Yiyecekler",
                columns: table => new
                {
                    YiyecekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyecekler", x => x.YiyecekId);
                });

            migrationBuilder.CreateTable(
                name: "Hayvanlar",
                columns: table => new
                {
                    HayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    SahibiVarMi = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BakiciId = table.Column<int>(type: "int", nullable: false),
                    SahipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlar", x => x.HayId);
                    table.ForeignKey(
                        name: "FK_Hayvanlar_Bakicilar_BakiciId",
                        column: x => x.BakiciId,
                        principalTable: "Bakicilar",
                        principalColumn: "BakiciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hayvanlar_Owner_SahipId",
                        column: x => x.SahipId,
                        principalTable: "Owner",
                        principalColumn: "SahipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HayvanYiyecek",
                columns: table => new
                {
                    HayvanlarHayId = table.Column<int>(type: "int", nullable: false),
                    YiyeceklerYiyecekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayvanYiyecek", x => new { x.HayvanlarHayId, x.YiyeceklerYiyecekId });
                    table.ForeignKey(
                        name: "FK_HayvanYiyecek_Hayvanlar_HayvanlarHayId",
                        column: x => x.HayvanlarHayId,
                        principalTable: "Hayvanlar",
                        principalColumn: "HayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HayvanYiyecek_Yiyecekler_YiyeceklerYiyecekId",
                        column: x => x.YiyeceklerYiyecekId,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlar_BakiciId",
                table: "Hayvanlar",
                column: "BakiciId");

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlar_SahipId",
                table: "Hayvanlar",
                column: "SahipId");

            migrationBuilder.CreateIndex(
                name: "IX_HayvanYiyecek_YiyeceklerYiyecekId",
                table: "HayvanYiyecek",
                column: "YiyeceklerYiyecekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HayvanYiyecek");

            migrationBuilder.DropTable(
                name: "Hayvanlar");

            migrationBuilder.DropTable(
                name: "Yiyecekler");

            migrationBuilder.DropTable(
                name: "Bakicilar");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
