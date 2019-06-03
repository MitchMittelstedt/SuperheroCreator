namespace SuperheroCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Superheroes", "SecondSuperheroAbility", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Superheroes", "SecondSuperheroAbility", c => c.Int(nullable: false));
        }
    }
}
