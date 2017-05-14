namespace _123456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredToCustomerEmail : DbMigration
    {
        public override void Up()
        {
            Sql("update customers set email = '' where email = null");
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
        }
    }
}
