using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Kafka.consumer.console.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "value",
                table: "Messages",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "topic",
                table: "Messages",
                newName: "Topic");

            migrationBuilder.RenameColumn(
                name: "key",
                table: "Messages",
                newName: "Key");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Messages",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Messages",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Topic",
                table: "Messages",
                newName: "topic");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Messages",
                newName: "key");
        }
    }
}
