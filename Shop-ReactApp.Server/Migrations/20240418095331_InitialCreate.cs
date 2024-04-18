using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_ReactApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    IdBrand = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NameBrand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Nation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.IdBrand);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdBrand = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescriptionProduct = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    PromotionalPrice = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDBrands = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    IdAccount = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UsersEmail = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RoleIdRole = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.IdAccount);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_RoleIdRole",
                        column: x => x.RoleIdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole");
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UsersEmail",
                        column: x => x.UsersEmail,
                        principalTable: "Users",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    IdBill = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdAccount = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FullPrice = table.Column<float>(type: "real", nullable: false),
                    ExportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryStatus = table.Column<bool>(type: "bit", nullable: false),
                    AccountsIdAccount = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_Bills_Accounts_AccountsIdAccount",
                        column: x => x.AccountsIdAccount,
                        principalTable: "Accounts",
                        principalColumn: "IdAccount");
                });

            migrationBuilder.CreateTable(
                name: "DetailsBill",
                columns: table => new
                {
                    IdDetailBill = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BillsIdBill = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsBill", x => x.IdDetailBill);
                    table.ForeignKey(
                        name: "FK_DetailsBill_Bills_BillsIdBill",
                        column: x => x.BillsIdBill,
                        principalTable: "Bills",
                        principalColumn: "IdBill");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleIdRole",
                table: "Accounts",
                column: "RoleIdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UsersEmail",
                table: "Accounts",
                column: "UsersEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AccountsIdAccount",
                table: "Bills",
                column: "AccountsIdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsBill_BillsIdBill",
                table: "DetailsBill",
                column: "BillsIdBill");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "DetailsBill");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
