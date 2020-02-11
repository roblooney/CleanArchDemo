using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArc.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyCorporates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SSNumber = table.Column<string>(nullable: true),
                    LotNumber = table.Column<string>(nullable: true),
                    StreetAddress1 = table.Column<string>(nullable: true),
                    StreetAddress2 = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    ActiveDate = table.Column<DateTime>(nullable: false),
                    MunicipalityAccount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyCorporates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BcId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WaterMeterNumber = table.Column<string>(nullable: true),
                    ElectricityMeterNumber = table.Column<string>(nullable: true),
                    GasMeterNumber = table.Column<string>(nullable: true),
                    ERFNumber = table.Column<string>(nullable: true),
                    SectionNumber = table.Column<string>(nullable: true),
                    DoorNumber = table.Column<string>(nullable: true),
                    FloorArea = table.Column<string>(nullable: true),
                    ParticipationQuota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyCorporates");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
