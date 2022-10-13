namespace InventoryManager2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IM22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhapHangHoas", "id", c => c.Int(nullable: false));
            AddColumn("dbo.NhapHangHoas", "SoTienBan", c => c.String());
            DropColumn("dbo.NhapHangHoas", "MAHD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NhapHangHoas", "MAHD", c => c.Int(nullable: false));
            DropColumn("dbo.NhapHangHoas", "SoTienBan");
            DropColumn("dbo.NhapHangHoas", "id");
        }
    }
}
