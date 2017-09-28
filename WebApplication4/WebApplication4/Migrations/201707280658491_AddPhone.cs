namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Phone");
        }
    }
}
