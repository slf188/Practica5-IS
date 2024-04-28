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
    public class CategoriaNegocio
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        CategoriaDatos categoria;
        public CategoriaNegocio()
        {
            categoria = new CategoriaDatos();
        }
        public List<Categoria> All()
        {
            return categoria.Listar();
        }

        public Categoria ById(int id)
        {
            return categoria.Listar().Where(p => p.id == id).SingleOrDefault();
        }

        public bool insertarCategoria(Categoria categoriaNuevo)
        {
            return categoria.Nuevo(categoriaNuevo);
        }
    }
}
