using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using AccesoDatos;

namespace Datos
{
    public class DetalleFacturaDatos : IDatos<DetalleFactura>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        servicioEntities contexto;

        public DetalleFacturaDatos()
        {
            contexto = new servicioEntities();
        }

        public List<DetalleFactura> Listar()
        {
            return contexto.DetalleFactura.ToList();
        }

        public bool Nuevo(DetalleFactura detalleFactura)
        {
            contexto.DetalleFactura.Add(detalleFactura);
            return contexto.SaveChanges() > 0;
        }

        public DetalleFactura BuscarID(int id)
        {
            return contexto.DetalleFactura.Where(f => f.id == id).FirstOrDefault();
        }

        // actualizar
        public bool Actualizar(DetalleFactura detalleFactura)
        {
            if (detalleFactura != null)
            {
                contexto.Entry(detalleFactura).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(DetalleFactura detalleFactura)
        {
            if (detalleFactura != null)
            {
                contexto.DetalleFactura.Remove(detalleFactura);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
