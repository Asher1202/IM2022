namespace InventoryManager2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IM22 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NhapHangHoas");
            AlterColumn("dbo.NhapHangHoas", "TenHang", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.NhapHangHoas", "TenHang");
            DropColumn("dbo.NhapHangHoas", "realid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NhapHangHoas", "realid", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.NhapHangHoas");
            AlterColumn("dbo.NhapHangHoas", "TenHang", c => c.String());
            AddPrimaryKey("dbo.NhapHangHoas", "id");
        }
    }
}
