namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MemberShipTpeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipTpeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MemberShipTypeId");
        }
    }
}
