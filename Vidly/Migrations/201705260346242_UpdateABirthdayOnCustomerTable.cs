namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateABirthdayOnCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '01/01/1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
