namespace WebApplication31.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentMasters",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        ClassName = c.String(nullable: false),
                        DateOfAdmission = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentMasters");
        }
    }
}
