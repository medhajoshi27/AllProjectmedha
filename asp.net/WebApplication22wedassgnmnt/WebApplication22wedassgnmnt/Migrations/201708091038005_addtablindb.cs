namespace WebApplication22wedassgnmnt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablindb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudDetails",
                c => new
                    {
                        StudId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        State = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudId);
            
            CreateTable(
                "dbo.Student1",
                c => new
                    {
                        StudId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        RollNo = c.Int(nullable: false),
                        Course = c.String(nullable: false),
                        Branch = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudId);
            
            CreateTable(
                "dbo.StudentVMs",
                c => new
                    {
                        StudId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        RollNo = c.Int(nullable: false),
                        Course = c.String(nullable: false),
                        Branch = c.String(nullable: false),
                        Email = c.String(),
                        State = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentVMs");
            DropTable("dbo.Student1");
            DropTable("dbo.StudDetails");
        }
    }
}
