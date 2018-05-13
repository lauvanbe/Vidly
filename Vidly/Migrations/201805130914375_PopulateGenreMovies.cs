using System.Diagnostics.Eventing.Reader;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreMovies : DbMigration
    {
        public override void Up()
        {
//            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy') SET IDENTITY_INSERT Genres ON");
//            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action') SET IDENTITY_INSERT Genres ON");
//            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family') SET IDENTITY_INSERT Genres ON");
//            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance') SET IDENTITY_INSERT Genres ON");

        }

        public override void Down()
        {
        }
    }
}
