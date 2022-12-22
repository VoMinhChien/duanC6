using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsmAPI.Migrations
{
    public partial class asm6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    KhachHang_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHang_Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    KhachHang_NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHang_Sdt = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    KhachHang_Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    KhachHang_PassWord = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    KhachHang_PassWord2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    KhachHang_Mota = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.KhachHang_Id);
                });

            migrationBuilder.CreateTable(
                name: "MonAns",
                columns: table => new
                {
                    MonAn_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonAn_Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    MonAn_Gia = table.Column<float>(type: "real", nullable: false),
                    MonAn_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonAn_DanhMuc = table.Column<int>(type: "int", nullable: false),
                    MonAn_MoTa = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MonAn_NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonAn_NgaySua = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    MonAn_GhiChu = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    VAT = table.Column<float>(type: "real", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAns", x => x.MonAn_Id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    NguoiDung_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDung_UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NguoiDung_Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NguoiDung_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    NguoiDung_PassWord = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    NguoiDung_PassWord2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NguoiDung_NgaySinh = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    NguoiDung_SoDienThoai = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.NguoiDung_Id);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    DonHang_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHang_Id = table.Column<int>(type: "int", nullable: false),
                    KhachHang_Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    KhachHang_Email = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    KhachHang_SoDienThoai = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    KhachHang_DiaChi = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    GiaTienChuaVAT = table.Column<float>(type: "real", nullable: false),
                    GiaTienDaVAT = table.Column<float>(type: "real", nullable: false),
                    VAT = table.Column<float>(type: "real", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoaDon_TrangThai = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.DonHang_Id);
                    table.ForeignKey(
                        name: "FK_DonHangs_KhachHangs_KhachHang_Id",
                        column: x => x.KhachHang_Id,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHang_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHangs",
                columns: table => new
                {
                    ChiTietDonHang_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonHang_Id = table.Column<int>(type: "int", nullable: false),
                    MonAn_Id = table.Column<int>(type: "int", nullable: false),
                    MonAn_Name = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MonAn_SoLuong = table.Column<int>(type: "int", nullable: false),
                    MonAn_Image = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MonAn_Gia = table.Column<float>(type: "real", nullable: false),
                    VAT = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHangs", x => x.ChiTietDonHang_Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_DonHangs_DonHang_Id",
                        column: x => x.DonHang_Id,
                        principalTable: "DonHangs",
                        principalColumn: "DonHang_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_MonAns_MonAn_Id",
                        column: x => x.MonAn_Id,
                        principalTable: "MonAns",
                        principalColumn: "MonAn_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_DonHang_Id",
                table: "ChiTietDonHangs",
                column: "DonHang_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_MonAn_Id",
                table: "ChiTietDonHangs",
                column: "MonAn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_KhachHang_Id",
                table: "DonHangs",
                column: "KhachHang_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "MonAns");

            migrationBuilder.DropTable(
                name: "KhachHangs");
        }
    }
}
