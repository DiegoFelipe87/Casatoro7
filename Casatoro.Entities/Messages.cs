using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casatoro.Entities
{
    public static class Messages
    {
        public const string ResponseOk = "Transacción exitosa";
        public const string ResponseException = "Se ha encontrado un error en la ejecución.";
        public const string NotFound = "No hay informacion.";
        public const string ObservationFieldDuplicated = "Ya existe un vendedor con ese número de cédula";
    }

}
