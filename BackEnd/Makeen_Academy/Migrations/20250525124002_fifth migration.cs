using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makeen_Academy.Migrations
{
    /// <inheritdoc />
    public partial class fifthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BatchCustomer",
                columns: table => new
                {
                    BatchListId = table.Column<int>(type: "int", nullable: false),
                    CustomersListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchCustomer", x => new { x.BatchListId, x.CustomersListId });
                    table.ForeignKey(
                        name: "FK_BatchCustomer_Batch_BatchListId",
                        column: x => x.BatchListId,
                        principalTable: "Batch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatchCustomer_Customers_CustomersListId",
                        column: x => x.CustomersListId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatchCustomer_CustomersListId",
                table: "BatchCustomer",
                column: "CustomersListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchCustomer");
        }
    }
}
