using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nadas.API.DataAccess.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Contents_Id",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Contents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(7916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(5932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ContentId",
                table: "Questions",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Contents_ContentId",
                table: "Questions",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Contents_ContentId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ContentId",
                table: "Questions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(45),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(9884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(2209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(1599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(1408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Contents_Id",
                table: "Questions",
                column: "Id",
                principalTable: "Contents",
                principalColumn: "Id");
        }
    }
}
