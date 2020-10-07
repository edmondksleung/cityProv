using Microsoft.EntityFrameworkCore.Migrations;

namespace CityProv.Data.Migrations.CityProv
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(nullable: false),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false),
                    MyProvince = table.Column<string>(nullable: true),
                    ProvinceCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "MyProvince", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 10, "Vancouver", "British Columbia", 500000, null },
                    { 11, "Victoria", "British Columbia", 200000, null },
                    { 12, "Kelowna", "British Columbia", 100000, null },
                    { 21, "Toronto", "Ontario", 800000, null },
                    { 22, "Waterloo", "Ontario", 100000, null },
                    { 23, "Kingston", "Ontario", 200000, null },
                    { 31, "Calgary", "Alberta", 400000, null },
                    { 32, "Edmonton", "Alberta", 400000, null },
                    { 33, "Lethbridge", "Alberta", 100000, null }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "1", "British Columbia" },
                    { "2", "Ontario" },
                    { "3", "Alberta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode",
                table: "City",
                column: "ProvinceCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
