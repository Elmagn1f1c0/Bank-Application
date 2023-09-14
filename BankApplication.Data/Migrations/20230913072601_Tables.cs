using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankApplication.Data.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    AccountName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CurrentAccountBalance = table.Column<string>(type: "text", nullable: true),
                    AccountType = table.Column<int>(type: "integer", nullable: false),
                    AccountNumberGenerated = table.Column<string>(type: "text", nullable: true),
                    PinHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    PinSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateLastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TransactionUniqueReference = table.Column<string>(type: "text", nullable: true),
                    Transactionamount = table.Column<decimal>(type: "numeric", nullable: false),
                    TransactionStatus = table.Column<int>(type: "integer", nullable: false),
                    TransactionSourceaccount = table.Column<string>(type: "text", nullable: true),
                    TransactionDestinationaccount = table.Column<string>(type: "text", nullable: true),
                    TransactionParticulars = table.Column<string>(type: "text", nullable: true),
                    TransactionType = table.Column<int>(type: "integer", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
