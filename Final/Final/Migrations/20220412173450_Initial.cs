using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "submissions",
                columns: table => new
                {
                    QuoteID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quote = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submissions", x => x.QuoteID);
                });

            migrationBuilder.InsertData(
                table: "submissions",
                columns: new[] { "QuoteID", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 1, "Han Solo", "", 1977, "Great, kid, don't get cocky.", "Cinema" });

            migrationBuilder.InsertData(
                table: "submissions",
                columns: new[] { "QuoteID", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 2, "Qui-Gon Jinn", "", 1999, "The ability to speak does not make you intelligent", "Cinema" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "submissions");
        }
    }
}
