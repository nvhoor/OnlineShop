namespace BookShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInitial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProductCategory_ID", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "ProductCategory_ID" });
            DropColumn("dbo.Products", "CategoryID");
            RenameColumn(table: "dbo.Products", name: "ProductCategory_ID", newName: "CategoryID");
            AlterColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryID");
            AddForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            AlterColumn("dbo.Products", "CategoryID", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "CategoryID", newName: "ProductCategory_ID");
            AddColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ProductCategory_ID");
            AddForeignKey("dbo.Products", "ProductCategory_ID", "dbo.ProductCategories", "ID");
        }
    }
}
