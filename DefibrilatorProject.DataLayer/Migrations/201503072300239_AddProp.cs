namespace DefibrilatorProject.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductProperties", "ServiceRate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductProperties", "ServiceRate");
        }
    }
}
