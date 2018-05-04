namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRentals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Costumer_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Costumer_Id");
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Costumer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
            DropColumn("dbo.Rentals", "CostumerId");
            DropColumn("dbo.Rentals", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "MovieId", c => c.Int(nullable: false));
            AddColumn("dbo.Rentals", "CostumerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Costumer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Costumer_Id" });
            DropColumn("dbo.Rentals", "Movie_Id");
            DropColumn("dbo.Rentals", "Costumer_Id");
        }
    }
}
