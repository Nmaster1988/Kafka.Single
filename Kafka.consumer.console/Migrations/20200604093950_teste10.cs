using Microsoft.EntityFrameworkCore.Migrations;

namespace Kafka.consumer.console.Migrations
{
    public partial class teste10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Offset",
                table: "Messages",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Offset",
                table: "Messages");
        }
    }
}
