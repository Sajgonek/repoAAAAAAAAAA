namespace ZOH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedIdAsIdentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Rooms");
            AlterColumn("dbo.Customers", "Id", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.Rooms", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Rooms", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Rooms");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Rooms", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Rooms", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
        }
    }
}
