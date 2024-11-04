using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tedarik.DataAccess.Migrations
{
    public partial class kullanicilar_update_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_YETKI_Kullanicilar_kllnc_id",
                table: "TBL_YETKI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar");

            migrationBuilder.RenameTable(
                name: "Kullanicilar",
                newName: "TBL_KULLANICILAR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_KULLANICILAR",
                table: "TBL_KULLANICILAR",
                column: "kllnc_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_YETKI_TBL_KULLANICILAR_kllnc_id",
                table: "TBL_YETKI",
                column: "kllnc_id",
                principalTable: "TBL_KULLANICILAR",
                principalColumn: "kllnc_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_YETKI_TBL_KULLANICILAR_kllnc_id",
                table: "TBL_YETKI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_KULLANICILAR",
                table: "TBL_KULLANICILAR");

            migrationBuilder.RenameTable(
                name: "TBL_KULLANICILAR",
                newName: "Kullanicilar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar",
                column: "kllnc_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_YETKI_Kullanicilar_kllnc_id",
                table: "TBL_YETKI",
                column: "kllnc_id",
                principalTable: "Kullanicilar",
                principalColumn: "kllnc_id");
        }
    }
}
