using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Productos_Categorias_CategoriaIdCategoria",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_MarcaIdMarca",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Unidad_medida_UnidadMedidaIdUnidadMed",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CategoriaIdCategoria",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_MarcaIdMarca",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_UnidadMedidaIdUnidadMed",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Nota_ventas_DetallePedidoIdDetallePedido",
                table: "Nota_ventas");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_venta_NotaVentaNumeroNota",
                table: "Detalle_venta");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_venta_ProductoCodigo",
                table: "Detalle_venta");

            migrationBuilder.DropColumn(
                name: "CategoriaIdCategoria",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "MarcaIdMarca",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UnidadMedidaIdUnidadMed",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DetallePedidoIdDetallePedido",
                table: "Nota_ventas");

            migrationBuilder.DropColumn(
                name: "NotaVentaNumeroNota",
                table: "Detalle_venta");

            migrationBuilder.DropColumn(
                name: "ProductoCodigo",
                table: "Detalle_venta");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Unidad_medida",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdUnidadMed",
                table: "Unidad_medida",
                newName: "id_unidad_med");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Productos",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Productos",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "IdUnidadMed",
                table: "Productos",
                newName: "id_unidad_med");

            migrationBuilder.RenameColumn(
                name: "IdMarca",
                table: "Productos",
                newName: "id_marca");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Productos",
                newName: "id_categoria");

            migrationBuilder.RenameColumn(
                name: "Existencia",
                table: "Productos",
                newName: "exitencia");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Marcas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdMarca",
                table: "Marcas",
                newName: "id_marca");

            migrationBuilder.RenameColumn(
                name: "Subtotal",
                table: "Detalle_venta",
                newName: "subtotal");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Detalle_venta",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Detalle_venta",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Detalle_venta",
                newName: "cantidad");

            migrationBuilder.RenameColumn(
                name: "NumeroNota",
                table: "Detalle_venta",
                newName: "numero_nota");

            migrationBuilder.RenameColumn(
                name: "IdDetalle",
                table: "Detalle_venta",
                newName: "id_detalle");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_id_categoria",
                table: "Productos",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_id_marca",
                table: "Productos",
                column: "id_marca");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_id_unidad_med",
                table: "Productos",
                column: "id_unidad_med");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_ventas_id_detalle_pedido",
                table: "Nota_ventas",
                column: "id_detalle_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_venta_codigo",
                table: "Detalle_venta",
                column: "codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_venta_numero_nota",
                table: "Detalle_venta",
                column: "numero_nota");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_numero_nota",
                table: "Detalle_venta",
                column: "numero_nota",
                principalTable: "Nota_ventas",
                principalColumn: "numero_nota",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_venta_Productos_codigo",
                table: "Detalle_venta",
                column: "codigo",
                principalTable: "Productos",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_ventas_detalle_pedido_id_detalle_pedido",
                table: "Nota_ventas",
                column: "id_detalle_pedido",
                principalTable: "detalle_pedido",
                principalColumn: "id_detalle_pedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_id_categoria",
                table: "Productos",
                column: "id_categoria",
                principalTable: "Categorias",
                principalColumn: "id_categoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_id_marca",
                table: "Productos",
                column: "id_marca",
                principalTable: "Marcas",
                principalColumn: "id_marca",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Unidad_medida_id_unidad_med",
                table: "Productos",
                column: "id_unidad_med",
                principalTable: "Unidad_medida",
                principalColumn: "id_unidad_med",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_numero_nota",
                table: "Detalle_venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_venta_Productos_codigo",
                table: "Detalle_venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_ventas_detalle_pedido_id_detalle_pedido",
                table: "Nota_ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_id_categoria",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_id_marca",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Unidad_medida_id_unidad_med",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_id_categoria",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_id_marca",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_id_unidad_med",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Nota_ventas_id_detalle_pedido",
                table: "Nota_ventas");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_venta_codigo",
                table: "Detalle_venta");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_venta_numero_nota",
                table: "Detalle_venta");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Unidad_medida",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "id_unidad_med",
                table: "Unidad_medida",
                newName: "IdUnidadMed");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Productos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Productos",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "id_unidad_med",
                table: "Productos",
                newName: "IdUnidadMed");

            migrationBuilder.RenameColumn(
                name: "id_marca",
                table: "Productos",
                newName: "IdMarca");

            migrationBuilder.RenameColumn(
                name: "id_categoria",
                table: "Productos",
                newName: "IdCategoria");

            migrationBuilder.RenameColumn(
                name: "exitencia",
                table: "Productos",
                newName: "Existencia");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Marcas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "id_marca",
                table: "Marcas",
                newName: "IdMarca");

            migrationBuilder.RenameColumn(
                name: "subtotal",
                table: "Detalle_venta",
                newName: "Subtotal");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Detalle_venta",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Detalle_venta",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Detalle_venta",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "numero_nota",
                table: "Detalle_venta",
                newName: "NumeroNota");

            migrationBuilder.RenameColumn(
                name: "id_detalle",
                table: "Detalle_venta",
                newName: "IdDetalle");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaIdCategoria",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MarcaIdMarca",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadMedidaIdUnidadMed",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DetallePedidoIdDetallePedido",
                table: "Nota_ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotaVentaNumeroNota",
                table: "Detalle_venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductoCodigo",
                table: "Detalle_venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaIdCategoria",
                table: "Productos",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaIdMarca",
                table: "Productos",
                column: "MarcaIdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_UnidadMedidaIdUnidadMed",
                table: "Productos",
                column: "UnidadMedidaIdUnidadMed");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_ventas_DetallePedidoIdDetallePedido",
                table: "Nota_ventas",
                column: "DetallePedidoIdDetallePedido");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_venta_NotaVentaNumeroNota",
                table: "Detalle_venta",
                column: "NotaVentaNumeroNota");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_venta_ProductoCodigo",
                table: "Detalle_venta",
                column: "ProductoCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_venta_Nota_ventas_NotaVentaNumeroNota",
                table: "Detalle_venta",
                column: "NotaVentaNumeroNota",
                principalTable: "Nota_ventas",
                principalColumn: "numero_nota",
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
                principalColumn: "id_detalle_pedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaIdCategoria",
                table: "Productos",
                column: "CategoriaIdCategoria",
                principalTable: "Categorias",
                principalColumn: "id_categoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_MarcaIdMarca",
                table: "Productos",
                column: "MarcaIdMarca",
                principalTable: "Marcas",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Unidad_medida_UnidadMedidaIdUnidadMed",
                table: "Productos",
                column: "UnidadMedidaIdUnidadMed",
                principalTable: "Unidad_medida",
                principalColumn: "IdUnidadMed",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
