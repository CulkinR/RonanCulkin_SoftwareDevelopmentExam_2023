namespace RonanCulkin_SoftwareDevelopmentExam_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        NumberOfTickets = c.Int(nullable: false),
                        Movie_MovieID = c.Int(),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID)
                .Index(t => t.Movie_MovieID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImageName = c.String(),
                        Description = c.String(),
                        Cast = c.String(),
                    })
                .PrimaryKey(t => t.MovieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.Bookings", new[] { "Movie_MovieID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Bookings");
        }
    }
}
