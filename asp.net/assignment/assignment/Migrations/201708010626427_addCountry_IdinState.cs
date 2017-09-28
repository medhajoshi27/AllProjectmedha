namespace assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCountry_IdinState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.States", "Country_Id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.States", "Country_Id");
        }
    }
}
