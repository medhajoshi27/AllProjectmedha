namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclass1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),

                    tag = c.String(),
                    course_Course_Id = c.Int(),
                    Courses_Course_Id = c.Int(),
                })
                .PrimaryKey(t => t.ID);
                
            
            AddColumn("catalog.tbl_course", "Tag_ID", c => c.Int());
            CreateIndex("catalog.tbl_course", "Tag_ID");
            CreateIndex("catalog.tbl_course", "tag_ID");
            AddForeignKey("catalog.tbl_course", "Tag_ID", "dbo.Tags", "ID");
            AddForeignKey("catalog.tbl_course", "tag_ID", "dbo.Tags", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Courses_Course_Id", "catalog.tbl_course");
            DropForeignKey("catalog.tbl_course", "tag_ID", "dbo.Tags");
            DropForeignKey("catalog.tbl_course", "Tag_ID", "dbo.Tags");
            DropForeignKey("dbo.Tags", "course_Course_Id", "catalog.tbl_course");
            DropIndex("dbo.Tags", new[] { "Courses_Course_Id" });
            DropIndex("dbo.Tags", new[] { "course_Course_Id" });
            DropIndex("catalog.tbl_course", new[] { "tag_ID" });
            DropIndex("catalog.tbl_course", new[] { "Tag_ID" });
            DropColumn("catalog.tbl_course", "Tag_ID");
            DropTable("dbo.Tags");
        }
    }
}
