namespace DefibrilatorProject.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clean : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductProperties", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductProperties", "TypeId", c => c.Int(nullable: false));
        }
    }
}
