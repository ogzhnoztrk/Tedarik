using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tedarik.DataAccess.Migrations
{
    public partial class auth_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    kllnc_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    kllnc_adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kllnc_soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kllnc_posta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kllnc_sifre_hash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    kllnc_sifre_salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    kllnc_aktif_mi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.kllnc_id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_MODUL_TANIM",
                columns: table => new
                {
                    mdul_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mdul_no = table.Column<int>(type: "int", nullable: true),
                    modl_adi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MODUL_TANIM", x => x.mdul_id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_YETKI",
                columns: table => new
                {
                    ytki_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mdul_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    kllnc_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_YETKI", x => x.ytki_id);
                    table.ForeignKey(
                        name: "FK_TBL_YETKI_Kullanicilar_kllnc_id",
                        column: x => x.kllnc_id,
                        principalTable: "Kullanicilar",
                        principalColumn: "kllnc_id");
                    table.ForeignKey(
                        name: "FK_TBL_YETKI_TBL_MODUL_TANIM_mdul_id",
                        column: x => x.mdul_id,
                        principalTable: "TBL_MODUL_TANIM",
                        principalColumn: "mdul_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YETKI_kllnc_id",
                table: "TBL_YETKI",
                column: "kllnc_id");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YETKI_mdul_id",
                table: "TBL_YETKI",
                column: "mdul_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_YETKI");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "TBL_MODUL_TANIM");
        }
    }
}
