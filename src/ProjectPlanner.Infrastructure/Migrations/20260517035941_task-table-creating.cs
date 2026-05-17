using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPlanner.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tasktablecreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TASKS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    PROJECT_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    TITLE = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    TASK_STATUS = table.Column<string>(type: "text", nullable: false),
                    TASK_PRIORITY = table.Column<string>(type: "text", nullable: false),
                    DUE_DATE = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ASSIGNED_TO = table.Column<Guid>(type: "uuid", nullable: false),
                    VERSION = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASKS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TASKS_PROJECTS_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TASKS_PROJECT_USERS_ASSIGNED_TO",
                        column: x => x.ASSIGNED_TO,
                        principalTable: "PROJECT_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TASKS_ASSIGNED_TO",
                table: "TASKS",
                column: "ASSIGNED_TO");

            migrationBuilder.CreateIndex(
                name: "IX_TASKS_PROJECT_ID",
                table: "TASKS",
                column: "PROJECT_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TASKS");
        }
    }
}
