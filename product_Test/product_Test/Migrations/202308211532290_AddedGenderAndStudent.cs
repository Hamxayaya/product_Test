namespace product_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenderAndStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Lastname = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        GenderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GenderId", "dbo.Genders");
            DropIndex("dbo.Students", new[] { "GenderId" });
            DropTable("dbo.Students");
            DropTable("dbo.Genders");
        }
    }
}
