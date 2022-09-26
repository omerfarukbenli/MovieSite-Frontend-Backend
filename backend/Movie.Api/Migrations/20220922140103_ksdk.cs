using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Api.Migrations
{
    public partial class ksdk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anasayfas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anasayfas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anasayfas1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anasayfas1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animasyons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animasyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animasyons1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animasyons1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avrupas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avrupas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avrupas1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avrupas1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dizis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dizis1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizis1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hollywoods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hollywoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hollywoods1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hollywoods1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Olmedens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olmedens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Olmedens1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olmedens1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oscars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oscars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oscars1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oscars1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seris1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextMovieSource = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seris1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anasayfas");

            migrationBuilder.DropTable(
                name: "Anasayfas1");

            migrationBuilder.DropTable(
                name: "Animasyons");

            migrationBuilder.DropTable(
                name: "Animasyons1");

            migrationBuilder.DropTable(
                name: "Avrupas");

            migrationBuilder.DropTable(
                name: "Avrupas1");

            migrationBuilder.DropTable(
                name: "Dizis");

            migrationBuilder.DropTable(
                name: "Dizis1");

            migrationBuilder.DropTable(
                name: "Hollywoods");

            migrationBuilder.DropTable(
                name: "Hollywoods1");

            migrationBuilder.DropTable(
                name: "Olmedens");

            migrationBuilder.DropTable(
                name: "Olmedens1");

            migrationBuilder.DropTable(
                name: "Oscars");

            migrationBuilder.DropTable(
                name: "Oscars1");

            migrationBuilder.DropTable(
                name: "Seris");

            migrationBuilder.DropTable(
                name: "Seris1");
        }
    }
}
