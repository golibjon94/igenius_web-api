using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplaintsApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    FileId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    file = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.FileId);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Form = table.Column<int>(type: "int", nullable: false),
                    Tin = table.Column<int>(type: "int", nullable: false),
                    pnfl = table.Column<long>(type: "bigint", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<int>(type: "int", nullable: false),
                    sip_id = table.Column<int>(type: "int", nullable: false),
                    lot_nomer = table.Column<int>(type: "int", nullable: false),
                    indication_id = table.Column<int>(type: "int", nullable: false),
                    complaint_text = table.Column<int>(type: "int", nullable: false),
                    ecp_code = table.Column<int>(type: "int", nullable: false),
                    signing_date = table.Column<int>(type: "int", nullable: false),
                    unique_number = table.Column<int>(type: "int", nullable: false),
                    FilesFileId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintId);
                    table.ForeignKey(
                        name: "FK_Complaints_File_FilesFileId",
                        column: x => x.FilesFileId,
                        principalTable: "File",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_FilesFileId",
                table: "Complaints",
                column: "FilesFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "File");
        }
    }
}
