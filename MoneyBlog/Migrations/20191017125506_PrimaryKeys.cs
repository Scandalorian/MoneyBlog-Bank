using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyBlog.Migrations
{
    public partial class PrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    accountId = table.Column<int>(nullable: true),
                    accountNumber = table.Column<int>(nullable: true),
                    balance = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    accountType = table.Column<string>(unicode: false, nullable: true),
                    accountName = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "accounttransaction",
                columns: table => new
                {
                    transactionId = table.Column<int>(nullable: true),
                    accountId = table.Column<int>(nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    time = table.Column<DateTime>(nullable: true),
                    recipient = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "post",
                columns: table => new
                {
                    postId = table.Column<int>(nullable: true),
                    postContent = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "transactiondispute",
                columns: table => new
                {
                    disputeId = table.Column<int>(nullable: true),
                    transactionId = table.Column<int>(nullable: true),
                    time = table.Column<DateTime>(nullable: true),
                    description = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "useraccount",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: true),
                    accountId = table.Column<int>(nullable: true),
                    userRole = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "userInformation",
                columns: table => new
                {
                    userid = table.Column<int>(nullable: true),
                    username = table.Column<string>(unicode: false, nullable: true),
                    firstname = table.Column<string>(unicode: false, nullable: true),
                    lastname = table.Column<string>(unicode: false, nullable: true),
                    phone = table.Column<string>(unicode: false, nullable: true),
                    email = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "accounttransaction");

            migrationBuilder.DropTable(
                name: "post");

            migrationBuilder.DropTable(
                name: "transactiondispute");

            migrationBuilder.DropTable(
                name: "useraccount");

            migrationBuilder.DropTable(
                name: "userInformation");
        }
    }
}
