using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class update_table_promotion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountMax",
                table: "Promotion");

            migrationBuilder.DropColumn(
                name: "PercentMax",
                table: "Promotion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DiscountMax",
                table: "Promotion",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PercentMax",
                table: "Promotion",
                type: "bigint",
                nullable: true);
        }
    }
}
