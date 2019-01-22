namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCategoryDescription : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.product_categories", "category_description");
        }

        public override void Down()
        {
            AddColumn("dbo.product_categories", "category_description", c => c.String(maxLength: 300));
        }
    }
}
