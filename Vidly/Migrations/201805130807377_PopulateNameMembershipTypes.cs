namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'pay directly'");
            Sql("UPDATE MemberShipTypes SET Name = 'pay monthly'");
            Sql("UPDATE MemberShipTypes SET Name = 'pay quaterly'");
            Sql("UPDATE MemberShipTypes SET Name = 'pay annualy'");
        }
        
        public override void Down()
        {
        }
    }
}
