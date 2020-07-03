using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceApp.Data.Migrations
{
    public partial class Setup_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BudgetIdBudget",
                table: "Expense",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id_Status = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodStatus = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    DescripcionStatus = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id_Status);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id_User = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    PasswordHash = table.Column<byte[]>(maxLength: 250, nullable: false),
                    PasswordSalt = table.Column<byte[]>(maxLength: 250, nullable: false),
                    Id_Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id_User);
                    table.ForeignKey(
                        name: "FK_User_Status_Id_Status",
                        column: x => x.Id_Status,
                        principalTable: "Status",
                        principalColumn: "Id_Status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    Id_Budget = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_User = table.Column<int>(nullable: false),
                    DescriptionBudget = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "Date", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "Date", nullable: false),
                    FinalDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Id_Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.Id_Budget);
                    table.ForeignKey(
                        name: "FK_Budget_Status_Id_Status",
                        column: x => x.Id_Status,
                        principalTable: "Status",
                        principalColumn: "Id_Status",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Budget_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_BudgetIdBudget",
                table: "Expense",
                column: "BudgetIdBudget");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_Id_Status",
                table: "Expense",
                column: "Id_Status");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryExpense_Id_Status",
                table: "CategoryExpense",
                column: "Id_Status");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_Id_Status",
                table: "Budget",
                column: "Id_Status");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_Id_User",
                table: "Budget",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_User_Id_Status",
                table: "User",
                column: "Id_Status");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryExpense_Status_Id_Status",
                table: "CategoryExpense",
                column: "Id_Status",
                principalTable: "Status",
                principalColumn: "Id_Status",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Budget_BudgetIdBudget",
                table: "Expense",
                column: "BudgetIdBudget",
                principalTable: "Budget",
                principalColumn: "Id_Budget",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Status_Id_Status",
                table: "Expense",
                column: "Id_Status",
                principalTable: "Status",
                principalColumn: "Id_Status",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryExpense_Status_Id_Status",
                table: "CategoryExpense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Budget_BudgetIdBudget",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Status_Id_Status",
                table: "Expense");

            migrationBuilder.DropTable(
                name: "Budget");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Expense_BudgetIdBudget",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_Id_Status",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_CategoryExpense_Id_Status",
                table: "CategoryExpense");

            migrationBuilder.DropColumn(
                name: "BudgetIdBudget",
                table: "Expense");
        }
    }
}
