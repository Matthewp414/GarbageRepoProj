namespace Real_Garbo_Collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingEmployeetModelAndCustModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "zip", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "zip", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "zip");
            DropColumn("dbo.Employees", "zip");
        }
    }
}
