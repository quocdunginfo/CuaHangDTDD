namespace CuaHangDTDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cap_nhat_class_jkasdhjashdjksdasd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DonHangs", "nguoidung_id", "dbo.NhanViens");
            DropForeignKey("dbo.DonHangs", "khachhang_id", "dbo.KhachHangs");
            DropForeignKey("dbo.NhanViens", "loainhanvien_id", "dbo.LoaiNhanViens");
            DropForeignKey("dbo.NhapHangs", "nhacc_id", "dbo.NhaCCs");
            DropForeignKey("dbo.NhapHangs", "nhanvien_id", "dbo.NhanViens");
            DropForeignKey("dbo.QuyenLoaiNhanViens", "Quyen_id", "dbo.Quyens");
            DropForeignKey("dbo.QuyenLoaiNhanViens", "LoaiNhanVien_id", "dbo.LoaiNhanViens");
            DropIndex("dbo.DonHangs", new[] { "nguoidung_id" });
            DropIndex("dbo.DonHangs", new[] { "khachhang_id" });
            DropIndex("dbo.NhanViens", new[] { "loainhanvien_id" });
            DropIndex("dbo.NhapHangs", new[] { "nhacc_id" });
            DropIndex("dbo.NhapHangs", new[] { "nhanvien_id" });
            DropIndex("dbo.QuyenLoaiNhanViens", new[] { "Quyen_id" });
            DropIndex("dbo.QuyenLoaiNhanViens", new[] { "LoaiNhanVien_id" });
            AddColumn("dbo.DonHangs", "kh_ten", c => c.String());
            AddColumn("dbo.DonHangs", "kh_diachi", c => c.String());
            AddColumn("dbo.DonHangs", "kh_email", c => c.String());
            AddColumn("dbo.DonHangs", "kh_sdt", c => c.String());
            AddColumn("dbo.TonKhoes", "soluong", c => c.Int(nullable: false));
            DropColumn("dbo.DonHangs", "nguoidung_id");
            DropColumn("dbo.DonHangs", "khachhang_id");
            DropColumn("dbo.NhapHangs", "thanhtoan");
            DropColumn("dbo.NhapHangs", "ten_nhanvien");
            DropColumn("dbo.NhapHangs", "ten_nhacungcap");
            DropColumn("dbo.NhapHangs", "nhacc_id");
            DropColumn("dbo.NhapHangs", "nhanvien_id");
            DropColumn("dbo.TonKhoes", "soluongnhap");
            DropColumn("dbo.TonKhoes", "soluongban");
            DropTable("dbo.NhanViens");
            DropTable("dbo.NhaCCs");
            DropTable("dbo.LoaiNhanViens");
            DropTable("dbo.Quyens");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.QuyenLoaiNhanViens");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.QuyenLoaiNhanViens",
                c => new
                    {
                        Quyen_id = c.Int(nullable: false),
                        LoaiNhanVien_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Quyen_id, t.LoaiNhanVien_id });
            
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
                "dbo.Quyens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LoaiNhanViens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
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
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.TonKhoes", "soluongban", c => c.Int(nullable: false));
            AddColumn("dbo.TonKhoes", "soluongnhap", c => c.Int(nullable: false));
            AddColumn("dbo.NhapHangs", "nhanvien_id", c => c.Int());
            AddColumn("dbo.NhapHangs", "nhacc_id", c => c.Int());
            AddColumn("dbo.NhapHangs", "ten_nhacungcap", c => c.String());
            AddColumn("dbo.NhapHangs", "ten_nhanvien", c => c.String());
            AddColumn("dbo.NhapHangs", "thanhtoan", c => c.Int(nullable: false));
            AddColumn("dbo.DonHangs", "khachhang_id", c => c.Int());
            AddColumn("dbo.DonHangs", "nguoidung_id", c => c.Int());
            DropColumn("dbo.TonKhoes", "soluong");
            DropColumn("dbo.DonHangs", "kh_sdt");
            DropColumn("dbo.DonHangs", "kh_email");
            DropColumn("dbo.DonHangs", "kh_diachi");
            DropColumn("dbo.DonHangs", "kh_ten");
            CreateIndex("dbo.QuyenLoaiNhanViens", "LoaiNhanVien_id");
            CreateIndex("dbo.QuyenLoaiNhanViens", "Quyen_id");
            CreateIndex("dbo.NhapHangs", "nhanvien_id");
            CreateIndex("dbo.NhapHangs", "nhacc_id");
            CreateIndex("dbo.NhanViens", "loainhanvien_id");
            CreateIndex("dbo.DonHangs", "khachhang_id");
            CreateIndex("dbo.DonHangs", "nguoidung_id");
            AddForeignKey("dbo.QuyenLoaiNhanViens", "LoaiNhanVien_id", "dbo.LoaiNhanViens", "id", cascadeDelete: true);
            AddForeignKey("dbo.QuyenLoaiNhanViens", "Quyen_id", "dbo.Quyens", "id", cascadeDelete: true);
            AddForeignKey("dbo.NhapHangs", "nhanvien_id", "dbo.NhanViens", "id");
            AddForeignKey("dbo.NhapHangs", "nhacc_id", "dbo.NhaCCs", "id");
            AddForeignKey("dbo.NhanViens", "loainhanvien_id", "dbo.LoaiNhanViens", "id");
            AddForeignKey("dbo.DonHangs", "khachhang_id", "dbo.KhachHangs", "id");
            AddForeignKey("dbo.DonHangs", "nguoidung_id", "dbo.NhanViens", "id");
        }
    }
}
