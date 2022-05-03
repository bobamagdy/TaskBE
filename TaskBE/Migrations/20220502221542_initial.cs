using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBE.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DemographicTypeTbl",
                columns: table => new
                {
                    DemTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDescAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TypeDescEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemographicTypeTbl", x => x.DemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DemographicTypeDTLTbl",
                columns: table => new
                {
                    DemTypeDTL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemTypeID = table.Column<int>(type: "int", nullable: false),
                    ChoicesAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ChoicesEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WeightValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemographicTypeDTLTbl", x => x.DemTypeDTL_ID);
                    table.ForeignKey(
                        name: "FK_DemographicTypeDTLTbl_DemographicTypeTbl_DemTypeID",
                        column: x => x.DemTypeID,
                        principalTable: "DemographicTypeTbl",
                        principalColumn: "DemTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemographicTypeDTLTbl_DemTypeID",
                table: "DemographicTypeDTLTbl",
                column: "DemTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemographicTypeDTLTbl");

            migrationBuilder.DropTable(
                name: "DemographicTypeTbl");
        }
    }
}
