using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_cliente",
                table: "Nota_ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_detalle_venta",
                table: "Nota_ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDetalleVenta",
                table: "Detalle_venta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id_cliente);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nota_ventas_id_cliente",
                table: "Nota_ventas",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_venta_IdDetalleVenta",
                table: "Detalle_venta",
                column: "IdDetalleVenta");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_IdDetalleVenta",
                table: "Detalle_venta",
                column: "IdDetalleVenta",
                principalTable: "Nota_ventas",
                principalColumn: "numero_nota");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_ventas_Clientes_id_cliente",
                table: "Nota_ventas",
                column: "id_cliente",
                principalTable: "Clientes",
                principalColumn: "id_cliente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_IdDetalleVenta",
                table: "Detalle_venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_ventas_Clientes_id_cliente",
                table: "Nota_ventas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Nota_ventas_id_cliente",
                table: "Nota_ventas");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_venta_IdDetalleVenta",
                table: "Detalle_venta");

            migrationBuilder.DropColumn(
                name: "id_cliente",
                table: "Nota_ventas");

            migrationBuilder.DropColumn(
                name: "id_detalle_venta",
                table: "Nota_ventas");

            migrationBuilder.DropColumn(
                name: "IdDetalleVenta",
                table: "Detalle_venta");
        }
    }
}
