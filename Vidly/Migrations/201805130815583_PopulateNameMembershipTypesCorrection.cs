namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameMembershipTypesCorrection : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'pay directly' WHERE Id = 1");
            Sql("UPDATE MemberShipTypes SET Name = 'pay monthly' WHERE Id = 2");
            Sql("UPDATE MemberShipTypes SET Name = 'pay quaterly' WHERE Id = 3");
            Sql("UPDATE MemberShipTypes SET Name = 'pay annualy' WHERE Id = 4");

        }

        public override void Down()
        {
        }
    }
}
