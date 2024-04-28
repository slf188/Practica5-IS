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
    public class FacturaController : ApiController
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        FacturaNegocio facturaNegocio = new FacturaNegocio();

        public IHttpActionResult Get()
        {
            FacturaNegocio facturaNegocio = new FacturaNegocio();
            var respuesta = facturaNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Factura factura = facturaNegocio.ById(id);
            if (factura != null)
            {
                return Ok(factura);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Factura factura)
        {
            facturaNegocio.insertarFactura(factura);
            return Ok(factura);
        }

        public IHttpActionResult Put(Factura factura)
        {
            facturaNegocio.actualizarFactura(factura);
            return Ok(factura);
        }

        public IHttpActionResult Delete(int id)
        {
            facturaNegocio.eliminarFactura(id);
            return Ok();
        }
    }
}