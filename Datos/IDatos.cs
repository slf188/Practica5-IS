using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    internal interface IDatos<T>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-28
        // PRÁCTICA No. #5
        List<T> Listar();
        bool Nuevo(T item);
        bool Actualizar(T item);

        bool Eliminar(T item);

    }
}
