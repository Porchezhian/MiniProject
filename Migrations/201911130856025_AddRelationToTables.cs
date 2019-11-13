namespace FreeLancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationToTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Freelancers", "Hirer_Id", c => c.Int());
            CreateIndex("dbo.Freelancers", "Hirer_Id");
            AddForeignKey("dbo.Freelancers", "Hirer_Id", "dbo.Hirers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Freelancers", "Hirer_Id", "dbo.Hirers");
            DropIndex("dbo.Freelancers", new[] { "Hirer_Id" });
            DropColumn("dbo.Freelancers", "Hirer_Id");
        }
    }
}
