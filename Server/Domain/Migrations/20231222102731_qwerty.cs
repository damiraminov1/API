using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class qwerty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataInputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Wstart = table.Column<double>(type: "float", nullable: false),
                    Wend = table.Column<double>(type: "float", nullable: false),
                    percentCp = table.Column<double>(type: "float", nullable: false),
                    percentHp = table.Column<double>(type: "float", nullable: false),
                    percentSp = table.Column<double>(type: "float", nullable: false),
                    percentOp = table.Column<double>(type: "float", nullable: false),
                    percentNp = table.Column<double>(type: "float", nullable: false),
                    percentAp = table.Column<double>(type: "float", nullable: false),
                    percentWp = table.Column<double>(type: "float", nullable: false),
                    t1 = table.Column<double>(type: "float", nullable: false),
                    t2 = table.Column<double>(type: "float", nullable: false),
                    alpha = table.Column<double>(type: "float", nullable: false),
                    eta = table.Column<double>(type: "float", nullable: false),
                    tair = table.Column<double>(type: "float", nullable: false),
                    tgase = table.Column<double>(type: "float", nullable: false),
                    tm1 = table.Column<double>(type: "float", nullable: false),
                    Gt = table.Column<double>(type: "float", nullable: false),
                    Him = table.Column<double>(type: "float", nullable: false),
                    k = table.Column<double>(type: "float", nullable: false),
                    Cgase = table.Column<double>(type: "float", nullable: false),
                    Cmaterial = table.Column<double>(type: "float", nullable: false),
                    Cwet = table.Column<double>(type: "float", nullable: false),
                    enthalpy100 = table.Column<double>(type: "float", nullable: false),
                    D = table.Column<double>(type: "float", nullable: false),
                    L = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataInputs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "DataInputs",
                columns: new[] { "Id", "Cgase", "Cmaterial", "Cwet", "D", "Description", "Gt", "Him", "IsActive", "L", "Name", "UserId", "Wend", "Wstart", "alpha", "enthalpy100", "eta", "k", "percentAp", "percentCp", "percentHp", "percentNp", "percentOp", "percentSp", "percentWp", "t1", "t2", "tair", "tgase", "tm1" },
                values: new object[] { 3, 0.83499999999999996, 0.88, 4.1900000000000004, 1.0, "Пример", 1.75, 0.02, true, 4.0, "Шаблонный вариант", 0, 0.5, 10.0, 1.2, 2675.0, 0.90000000000000002, 3.7599999999999998, 0.29999999999999999, 86.599999999999994, 10.4, 0.59999999999999998, 0.40000000000000002, 0.90000000000000002, 0.80000000000000004, 850.0, 460.0, 20.0, 20.0, 40.0 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Password", "RoleId" },
                values: new object[] { 1, "admin", "admin", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataInputs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
