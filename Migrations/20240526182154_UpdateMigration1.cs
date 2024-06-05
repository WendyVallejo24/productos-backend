using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    public partial class UpdateMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_EstadosPedidos_EstadoIdEstadoPedido",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_NotaVentas_NotaVentaNumeroNota",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Productos_ProductoCodigo",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaVentas_DetallePedido_DetallePedidoIdDetallePedido",
                table: "NotaVentas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_UnidadMedida_UnidadMedidaIdUnidadMed",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadMedida",
                table: "UnidadMedida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotaVentas",
                table: "NotaVentas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosPedidos",
                table: "EstadosPedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoPago",
                table: "EstadoPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallePedido",
                table: "DetallePedido");

            migrationBuilder.RenameTable(
                name: "UnidadMedida",
                newName: "Unidad_medida");

            migrationBuilder.RenameTable(
                name: "NotaVentas",
                newName: "Nota_ventas");

            migrationBuilder.RenameTable(
                name: "EstadosPedidos",
                newName: "Estados_pedidos");

            migrationBuilder.RenameTable(
                name: "EstadoPago",
                newName: "Estado_pago");

            migrationBuilder.RenameTable(
                name: "DetalleVenta",
                newName: "Detalle_venta");

            migrationBuilder.RenameTable(
                name: "DetallePedido",
                newName: "detalle_pedido");

            migrationBuilder.RenameIndex(
                name: "IX_NotaVentas_DetallePedidoIdDetallePedido",
                table: "Nota_ventas",
                newName: "IX_Nota_ventas_DetallePedidoIdDetallePedido");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_ProductoCodigo",
                table: "Detalle_venta",
                newName: "IX_Detalle_venta_ProductoCodigo");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_NotaVentaNumeroNota",
                table: "Detalle_venta",
                newName: "IX_Detalle_venta_NotaVentaNumeroNota");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedido_EstadoIdEstadoPedido",
                table: "detalle_pedido",
                newName: "IX_detalle_pedido_EstadoIdEstadoPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unidad_medida",
                table: "Unidad_medida",
                column: "IdUnidadMed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nota_ventas",
                table: "Nota_ventas",
                column: "NumeroNota");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados_pedidos",
                table: "Estados_pedidos",
                column: "IdEstadoPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado_pago",
                table: "Estado_pago",
                column: "IdEstadoPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detalle_venta",
                table: "Detalle_venta",
                column: "IdDetalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_detalle_pedido",
                table: "detalle_pedido",
                column: "IdDetallePedido");

            migrationBuilder.AddForeignKey(
                name: "FK_detalle_pedido_Estados_pedidos_EstadoIdEstadoPedido",
                table: "detalle_pedido",
                column: "EstadoIdEstadoPedido",
                principalTable: "Estados_pedidos",
                principalColumn: "IdEstadoPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_NotaVentaNumeroNota",
                table: "Detalle_venta",
                column: "NotaVentaNumeroNota",
                principalTable: "Nota_ventas",
                principalColumn: "NumeroNota",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_venta_Productos_ProductoCodigo",
                table: "Detalle_venta",
                column: "ProductoCodigo",
                principalTable: "Productos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_ventas_detalle_pedido_DetallePedidoIdDetallePedido",
                table: "Nota_ventas",
                column: "DetallePedidoIdDetallePedido",
                principalTable: "detalle_pedido",
                principalColumn: "IdDetallePedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Unidad_medida_UnidadMedidaIdUnidadMed",
                table: "Productos",
                column: "UnidadMedidaIdUnidadMed",
                principalTable: "Unidad_medida",
                principalColumn: "IdUnidadMed",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalle_pedido_Estados_pedidos_EstadoIdEstadoPedido",
                table: "detalle_pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_NotaVentaNumeroNota",
                table: "Detalle_venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_venta_Productos_ProductoCodigo",
                table: "Detalle_venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_ventas_detalle_pedido_DetallePedidoIdDetallePedido",
                table: "Nota_ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Unidad_medida_UnidadMedidaIdUnidadMed",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unidad_medida",
                table: "Unidad_medida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nota_ventas",
                table: "Nota_ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados_pedidos",
                table: "Estados_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado_pago",
                table: "Estado_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detalle_venta",
                table: "Detalle_venta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_detalle_pedido",
                table: "detalle_pedido");

            migrationBuilder.RenameTable(
                name: "Unidad_medida",
                newName: "UnidadMedida");

            migrationBuilder.RenameTable(
                name: "Nota_ventas",
                newName: "NotaVentas");

            migrationBuilder.RenameTable(
                name: "Estados_pedidos",
                newName: "EstadosPedidos");

            migrationBuilder.RenameTable(
                name: "Estado_pago",
                newName: "EstadoPago");

            migrationBuilder.RenameTable(
                name: "Detalle_venta",
                newName: "DetalleVenta");

            migrationBuilder.RenameTable(
                name: "detalle_pedido",
                newName: "DetallePedido");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_ventas_DetallePedidoIdDetallePedido",
                table: "NotaVentas",
                newName: "IX_NotaVentas_DetallePedidoIdDetallePedido");

            migrationBuilder.RenameIndex(
                name: "IX_Detalle_venta_ProductoCodigo",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_ProductoCodigo");

            migrationBuilder.RenameIndex(
                name: "IX_Detalle_venta_NotaVentaNumeroNota",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_NotaVentaNumeroNota");

            migrationBuilder.RenameIndex(
                name: "IX_detalle_pedido_EstadoIdEstadoPedido",
                table: "DetallePedido",
                newName: "IX_DetallePedido_EstadoIdEstadoPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadMedida",
                table: "UnidadMedida",
                column: "IdUnidadMed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotaVentas",
                table: "NotaVentas",
                column: "NumeroNota");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosPedidos",
                table: "EstadosPedidos",
                column: "IdEstadoPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoPago",
                table: "EstadoPago",
                column: "IdEstadoPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta",
                column: "IdDetalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallePedido",
                table: "DetallePedido",
                column: "IdDetallePedido");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_EstadosPedidos_EstadoIdEstadoPedido",
                table: "DetallePedido",
                column: "EstadoIdEstadoPedido",
                principalTable: "EstadosPedidos",
                principalColumn: "IdEstadoPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_NotaVentas_NotaVentaNumeroNota",
                table: "DetalleVenta",
                column: "NotaVentaNumeroNota",
                principalTable: "NotaVentas",
                principalColumn: "NumeroNota",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Productos_ProductoCodigo",
                table: "DetalleVenta",
                column: "ProductoCodigo",
                principalTable: "Productos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaVentas_DetallePedido_DetallePedidoIdDetallePedido",
                table: "NotaVentas",
                column: "DetallePedidoIdDetallePedido",
                principalTable: "DetallePedido",
                principalColumn: "IdDetallePedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_UnidadMedida_UnidadMedidaIdUnidadMed",
                table: "Productos",
                column: "UnidadMedidaIdUnidadMed",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMed",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
