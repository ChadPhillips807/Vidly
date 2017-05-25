namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesWithName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET  Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET  Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET  Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET  Name = 'Annual' WHERE Id = 4");

            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (1, 0, 0, 0, 'Pay as You Go')");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (2, 30, 1, 10, 'Monthly')");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (3, 90, 3, 15, 'Quarterly')");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (4, 300, 12, 20, 'Annual')");
        }
        
        public override void Down()
        {
        }
    }
}
