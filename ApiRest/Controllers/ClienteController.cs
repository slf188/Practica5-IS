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
    public class ClienteController : ApiController
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        ClienteNegocio clienteNegocio = new ClienteNegocio();

        public IHttpActionResult Get()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            var respuesta = clienteNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Cliente cliente = clienteNegocio.ById(id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Cliente cliente)
        {
            clienteNegocio.insertarCliente(cliente);
            return Ok(cliente);
        }
    }
}