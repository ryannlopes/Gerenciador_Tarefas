using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskManagerKidsAPI.Migrations
{
    public partial class updatingTasksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rewards_Tasks_TaskId",
                table: "Rewards");

            migrationBuilder.DropIndex(
                name: "IX_Rewards_TaskId",
                table: "Rewards");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Rewards",
                newName: "Score");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Rewards",
                newName: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_TaskId",
                table: "Rewards",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rewards_Tasks_TaskId",
                table: "Rewards",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
