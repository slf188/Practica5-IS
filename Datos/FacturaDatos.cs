using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using AccesoDatos;

namespace Datos
{
    public class FacturaDatos : IDatos<Factura>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        servicioEntities contexto;

        public FacturaDatos()
        {
            contexto = new servicioEntities();
        }


        public List<Factura> Listar()
        {
            return contexto.Factura.ToList();
        }

        public bool Nuevo(Factura factura)
        {
            contexto.Factura.Add(factura);
            return contexto.SaveChanges() > 0;
        }

        public Factura BuscarID(int id)
        {
            return contexto.Factura.Where(f => f.numero_factura == id).FirstOrDefault();
        }

        // actualizar
        public bool Actualizar(Factura factura)
        {
            if (factura != null)
            {
                contexto.Entry(factura).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Factura factura)
        {
            if (factura != null)
            {
                contexto.Factura.Remove(factura);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        
    }
}
