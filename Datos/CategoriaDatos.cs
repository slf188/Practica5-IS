using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using AccesoDatos;

namespace Datos
{
    public class CategoriaDatos : IDatos<Categoria>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        servicioEntities contexto;

        public CategoriaDatos()
        {
            contexto = new servicioEntities();
        }

        public List<Categoria> Listar()
        {
            return contexto.Categoria.ToList();
        }

        public bool Nuevo(Categoria categoria)
        {
            contexto.Categoria.Add(categoria);
            return contexto.SaveChanges() > 0;
        }

        public Categoria BuscarID(int id)
        {
            return contexto.Categoria.Where(f => f.id == id).FirstOrDefault();
        }

        // actualizar
        public bool Actualizar(Categoria categoria)
        {
            if (categoria != null)
            {
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Categoria categoria)
        {
            if (categoria != null)
            {
                contexto.Categoria.Remove(categoria);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        
    }
}
