using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makeen_Academy.Migrations
{
    /// <inheritdoc />
    public partial class sixthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enroll_Batch_BatchId",
                table: "Enroll");

            migrationBuilder.DropForeignKey(
                name: "FK_Enroll_Customers_CustomerId",
                table: "Enroll");

            migrationBuilder.DropTable(
                name: "BatchCustomer");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Enroll",
                newName: "CustomersListId");

            migrationBuilder.RenameColumn(
                name: "BatchId",
                table: "Enroll",
                newName: "BatchListId");

            migrationBuilder.RenameIndex(
                name: "IX_Enroll_CustomerId",
                table: "Enroll",
                newName: "IX_Enroll_CustomersListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enroll_Batch_BatchListId",
                table: "Enroll",
                column: "BatchListId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enroll_Customers_CustomersListId",
                table: "Enroll",
                column: "CustomersListId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enroll_Batch_BatchListId",
                table: "Enroll");

            migrationBuilder.DropForeignKey(
                name: "FK_Enroll_Customers_CustomersListId",
                table: "Enroll");

            migrationBuilder.RenameColumn(
                name: "CustomersListId",
                table: "Enroll",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "BatchListId",
                table: "Enroll",
                newName: "BatchId");

            migrationBuilder.RenameIndex(
                name: "IX_Enroll_CustomersListId",
                table: "Enroll",
                newName: "IX_Enroll_CustomerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Enroll_Batch_BatchId",
                table: "Enroll",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enroll_Customers_CustomerId",
                table: "Enroll",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
