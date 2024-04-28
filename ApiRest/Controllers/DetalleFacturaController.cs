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
    public class DetalleFacturaController : ApiController
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        DetalleFacturaNegocio detalleFacturaNegocio = new DetalleFacturaNegocio();

        public IHttpActionResult Get()
        {
            DetalleFacturaNegocio detalleFacturaNegocio = new DetalleFacturaNegocio();
            var respuesta = detalleFacturaNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            DetalleFactura detalleFactura = detalleFacturaNegocio.ById(id);
            if (detalleFactura != null)
            {
                return Ok(detalleFactura);
            }
            return NotFound();
        }

        public IHttpActionResult Post(DetalleFactura detalleFactura)
        {
            detalleFacturaNegocio.insertarDetalleFactura(detalleFactura);
            return Ok(detalleFactura);
        }
    }
}