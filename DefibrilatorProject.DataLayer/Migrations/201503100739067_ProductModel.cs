namespace DefibrilatorProject.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Model", c => c.String());
            DropColumn("dbo.Products", "SerialCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "SerialCode", c => c.String());
            DropColumn("dbo.Products", "Model");
        }
    }
}
