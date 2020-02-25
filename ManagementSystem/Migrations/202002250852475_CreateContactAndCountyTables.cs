namespace ManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContactAndCountyTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "StreetAddress2", c => c.String(maxLength: 250));
            DropColumn("dbo.Contacts", "StreetAdress2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "StreetAdress2", c => c.String(maxLength: 250));
            DropColumn("dbo.Contacts", "StreetAddress2");
        }
    }
}
