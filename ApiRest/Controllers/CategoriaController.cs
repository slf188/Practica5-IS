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
    public class CategoriaController : ApiController
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public IHttpActionResult Get()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            var respuesta = categoriaNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Categoria categoria = categoriaNegocio.ById(id);
            if (categoria != null)
            {
                return Ok(categoria);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Categoria categoria)
        {
            categoriaNegocio.insertarCategoria(categoria);
            return Ok(categoria);
        }
    }
}