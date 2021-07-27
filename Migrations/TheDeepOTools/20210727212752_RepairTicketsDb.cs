using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheDeepOTools.Migrations.TheDeepOTools
{
    public partial class RepairTicketsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepairTicket",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TicketState = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairTicket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairTicketMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    TicketId = table.Column<Guid>(nullable: false),
                    OwnerId = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairTicketMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairTicketMessage_RepairTicket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "RepairTicket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairTicketMessage_TicketId",
                table: "RepairTicketMessage",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairTicketMessage");

            migrationBuilder.DropTable(
                name: "RepairTicket");
        }
    }
}
