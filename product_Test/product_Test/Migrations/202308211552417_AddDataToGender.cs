namespace product_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToGender : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genders values('Male')");
            Sql("Insert into Genders values('Female')");
        }
        
        public override void Down()
        {
        }
    }
}
