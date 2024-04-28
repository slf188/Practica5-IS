using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using AccesoDatos;

namespace Datos
{
    public class ProductoDatos : IDatos<Productos>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        servicioEntities contexto; // Debería ser inicializado, posiblemente a través de un constructor.

        // Constructor para inicializar el contexto
        public ProductoDatos()
        {
            contexto = new servicioEntities();
        }

        public List<Productos> Listar()
        {
            // Se asume que "Productos" es una DbSet dentro del contexto.
            return contexto.Productos.ToList();
        }

        public bool Nuevo(Productos producto)
        {
            // Asegúrate de que "Productos" es el nombre correcto de la DbSet.
            contexto.Productos.Add(producto); // Se añade el producto al contexto.

            // Guardar los cambios en la base de datos.
            return contexto.SaveChanges() > 0; // Si SaveChanges devuelve un número mayor a 0, significa que se han guardado registros y retorna true.
        }

        public Productos BuscarID(int id)
        {
            return contexto.Productos.Where(p => p.idProducto == id).FirstOrDefault();
        }

        // actualizar
        public bool Actualizar(Productos producto)
        {
            if (producto != null)
            {
                contexto.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Productos producto)
        {
            if (producto != null)
            {
                contexto.Productos.Remove(producto);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
