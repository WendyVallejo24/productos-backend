using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    public partial class UpdateDetallePedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalle_pedido_Estados_pedidos_EstadoIdEstadoPedido",
                table: "detalle_pedido");

            migrationBuilder.DropIndex(
                name: "IX_detalle_pedido_EstadoIdEstadoPedido",
                table: "detalle_pedido");

            migrationBuilder.DropColumn(
                name: "EstadoIdEstadoPedido",
                table: "detalle_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_pedido_id_estado",
                table: "detalle_pedido",
                column: "id_estado");

            migrationBuilder.AddForeignKey(
                name: "FK_detalle_pedido_Estados_pedidos_id_estado",
                table: "detalle_pedido",
                column: "id_estado",
                principalTable: "Estados_pedidos",
                principalColumn: "id_estado",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalle_pedido_Estados_pedidos_id_estado",
                table: "detalle_pedido");

            migrationBuilder.DropIndex(
                name: "IX_detalle_pedido_id_estado",
                table: "detalle_pedido");

            migrationBuilder.AddColumn<int>(
                name: "EstadoIdEstadoPedido",
                table: "detalle_pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_detalle_pedido_EstadoIdEstadoPedido",
                table: "detalle_pedido",
                column: "EstadoIdEstadoPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_detalle_pedido_Estados_pedidos_EstadoIdEstadoPedido",
                table: "detalle_pedido",
                column: "EstadoIdEstadoPedido",
                principalTable: "Estados_pedidos",
                principalColumn: "id_estado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
