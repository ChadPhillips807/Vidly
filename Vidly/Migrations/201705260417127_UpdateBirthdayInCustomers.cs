namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdayInCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = CAST('2009-05-25' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET Birthday = CAST(NULL AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
