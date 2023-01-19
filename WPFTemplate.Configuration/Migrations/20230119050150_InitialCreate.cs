using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPFTemplate.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "menu_config",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    iconname = table.Column<string>(name: "icon_name", type: "varchar(200)", nullable: true),
                    name = table.Column<string>(type: "varchar(200)", nullable: true),
                    targetctlname = table.Column<string>(name: "target_ctl_name", type: "varchar(200)", nullable: true),
                    queriestext = table.Column<string>(name: "queries_text", type: "varchar(200)", nullable: true),
                    isvisible = table.Column<bool>(name: "is_visible", type: "int", nullable: true),
                    updatetime = table.Column<DateTime>(name: "update_time", type: "TEXT", nullable: true),
                    createtime = table.Column<DateTime>(name: "create_time", type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu_config", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "option_config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    optionname = table.Column<string>(name: "option_name", type: "TEXT", nullable: true),
                    optiongroup = table.Column<string>(name: "option_group", type: "TEXT", nullable: true),
                    optionkey = table.Column<string>(name: "option_key", type: "TEXT", nullable: true),
                    optionvalue = table.Column<string>(name: "option_value", type: "TEXT", nullable: true),
                    optionpriority = table.Column<int>(name: "option_priority", type: "INTEGER", nullable: true),
                    optionstatus = table.Column<int>(name: "option_status", type: "INTEGER", nullable: true),
                    optiondesc = table.Column<string>(name: "option_desc", type: "TEXT", nullable: true),
                    updatetime = table.Column<DateTime>(name: "update_time", type: "TEXT", nullable: true),
                    createtime = table.Column<DateTime>(name: "create_time", type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_option_config", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "option_group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    groupkey = table.Column<string>(name: "group_key", type: "varchar(200)", nullable: false),
                    groupname = table.Column<string>(name: "group_name", type: "varchar(200)", nullable: true),
                    groupdesc = table.Column<string>(name: "group_desc", type: "varchar(200)", nullable: true),
                    grouptype = table.Column<int>(name: "group_type", type: "int", nullable: true),
                    updatetime = table.Column<DateTime>(name: "update_time", type: "TEXT", nullable: true),
                    createtime = table.Column<DateTime>(name: "create_time", type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_option_group", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menu_config");

            migrationBuilder.DropTable(
                name: "option_config");

            migrationBuilder.DropTable(
                name: "option_group");
        }
    }
}
