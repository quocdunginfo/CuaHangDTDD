namespace CuaHangDTDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ngay = c.DateTime(nullable: false),
                        tongtien = c.Int(nullable: false),
                        dathanhtoan = c.Boolean(nullable: false),
                        dagiaohang = c.Boolean(nullable: false),
                        diachi_nguoinhan = c.String(),
                        ten_nguoinhan = c.String(),
                        sdt_nguoinhan = c.String(),
                        tennv = c.String(),
                        active = c.Boolean(nullable: false),
                        nguoidung_id = c.Int(),
                        khachhang_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhanViens", t => t.nguoidung_id)
                .ForeignKey("dbo.KhachHangs", t => t.khachhang_id)
                .Index(t => t.nguoidung_id)
                .Index(t => t.khachhang_id);
            
            CreateTable(
                "dbo.ChiTiet_DonHang",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        soluong = c.Int(nullable: false),
                        dongia = c.Int(nullable: false),
                        donhang_id = c.Int(),
                        sanpham_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.DonHangs", t => t.donhang_id)
                .ForeignKey("dbo.SanPhams", t => t.sanpham_id)
                .Index(t => t.donhang_id)
                .Index(t => t.sanpham_id);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        masp = c.String(),
                        ten = c.String(),
                        mota = c.String(),
                        gia = c.Int(nullable: false),
                        active = c.Boolean(nullable: false),
                        hangsx_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.HangSXes", t => t.hangsx_id)
                .Index(t => t.hangsx_id);
            
            CreateTable(
                "dbo.HinhAnhs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        duongdan = c.String(),
                        SanPham_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.SanPhams", t => t.SanPham_id)
                .Index(t => t.SanPham_id);
            
            CreateTable(
                "dbo.HangSXes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenhsx = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tendangnhap = c.String(),
                        tendaydu = c.String(),
                        email = c.String(),
                        matkhau = c.String(),
                        active = c.Boolean(nullable: false),
                        loainhanvien_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.LoaiNhanViens", t => t.loainhanvien_id)
                .Index(t => t.loainhanvien_id);
            
            CreateTable(
                "dbo.NhapHangs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ngay = c.DateTime(nullable: false),
                        tongtien = c.Int(nullable: false),
                        thanhtoan = c.Int(nullable: false),
                        ten_nhanvien = c.String(),
                        ten_nhacungcap = c.String(),
                        active = c.Boolean(nullable: false),
                        nhacc_id = c.Int(),
                        nhanvien_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhaCCs", t => t.nhacc_id)
                .ForeignKey("dbo.NhanViens", t => t.nhanvien_id)
                .Index(t => t.nhacc_id)
                .Index(t => t.nhanvien_id);
            
            CreateTable(
                "dbo.NhaCCs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten_ncc = c.String(),
                        diachi_ncc = c.String(),
                        sdt_ncc = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ChiTiet_NhapHang",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        soluong = c.Int(nullable: false),
                        dongia = c.Int(nullable: false),
                        nhaphang_id = c.Int(),
                        sanpham_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhapHangs", t => t.nhaphang_id)
                .ForeignKey("dbo.SanPhams", t => t.sanpham_id)
                .Index(t => t.nhaphang_id)
                .Index(t => t.sanpham_id);
            
            CreateTable(
                "dbo.LoaiNhanViens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Quyens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tendangnhap = c.String(),
                        tendaydu = c.String(),
                        matkhau = c.String(),
                        diachi = c.String(),
                        email = c.String(),
                        sdt = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TonKhoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ngay = c.DateTime(nullable: false),
                        soluongnhap = c.Int(nullable: false),
                        soluongban = c.Int(nullable: false),
                        sanpham_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.SanPhams", t => t.sanpham_id)
                .Index(t => t.sanpham_id);
            
            CreateTable(
                "dbo.QuyenLoaiNhanViens",
                c => new
                    {
                        Quyen_id = c.Int(nullable: false),
                        LoaiNhanVien_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Quyen_id, t.LoaiNhanVien_id })
                .ForeignKey("dbo.Quyens", t => t.Quyen_id, cascadeDelete: true)
                .ForeignKey("dbo.LoaiNhanViens", t => t.LoaiNhanVien_id, cascadeDelete: true)
                .Index(t => t.Quyen_id)
                .Index(t => t.LoaiNhanVien_id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.QuyenLoaiNhanViens", new[] { "LoaiNhanVien_id" });
            DropIndex("dbo.QuyenLoaiNhanViens", new[] { "Quyen_id" });
            DropIndex("dbo.TonKhoes", new[] { "sanpham_id" });
            DropIndex("dbo.ChiTiet_NhapHang", new[] { "sanpham_id" });
            DropIndex("dbo.ChiTiet_NhapHang", new[] { "nhaphang_id" });
            DropIndex("dbo.NhapHangs", new[] { "nhanvien_id" });
            DropIndex("dbo.NhapHangs", new[] { "nhacc_id" });
            DropIndex("dbo.NhanViens", new[] { "loainhanvien_id" });
            DropIndex("dbo.HinhAnhs", new[] { "SanPham_id" });
            DropIndex("dbo.SanPhams", new[] { "hangsx_id" });
            DropIndex("dbo.ChiTiet_DonHang", new[] { "sanpham_id" });
            DropIndex("dbo.ChiTiet_DonHang", new[] { "donhang_id" });
            DropIndex("dbo.DonHangs", new[] { "khachhang_id" });
            DropIndex("dbo.DonHangs", new[] { "nguoidung_id" });
            DropForeignKey("dbo.QuyenLoaiNhanViens", "LoaiNhanVien_id", "dbo.LoaiNhanViens");
            DropForeignKey("dbo.QuyenLoaiNhanViens", "Quyen_id", "dbo.Quyens");
            DropForeignKey("dbo.TonKhoes", "sanpham_id", "dbo.SanPhams");
            DropForeignKey("dbo.ChiTiet_NhapHang", "sanpham_id", "dbo.SanPhams");
            DropForeignKey("dbo.ChiTiet_NhapHang", "nhaphang_id", "dbo.NhapHangs");
            DropForeignKey("dbo.NhapHangs", "nhanvien_id", "dbo.NhanViens");
            DropForeignKey("dbo.NhapHangs", "nhacc_id", "dbo.NhaCCs");
            DropForeignKey("dbo.NhanViens", "loainhanvien_id", "dbo.LoaiNhanViens");
            DropForeignKey("dbo.HinhAnhs", "SanPham_id", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "hangsx_id", "dbo.HangSXes");
            DropForeignKey("dbo.ChiTiet_DonHang", "sanpham_id", "dbo.SanPhams");
            DropForeignKey("dbo.ChiTiet_DonHang", "donhang_id", "dbo.DonHangs");
            DropForeignKey("dbo.DonHangs", "khachhang_id", "dbo.KhachHangs");
            DropForeignKey("dbo.DonHangs", "nguoidung_id", "dbo.NhanViens");
            DropTable("dbo.QuyenLoaiNhanViens");
            DropTable("dbo.TonKhoes");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.Quyens");
            DropTable("dbo.LoaiNhanViens");
            DropTable("dbo.ChiTiet_NhapHang");
            DropTable("dbo.NhaCCs");
            DropTable("dbo.NhapHangs");
            DropTable("dbo.NhanViens");
            DropTable("dbo.HangSXes");
            DropTable("dbo.HinhAnhs");
            DropTable("dbo.SanPhams");
            DropTable("dbo.ChiTiet_DonHang");
            DropTable("dbo.DonHangs");
        }
    }
}
