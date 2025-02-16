﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoUsabilidad.Data;

#nullable disable

namespace proyectoUsabilidad.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proyectoUsabilidad.Models.Categorias", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.Clientes", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("apellidos");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("direccion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telefono");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.DetallePedido", b =>
                {
                    b.Property<int>("IdDetallePedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_detalle_pedido");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetallePedido"), 1L, 1);

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_entrega");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("id_estado");

                    b.HasKey("IdDetallePedido");

                    b.HasIndex("IdEstado");

                    b.ToTable("detalle_pedido");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.DetalleVenta", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_detalle");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalle"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int>("Codigo")
                        .HasColumnType("int")
                        .HasColumnName("codigo");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<int?>("IdDetalleVenta")
                        .HasColumnType("int");

                    b.Property<int>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("numero_nota");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("subtotal");

                    b.HasKey("IdDetalle");

                    b.HasIndex("Codigo");

                    b.HasIndex("IdDetalleVenta");

                    b.HasIndex("NumeroNota");

                    b.ToTable("Detalle_venta");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.EstadoPago", b =>
                {
                    b.Property<int>("IdEstadoPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_estado_pago");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstadoPago"), 1L, 1);

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.HasKey("IdEstadoPago");

                    b.ToTable("Estado_pago");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.EstadoPedidos", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_estado");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"), 1L, 1);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.HasKey("IdEstado");

                    b.ToTable("Estados_pedidos");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.Marcas", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_marca");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarca"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("IdMarca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.NotaVentas", b =>
                {
                    b.Property<int>("NumeroNota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("numero_nota");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroNota"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    b.Property<int>("IdDetallePedido")
                        .HasColumnType("int")
                        .HasColumnName("id_detalle_pedido");

                    b.Property<int>("IdDetalleVenta")
                        .HasColumnType("int")
                        .HasColumnName("id_detalle_venta");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("total");

                    b.HasKey("NumeroNota");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdDetallePedido");

                    b.ToTable("Nota_ventas");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.Productos", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<int>("Existencia")
                        .HasColumnType("int")
                        .HasColumnName("existencia");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int")
                        .HasColumnName("id_marca");

                    b.Property<int>("IdUnidadMed")
                        .HasColumnType("int")
                        .HasColumnName("id_unidad_med");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<float>("Precio")
                        .HasColumnType("real")
                        .HasColumnName("precio");

                    b.HasKey("Codigo");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdMarca");

                    b.HasIndex("IdUnidadMed");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.UnidadMedida", b =>
                {
                    b.Property<int>("IdUnidadMed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_unidad_med");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUnidadMed"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("IdUnidadMed");

                    b.ToTable("Unidad_medida");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.DetallePedido", b =>
                {
                    b.HasOne("proyectoUsabilidad.Models.EstadoPedidos", "Estado")
                        .WithMany("DetallePedido")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.DetalleVenta", b =>
                {
                    b.HasOne("proyectoUsabilidad.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("Codigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proyectoUsabilidad.Models.NotaVentas", null)
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdDetalleVenta");

                    b.HasOne("proyectoUsabilidad.Models.NotaVentas", "NotaVenta")
                        .WithMany()
                        .HasForeignKey("NumeroNota")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaVenta");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.NotaVentas", b =>
                {
                    b.HasOne("proyectoUsabilidad.Models.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proyectoUsabilidad.Models.DetallePedido", "DetallePedido")
                        .WithMany()
                        .HasForeignKey("IdDetallePedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("DetallePedido");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.Productos", b =>
                {
                    b.HasOne("proyectoUsabilidad.Models.Categorias", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proyectoUsabilidad.Models.Marcas", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proyectoUsabilidad.Models.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("IdUnidadMed")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.EstadoPedidos", b =>
                {
                    b.Navigation("DetallePedido");
                });

            modelBuilder.Entity("proyectoUsabilidad.Models.NotaVentas", b =>
                {
                    b.Navigation("DetalleVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
