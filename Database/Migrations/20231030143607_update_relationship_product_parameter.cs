using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class update_relationship_product_parameter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Specifications_SpecificationsId",
                table: "ProductSpecifications");

            migrationBuilder.RenameColumn(
                name: "SpecificationsId",
                table: "ProductSpecifications",
                newName: "DetailSpecificationsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSpecifications_SpecificationsId",
                table: "ProductSpecifications",
                newName: "IX_ProductSpecifications_DetailSpecificationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_DetailSpecifications_DetailSpecificationsId",
                table: "ProductSpecifications",
                column: "DetailSpecificationsId",
                principalTable: "DetailSpecifications",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_DetailSpecifications_DetailSpecificationsId",
                table: "ProductSpecifications");

            migrationBuilder.RenameColumn(
                name: "DetailSpecificationsId",
                table: "ProductSpecifications",
                newName: "SpecificationsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSpecifications_DetailSpecificationsId",
                table: "ProductSpecifications",
                newName: "IX_ProductSpecifications_SpecificationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Specifications_SpecificationsId",
                table: "ProductSpecifications",
                column: "SpecificationsId",
                principalTable: "Specifications",
                principalColumn: "Id");
        }
    }
}
