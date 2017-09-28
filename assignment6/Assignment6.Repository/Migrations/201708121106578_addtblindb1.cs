namespace Assignment6.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtblindb1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emp1", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Emp1", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Emp1", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Emp1", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emp1", "City", c => c.String());
            AlterColumn("dbo.Emp1", "State", c => c.String());
            AlterColumn("dbo.Emp1", "Email", c => c.String());
            AlterColumn("dbo.Emp1", "Name", c => c.String());
        }
    }
}
