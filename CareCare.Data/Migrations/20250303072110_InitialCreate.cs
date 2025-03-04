using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleIsDetailed = table.Column<bool>(type: "INTEGER", nullable: false),
                    VehicleIsTinted = table.Column<bool>(type: "INTEGER", nullable: false),
                    TotalCostOfServices = table.Column<decimal>(type: "TEXT", nullable: false),
                    Overhead = table.Column<decimal>(type: "TEXT", nullable: false),
                    AmountChargedToCustomer = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Tinting",
                columns: table => new
                {
                    TintingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TintingType = table.Column<string>(type: "TEXT", nullable: false),
                    TintPercent = table.Column<int>(type: "INTEGER", nullable: true),
                    CostOfWindowTint = table.Column<decimal>(type: "TEXT", nullable: true),
                    TintAmount = table.Column<string>(type: "TEXT", nullable: false),
                    HeadlightsAreTinted = table.Column<bool>(type: "INTEGER", nullable: false),
                    TaillightsAreTinted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CostOfLightsTint = table.Column<decimal>(type: "TEXT", nullable: true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tinting", x => x.TintingId);
                    table.ForeignKey(
                        name: "FK_Tinting_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehiclesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehiclesCount = table.Column<int>(type: "INTEGER", nullable: false),
                    VehicleMake = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleModel = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleYear = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceLocation = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehiclesId);
                    table.ForeignKey(
                        name: "FK_Vehicle_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tinting_CustomerId",
                table: "Tinting",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CustomerId",
                table: "Vehicle",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tinting");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
