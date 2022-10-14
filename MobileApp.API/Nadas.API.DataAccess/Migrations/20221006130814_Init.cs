using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nadas.API.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpdatedUserId",
                table: "Users",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(7326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(7232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Users",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(6421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Tags",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(6313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(5456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Questions",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(5346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Contents",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(3479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Answers",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(3301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5221));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpdatedUserId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(9463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
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
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
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
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Tags",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Questions",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Contents",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(6103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 9, 15, 23, 13, 531, DateTimeKind.Utc).AddTicks(5433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Answers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
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
                oldDefaultValue: new DateTime(2022, 10, 6, 13, 8, 13, 996, DateTimeKind.Utc).AddTicks(3301));
        }
    }
}
