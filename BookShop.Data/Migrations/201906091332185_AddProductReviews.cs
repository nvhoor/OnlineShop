namespace BookShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductReviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.ProductCategories", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Pages", "Alias", c => c.String(nullable: false, maxLength: 250, unicode: false));
            DropColumn("dbo.Products", "Desciption");
            DropColumn("dbo.ProductCategories", "Desciption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductCategories", "Desciption", c => c.String(maxLength: 500));
            AddColumn("dbo.Products", "Desciption", c => c.String(maxLength: 500));
            DropColumn("dbo.Pages", "Alias");
            DropColumn("dbo.ProductCategories", "Description");
            DropColumn("dbo.Products", "Description");
        }
    }
}
