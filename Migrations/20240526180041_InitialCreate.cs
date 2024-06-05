using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPago",
                columns: table => new
                {
                    IdEstadoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPago", x => x.IdEstadoPago);
                });

            migrationBuilder.CreateTable(
                name: "EstadosPedidos",
                columns: table => new
                {
                    IdEstadoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosPedidos", x => x.IdEstadoPedido);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedida",
                columns: table => new
                {
                    IdUnidadMed = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedida", x => x.IdUnidadMed);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    IdDetallePedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    EstadoIdEstadoPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.IdDetallePedido);
                    table.ForeignKey(
                        name: "FK_DetallePedido_EstadosPedidos_EstadoIdEstadoPedido",
                        column: x => x.EstadoIdEstadoPedido,
                        principalTable: "EstadosPedidos",
                        principalColumn: "IdEstadoPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    CategoriaIdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    MarcaIdMarca = table.Column<int>(type: "int", nullable: false),
                    IdUnidadMed = table.Column<int>(type: "int", nullable: false),
                    UnidadMedidaIdUnidadMed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_MarcaIdMarca",
                        column: x => x.MarcaIdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_UnidadMedida_UnidadMedidaIdUnidadMed",
                        column: x => x.UnidadMedidaIdUnidadMed,
                        principalTable: "UnidadMedida",
                        principalColumn: "IdUnidadMed",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaVentas",
                columns: table => new
                {
                    NumeroNota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdDetallePedido = table.Column<int>(type: "int", nullable: false),
                    DetallePedidoIdDetallePedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaVentas", x => x.NumeroNota);
                    table.ForeignKey(
                        name: "FK_NotaVentas_DetallePedido_DetallePedidoIdDetallePedido",
                        column: x => x.DetallePedidoIdDetallePedido,
                        principalTable: "DetallePedido",
                        principalColumn: "IdDetallePedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    IdDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    ProductoCodigo = table.Column<int>(type: "int", nullable: false),
                    NumeroNota = table.Column<int>(type: "int", nullable: false),
                    NotaVentaNumeroNota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_NotaVentas_NotaVentaNumeroNota",
                        column: x => x.NotaVentaNumeroNota,
                        principalTable: "NotaVentas",
                        principalColumn: "NumeroNota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Productos_ProductoCodigo",
                        column: x => x.ProductoCodigo,
                        principalTable: "Productos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_EstadoIdEstadoPedido",
                table: "DetallePedido",
                column: "EstadoIdEstadoPedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_NotaVentaNumeroNota",
                table: "DetalleVenta",
                column: "NotaVentaNumeroNota");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_ProductoCodigo",
                table: "DetalleVenta",
                column: "ProductoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_NotaVentas_DetallePedidoIdDetallePedido",
                table: "NotaVentas",
                column: "DetallePedidoIdDetallePedido");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "EstadoPago");

            migrationBuilder.DropTable(
                name: "NotaVentas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "UnidadMedida");

            migrationBuilder.DropTable(
                name: "EstadosPedidos");
        }
    }
}
