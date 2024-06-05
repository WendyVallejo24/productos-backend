using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    public partial class UpdateMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Nota_ventas",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Nota_ventas",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "IdDetallePedido",
                table: "Nota_ventas",
                newName: "id_detalle_pedido");

            migrationBuilder.RenameColumn(
                name: "NumeroNota",
                table: "Nota_ventas",
                newName: "numero_nota");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Estados_pedidos",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "IdEstadoPedido",
                table: "Estados_pedidos",
                newName: "id_estado");

            migrationBuilder.RenameColumn(
                name: "IdEstadoPago",
                table: "Estado_pago",
                newName: "id_estado_pago");

            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "detalle_pedido",
                newName: "id_estado");

            migrationBuilder.RenameColumn(
                name: "FechaEntrega",
                table: "detalle_pedido",
                newName: "fecha_entrega");

            migrationBuilder.RenameColumn(
                name: "IdDetallePedido",
                table: "detalle_pedido",
                newName: "id_detalle_pedido");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Categorias",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Categorias",
                newName: "id_categoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "total",
                table: "Nota_ventas",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Nota_ventas",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "id_detalle_pedido",
                table: "Nota_ventas",
                newName: "IdDetallePedido");

            migrationBuilder.RenameColumn(
                name: "numero_nota",
                table: "Nota_ventas",
                newName: "NumeroNota");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Estados_pedidos",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id_estado",
                table: "Estados_pedidos",
                newName: "IdEstadoPedido");

            migrationBuilder.RenameColumn(
                name: "id_estado_pago",
                table: "Estado_pago",
                newName: "IdEstadoPago");

            migrationBuilder.RenameColumn(
                name: "id_estado",
                table: "detalle_pedido",
                newName: "IdEstado");

            migrationBuilder.RenameColumn(
                name: "fecha_entrega",
                table: "detalle_pedido",
                newName: "FechaEntrega");

            migrationBuilder.RenameColumn(
                name: "id_detalle_pedido",
                table: "detalle_pedido",
                newName: "IdDetallePedido");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Categorias",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "id_categoria",
                table: "Categorias",
                newName: "IdCategoria");
        }
    }
}
