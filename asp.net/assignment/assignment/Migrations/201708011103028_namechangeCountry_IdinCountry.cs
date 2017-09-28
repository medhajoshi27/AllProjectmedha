namespace assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class namechangeCountry_IdinCountry : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Countries");
            AddColumn("dbo.Countries", "Country_Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Countries", "Country_Id");
            DropColumn("dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Id", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Countries");
            DropColumn("dbo.Countries", "Country_Id");
            AddPrimaryKey("dbo.Countries", "Id");
        }
    }
}
