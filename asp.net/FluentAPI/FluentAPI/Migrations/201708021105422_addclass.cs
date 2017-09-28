namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        NameoftheAuthor = c.String(name: "Name of the Author", nullable: false),
                        Author_Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Author_Id);
            
            CreateTable(
                "catalog.tbl_course",
                c => new
                    {
                        Course_Id = c.Int(nullable: false, identity: true),
                        Course_Name = c.String(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Course_Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Address = c.Int(nullable: false),
                        author_Author_Id = c.Int(),
                        course_Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.author_Author_Id)
                .ForeignKey("catalog.tbl_course", t => t.course_Course_Id)
                .Index(t => t.author_Author_Id)
                .Index(t => t.course_Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Data", "course_Course_Id", "catalog.tbl_course");
            DropForeignKey("dbo.Data", "author_Author_Id", "dbo.Authors");
            DropForeignKey("catalog.tbl_course", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Data", new[] { "course_Course_Id" });
            DropIndex("dbo.Data", new[] { "author_Author_Id" });
            DropIndex("catalog.tbl_course", new[] { "Author_Id" });
            DropTable("dbo.Data");
            DropTable("catalog.tbl_course");
            DropTable("dbo.Authors");
        }
    }
}
