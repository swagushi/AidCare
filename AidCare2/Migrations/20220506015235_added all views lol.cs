using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AidCare2.Migrations
{
    public partial class addedallviewslol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    eventsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eventsVenue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventsDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.eventsID);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    membersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.membersId);
                });

            migrationBuilder.CreateTable(
                name: "donations",
                columns: table => new
                {
                    donationsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonationsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donationsAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    membersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donations", x => x.donationsID);
                    table.ForeignKey(
                        name: "FK_donations_members_membersID",
                        column: x => x.membersID,
                        principalTable: "members",
                        principalColumn: "membersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_donations_membersID",
                table: "donations",
                column: "membersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "donations");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "members");
        }
    }
}
