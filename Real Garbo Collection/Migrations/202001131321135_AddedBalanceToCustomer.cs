namespace Real_Garbo_Collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBalanceToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "balance");
        }
    }
}
