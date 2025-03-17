using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class testingcustomerentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tinting");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tinting",
                columns: table => new
                {
                    TintingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    CostOfLightsTint = table.Column<decimal>(type: "TEXT", nullable: true),
                    CostOfWindowTint = table.Column<decimal>(type: "TEXT", nullable: true),
                    HeadlightsAreTinted = table.Column<bool>(type: "INTEGER", nullable: false),
                    TaillightsAreTinted = table.Column<bool>(type: "INTEGER", nullable: false),
                    TintAmount = table.Column<string>(type: "TEXT", nullable: false),
                    TintPercent = table.Column<int>(type: "INTEGER", nullable: true),
                    TintingType = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Tinting_CustomerId",
                table: "Tinting",
                column: "CustomerId");
        }
    }
}
