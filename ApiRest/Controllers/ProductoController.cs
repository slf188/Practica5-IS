using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiREST.Controllers
{
    public class ProductoController : ApiController
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        ProductoNegocio productoNegocio = new ProductoNegocio();

        // get
        public IHttpActionResult Get()
        {
            var respuesta = productoNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Productos producto = productoNegocio.ById(id);
            if (producto != null) {
                return Ok(producto);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Productos producto)
        {
            productoNegocio.insertarProductos(producto);
            return Ok(producto);
        }

        // put -- actualizar un producto
        public IHttpActionResult Put(Productos producto)
        {
            productoNegocio.actualizarProductos(producto);
            return Ok(producto);
        }


        // delete -- eliminar un producto
        public IHttpActionResult Delete(int id)
        {
            productoNegocio.eliminarProductos(id);
            return Ok();
        }
    }
}