using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogSensores_API.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CamionId = table.Column<int>(type: "int", nullable: true),
                    Kilometraje = table.Column<double>(type: "float", nullable: false),
                    EstadoMotor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoSensor = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlertaMantenimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SensorId = table.Column<int>(type: "int", nullable: false),
                    AlertaReparacion = table.Column<bool>(type: "bit", nullable: false),
                    Cambio = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertaMantenimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlertaMantenimiento_Sensor_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlertaMantenimiento_SensorId",
                table: "AlertaMantenimiento",
                column: "SensorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlertaMantenimiento");

            migrationBuilder.DropTable(
                name: "Sensor");
        }
    }
}
