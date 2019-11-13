namespace FreeLancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFreeLancers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Freelancers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        MobileNumber = c.Int(nullable: false),
                        Address = c.String(),
                        SkillLevel = c.String(),
                        exp = c.Int(nullable: false),
                        Domain = c.String(),
                        Technology = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Freelancers");
        }
    }
}
