using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class update_table_promotion_max : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceMin",
                table: "Promotion",
                newName: "PercentMax");

            migrationBuilder.AddColumn<long>(
                name: "DiscountMax",
                table: "Promotion",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountMax",
                table: "Promotion");

            migrationBuilder.RenameColumn(
                name: "PercentMax",
                table: "Promotion",
                newName: "PriceMin");
        }
    }
}
