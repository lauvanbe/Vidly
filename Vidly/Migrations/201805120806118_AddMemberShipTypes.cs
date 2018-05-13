namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonth = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShipTpeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipTypes_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipTypes_Id");
            AddForeignKey("dbo.Customers", "MembershipTypes_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypes_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypes_Id" });
            DropColumn("dbo.Customers", "MembershipTypes_Id");
            DropColumn("dbo.Customers", "MemberShipTpeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
