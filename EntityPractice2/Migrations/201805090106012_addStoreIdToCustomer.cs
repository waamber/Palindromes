namespace EntityPractice2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStoreIdToCustomer : DbMigration
    {
        public override void Up()
        {
			AddColumn("dbo.Customers", "StoreId", c => c.Int());
        }
        
        public override void Down()
        {
        }
    }
}
