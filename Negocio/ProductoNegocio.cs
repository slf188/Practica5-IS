using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class ProductoNegocio
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        ProductoDatos productos;
        public ProductoNegocio()
        {
            productos = new ProductoDatos();
        }
        public List<Productos> All()
        {
            return productos.Listar();
        }

        public Productos ById(int id)
        {
            return productos.Listar().Where(p => p.idProducto == id).SingleOrDefault();
        }

        public bool insertarProductos(Productos productosNuevo)
        {
            return productos.Nuevo(productosNuevo);
        }

        // eliminar producto
        public bool eliminarProductos(int id)
        {
            Productos producto = productos.BuscarID(id);
            return productos.Eliminar(producto);
        }

        // actualizar productos de un producto
        public bool actualizarProductos(Productos producto)
        {
            return productos.Actualizar(producto);
        }
    }
}
