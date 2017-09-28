namespace Assignment6.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtblindb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emp1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.Long(nullable: false),
                        MaritalStatus = c.Boolean(nullable: false),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emp1");
        }
    }
}
