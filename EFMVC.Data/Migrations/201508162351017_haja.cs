namespace EFMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haja : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Description", c => c.String(maxLength: 140));
            AlterColumn("dbo.Expenses", "Transaction", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Expenses", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Expenses", new[] { "CategoryId" });
            AlterColumn("dbo.Expenses", "Transaction", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
        }
    }
}
