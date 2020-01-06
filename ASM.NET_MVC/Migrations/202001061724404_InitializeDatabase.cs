namespace ASM.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coins", "CodeName", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Markets", "Name", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Coins", "BaseAsset", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Coins", "QuoteAsset", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coins", "QuoteAsset", c => c.String(unicode: false));
            AlterColumn("dbo.Coins", "BaseAsset", c => c.String(unicode: false));
            AlterColumn("dbo.Markets", "Name", c => c.String(unicode: false));
            DropColumn("dbo.Coins", "CodeName");
        }
    }
}
