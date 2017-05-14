namespace _123456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTelToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Telephone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Telephone");

        }
    }
}
