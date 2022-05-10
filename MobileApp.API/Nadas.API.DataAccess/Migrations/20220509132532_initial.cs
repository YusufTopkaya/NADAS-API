using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nadas.API.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(2209)),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(2371)),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(881)),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1054)),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AuthLevel = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1516)),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(1666)),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Rate = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(9884)),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 551, DateTimeKind.Utc).AddTicks(45)),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Contents_Id",
                        column: x => x.Id,
                        principalTable: "Contents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Questions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(1408)),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 9, 13, 25, 32, 550, DateTimeKind.Utc).AddTicks(1599)),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Answers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTag",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTag", x => new { x.QuestionsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_QuestionTag_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_ContentId",
                table: "Answers",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                table: "Questions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTag_TagsId",
                table: "QuestionTag",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "QuestionTag");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
