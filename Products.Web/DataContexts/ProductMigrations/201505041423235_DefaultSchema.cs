namespace Products.Web.DataContexts.ProductMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultSchema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Products", newSchema: "catalog");
        }
        
        public override void Down()
        {
            MoveTable(name: "catalog.Products", newSchema: "dbo");
        }
    }
}
