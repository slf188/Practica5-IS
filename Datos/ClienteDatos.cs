using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using AccesoDatos;

namespace Datos
{
    public class ClienteDatos : IDatos<Cliente>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        servicioEntities contexto;

        public ClienteDatos()
        {
            contexto = new servicioEntities();
        }

        public List<Cliente> Listar()
        {
            return contexto.Cliente.ToList();
        }

        public bool Nuevo(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            return contexto.SaveChanges() > 0;
        }

        public Cliente BuscarID(int id)
        {
            return contexto.Cliente.Where(c => c.id == id).FirstOrDefault();
        }

        // actualizar
        public bool Actualizar(Cliente cliente)
        {
            if (cliente != null)
            {
                contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Cliente cliente)
        {
            if (cliente != null)
            {
                contexto.Cliente.Remove(cliente);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
    
}