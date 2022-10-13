namespace InventoryManager2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhapHangHoas",
                c => new
                    {
                        TenHang = c.String(nullable: false, maxLength: 128),
                        MAHD = c.Int(nullable: false),
                        SoLuongNhap = c.String(),
                        NhaCungCap = c.String(),
                        LoaiHangHoa = c.String(),
                        SoTien = c.String(),
                    })
                .PrimaryKey(t => t.TenHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhapHangHoas");
        }
    }
}
