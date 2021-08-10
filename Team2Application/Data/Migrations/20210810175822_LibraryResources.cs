using Microsoft.EntityFrameworkCore.Migrations;

namespace Team2Application.Data.Migrations
{
    public partial class LibraryResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InternId",
                table: "Skill",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "LibraryResource",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_InternId",
                table: "Skill",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryResource_SkillId",
                table: "LibraryResource",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryResource_Skill_SkillId",
                table: "LibraryResource",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_Intern_InternId",
                table: "Skill",
                column: "InternId",
                principalTable: "Intern",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryResource_Skill_SkillId",
                table: "LibraryResource");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Intern_InternId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_InternId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_LibraryResource_SkillId",
                table: "LibraryResource");

            migrationBuilder.DropColumn(
                name: "InternId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "LibraryResource");
        }
    }
}
