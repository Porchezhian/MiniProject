namespace FreeLancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHirers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hirers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        MobileNumber = c.Int(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Freelancers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Freelancers", "Email");
            DropTable("dbo.Hirers");
        }
    }
}
