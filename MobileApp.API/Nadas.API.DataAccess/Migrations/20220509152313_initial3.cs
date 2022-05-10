using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nadas.API.DataAccess.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Users_UserId",
                table: "Answers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "Users",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.AlterColumn<int>(
                name: "AuthLevel",
                table: "Users",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Answers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "Answers",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Users_UserId",
                table: "Answers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Users_UserId",
                table: "Answers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.AlterColumn<int>(
                name: "AuthLevel",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(9014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(8073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(7916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 13, 27, 44, 909, DateTimeKind.Utc).AddTicks(5932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Users_UserId",
                table: "Answers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
