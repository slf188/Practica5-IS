using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class ClienteNegocio
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5

        ClienteDatos clientes;
        public ClienteNegocio()
        {
            clientes = new ClienteDatos();
        }

        public List<Cliente> All()
        {
            return clientes.Listar();
        }

        public Cliente ById(int id)
        {
            return clientes.Listar().Where(p => p.id == id).SingleOrDefault();
        }

        public bool insertarCliente(Cliente clienteNuevo)
        {
            return clientes.Nuevo(clienteNuevo);
        }


    }
}
