using Microsoft.EntityFrameworkCore.Migrations;

namespace AgregatorLinkowProc.Migrations
{
    public partial class create_index_on_date_in_post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Posts_Date",
                table: "Posts",
                column: "Date",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Posts_Date",
                table: "Posts");
        }
    }
}
