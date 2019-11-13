namespace FreeLancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDomain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Domains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Domain = c.String(),
                        Vacany = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Freelancers", "Experience", c => c.Int(nullable: false));
            AddColumn("dbo.Freelancers", "Domains", c => c.String());
            AddColumn("dbo.Freelancers", "Technologies", c => c.String());
            AddColumn("dbo.Freelancers", "Domain_Id", c => c.Int());
            CreateIndex("dbo.Freelancers", "Domain_Id");
            AddForeignKey("dbo.Freelancers", "Domain_Id", "dbo.Domains", "Id");
            DropColumn("dbo.Freelancers", "exp");
            DropColumn("dbo.Freelancers", "Domain");
            DropColumn("dbo.Freelancers", "Technology");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Freelancers", "Technology", c => c.String());
            AddColumn("dbo.Freelancers", "Domain", c => c.String());
            AddColumn("dbo.Freelancers", "exp", c => c.Int(nullable: false));
            DropForeignKey("dbo.Freelancers", "Domain_Id", "dbo.Domains");
            DropIndex("dbo.Freelancers", new[] { "Domain_Id" });
            DropColumn("dbo.Freelancers", "Domain_Id");
            DropColumn("dbo.Freelancers", "Technologies");
            DropColumn("dbo.Freelancers", "Domains");
            DropColumn("dbo.Freelancers", "Experience");
            DropTable("dbo.Domains");
        }
    }
}
