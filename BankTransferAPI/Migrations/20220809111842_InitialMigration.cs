using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTransferAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NIPFundTransfer",
                columns: table => new
                {
                    TransactionReference = table.Column<Guid>(nullable: false),
                    BeneficiaryAccountName = table.Column<string>(nullable: true),
                    TransactionAmount = table.Column<double>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: true),
                    Narration = table.Column<string>(nullable: true),
                    SourceAccountName = table.Column<string>(nullable: true),
                    BeneficiaryAccountNumber = table.Column<string>(nullable: true),
                    BeneficiaryBank = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIPFundTransfer", x => x.TransactionReference);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NIPFundTransfer");
        }
    }
}
