using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceApp.Data.Migrations
{
    public partial class Setup_expense_and_categoryExpense_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdStatus",
                table: "Expense",
                newName: "Id_Status");

            migrationBuilder.AddColumn<int>(
                name: "IdCategoryExpense",
                table: "Expense",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryExpense",
                columns: table => new
                {
                    Id_CategoryExpense = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoryExpense = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    DescriptionCategoryExpense = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Id_Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryExpense", x => x.Id_CategoryExpense);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_IdCategoryExpense",
                table: "Expense",
                column: "IdCategoryExpense");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_CategoryExpense_IdCategoryExpense",
                table: "Expense",
                column: "IdCategoryExpense",
                principalTable: "CategoryExpense",
                principalColumn: "Id_CategoryExpense",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_CategoryExpense_IdCategoryExpense",
                table: "Expense");

            migrationBuilder.DropTable(
                name: "CategoryExpense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_IdCategoryExpense",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "IdCategoryExpense",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "Id_Status",
                table: "Expense",
                newName: "IdStatus");
        }
    }
}
