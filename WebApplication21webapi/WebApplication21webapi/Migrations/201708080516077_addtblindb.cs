namespace WebApplication21webapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtblindb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emps");
        }
    }
}
