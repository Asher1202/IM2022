namespace InventoryManager2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class im : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.inHoaDons", "giatien", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.inHoaDons", "giatien", c => c.String());
        }
    }
}
