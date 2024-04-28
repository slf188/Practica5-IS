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
    public class FacturaNegocio
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        FacturaDatos factura;
        public FacturaNegocio()
        {
            factura = new FacturaDatos();
        }
        public List<Factura> All()
        {
            return factura.Listar();
        }

        public Factura ById(int id)
        {
            return factura.Listar().Where(p => p.numero_factura == id).SingleOrDefault();
        }

        public bool insertarFactura(Factura facturasNuevo)
        {
            return factura.Nuevo(facturasNuevo);
        }

        // eliminar factura
        public bool eliminarFactura(int id)
        {
            Factura facturas = factura.BuscarID(id);
            return factura.Eliminar(facturas);
        }

        // actualizar
        public bool actualizarFactura(Factura facturas)
        {
            return factura.Actualizar(facturas);
        }

    }
}
