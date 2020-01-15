namespace Real_Garbo_Collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PickUpdate = c.String(),
                        StreetAddress = c.String(),
                        SuspendStart = c.String(),
                        SuspendEnd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.People");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Customers");
        }
    }
}
