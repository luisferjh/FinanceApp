using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceApp.Data.Migrations
{
    public partial class ChangeScheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Status_Id_Status",
                table: "User");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "Budget");

            migrationBuilder.DropTable(
                name: "CategoryExpense");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_User_Id_Status",
                table: "User");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id_Category = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Icono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id_Category);
                });

            migrationBuilder.CreateTable(
                name: "TypeOperation",
                columns: table => new
                {
                    Id_TypeOperation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Category = table.Column<int>(nullable: false),
                    Code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Icono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOperation", x => x.Id_TypeOperation);
                    table.ForeignKey(
                        name: "FK_TypeOperation_Category_Id_Category",
                        column: x => x.Id_Category,
                        principalTable: "Category",
                        principalColumn: "Id_Category",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id_Operation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_TypeOperation = table.Column<int>(nullable: false),
                    Code_TypeOperation = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    OperationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id_Operation);
                    table.ForeignKey(
                        name: "FK_Operation_TypeOperation_Id_TypeOperation",
                        column: x => x.Id_TypeOperation,
                        principalTable: "TypeOperation",
                        principalColumn: "Id_TypeOperation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailOperation",
                columns: table => new
                {
                    Id_User = table.Column<int>(nullable: false),
                    Id_Operation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOperation", x => new { x.Id_User, x.Id_Operation });
                    table.ForeignKey(
                        name: "FK_DetailOperation_Operation_Id_Operation",
                        column: x => x.Id_Operation,
                        principalTable: "Operation",
                        principalColumn: "Id_Operation",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOperation_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailOperation_Id_Operation",
                table: "DetailOperation",
                column: "Id_Operation");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_Id_TypeOperation",
                table: "Operation",
                column: "Id_TypeOperation");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOperation_Id_Category",
                table: "TypeOperation",
                column: "Id_Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailOperation");

            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "TypeOperation");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id_Status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodStatus = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    DescripcionStatus = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id_Status);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    Id_Budget = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "Date", nullable: false),
                    DescriptionBudget = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FinalDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Id_Status = table.Column<int>(type: "int", nullable: false),
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "Date", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CategoryExpense",
                columns: table => new
                {
                    Id_CategoryExpense = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoryExpense = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    DescriptionCategoryExpense = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Id_Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryExpense", x => x.Id_CategoryExpense);
                    table.ForeignKey(
                        name: "FK_CategoryExpense_Status_Id_Status",
                        column: x => x.Id_Status,
                        principalTable: "Status",
                        principalColumn: "Id_Status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id_Expense = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountSpent = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    BudgetIdBudget = table.Column<int>(type: "int", nullable: true),
                    DateExpense = table.Column<DateTime>(type: "datetime", nullable: false),
                    DescriptionExpense = table.Column<string>(type: "varchar(70)", nullable: false),
                    IdCategoryExpense = table.Column<int>(type: "int", nullable: false),
                    Id_Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id_Expense);
                    table.ForeignKey(
                        name: "FK_Expense_Budget_BudgetIdBudget",
                        column: x => x.BudgetIdBudget,
                        principalTable: "Budget",
                        principalColumn: "Id_Budget",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_CategoryExpense_IdCategoryExpense",
                        column: x => x.IdCategoryExpense,
                        principalTable: "CategoryExpense",
                        principalColumn: "Id_CategoryExpense",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_Status_Id_Status",
                        column: x => x.Id_Status,
                        principalTable: "Status",
                        principalColumn: "Id_Status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Id_Status",
                table: "User",
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
                name: "IX_CategoryExpense_Id_Status",
                table: "CategoryExpense",
                column: "Id_Status");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_BudgetIdBudget",
                table: "Expense",
                column: "BudgetIdBudget");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_IdCategoryExpense",
                table: "Expense",
                column: "IdCategoryExpense");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_Id_Status",
                table: "Expense",
                column: "Id_Status");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Status_Id_Status",
                table: "User",
                column: "Id_Status",
                principalTable: "Status",
                principalColumn: "Id_Status",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
