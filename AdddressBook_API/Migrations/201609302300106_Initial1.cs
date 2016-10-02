namespace AddressBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "GUId", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "PhysicalAddress", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "PhysicalAddress", c => c.String(nullable: false));
            DropColumn("dbo.Addresses", "GUId");
        }
    }
}
