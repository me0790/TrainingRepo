namespace EfCodeFirstHomework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToVideoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Category");
        }
    }
}
