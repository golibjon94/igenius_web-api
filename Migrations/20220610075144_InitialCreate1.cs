using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplaintsApi.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file",
                table: "File");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "File",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Complaints",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Complaints",
                newName: "EMail");

            migrationBuilder.RenameColumn(
                name: "unique_number",
                table: "Complaints",
                newName: "UniqueNumber");

            migrationBuilder.RenameColumn(
                name: "sip_id",
                table: "Complaints",
                newName: "SipId");

            migrationBuilder.RenameColumn(
                name: "signing_date",
                table: "Complaints",
                newName: "SigningDate");

            migrationBuilder.RenameColumn(
                name: "pnfl",
                table: "Complaints",
                newName: "PinFl");

            migrationBuilder.RenameColumn(
                name: "lot_nomer",
                table: "Complaints",
                newName: "LotNomer");

            migrationBuilder.RenameColumn(
                name: "indication_id",
                table: "Complaints",
                newName: "IndicationId");

            migrationBuilder.RenameColumn(
                name: "ecp_code",
                table: "Complaints",
                newName: "EcpCode");

            migrationBuilder.RenameColumn(
                name: "complaint_text",
                table: "Complaints",
                newName: "ComplaintText");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Complaints",
                newName: "Addres");

            migrationBuilder.AddColumn<string>(
                name: "FileContent",
                table: "File",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContent",
                table: "File");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "File",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Complaints",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "Complaints",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "UniqueNumber",
                table: "Complaints",
                newName: "unique_number");

            migrationBuilder.RenameColumn(
                name: "SipId",
                table: "Complaints",
                newName: "sip_id");

            migrationBuilder.RenameColumn(
                name: "SigningDate",
                table: "Complaints",
                newName: "signing_date");

            migrationBuilder.RenameColumn(
                name: "PinFl",
                table: "Complaints",
                newName: "pnfl");

            migrationBuilder.RenameColumn(
                name: "LotNomer",
                table: "Complaints",
                newName: "lot_nomer");

            migrationBuilder.RenameColumn(
                name: "IndicationId",
                table: "Complaints",
                newName: "indication_id");

            migrationBuilder.RenameColumn(
                name: "EcpCode",
                table: "Complaints",
                newName: "ecp_code");

            migrationBuilder.RenameColumn(
                name: "ComplaintText",
                table: "Complaints",
                newName: "complaint_text");

            migrationBuilder.RenameColumn(
                name: "Addres",
                table: "Complaints",
                newName: "address");

            migrationBuilder.AddColumn<byte[]>(
                name: "file",
                table: "File",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
