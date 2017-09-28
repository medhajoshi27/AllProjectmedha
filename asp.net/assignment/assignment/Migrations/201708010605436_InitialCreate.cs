namespace assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        state = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Country = c.String(),
                        State = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workers");
            DropTable("dbo.States");
            DropTable("dbo.Countries");
        }
    }
}
