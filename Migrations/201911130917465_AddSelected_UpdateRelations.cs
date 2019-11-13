namespace FreeLancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSelected_UpdateRelations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Selecteds",
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
                        SkillLevel = c.String(),
                        Experience = c.Int(nullable: false),
                        Domains = c.String(),
                        Technologies = c.String(),
                        Salary = c.Int(nullable: false),
                        Hirer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hirers", t => t.Hirer_Id)
                .Index(t => t.Hirer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Selecteds", "Hirer_Id", "dbo.Hirers");
            DropIndex("dbo.Selecteds", new[] { "Hirer_Id" });
            DropTable("dbo.Selecteds");
        }
    }
}
