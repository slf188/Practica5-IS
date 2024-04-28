using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class DetalleFacturaNegocio
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        DetalleFacturaDatos detalleFactura;
        public DetalleFacturaNegocio()
        {
            detalleFactura = new DetalleFacturaDatos();
        }
        public List<DetalleFactura> All()
        {
            return detalleFactura.Listar();
        }

        public DetalleFactura ById(int id)
        {
            return detalleFactura.Listar().Where(p => p.id == id).SingleOrDefault();
        }

        public bool insertarDetalleFactura(DetalleFactura detalleFacturaNuevo)
        {
            return detalleFactura.Nuevo(detalleFacturaNuevo);
        }
    }
}
