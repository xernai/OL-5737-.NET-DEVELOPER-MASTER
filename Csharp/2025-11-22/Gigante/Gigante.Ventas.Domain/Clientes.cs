using Gigante.Ventas.Domain.Interfaces;
using System;

namespace Gigante.Ventas.Domain
{
    public class Clientes: IPaypal
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }

        public string ObtenerFolioPaypal(decimal clienteId)
        {
            throw new NotImplementedException();
        }

        public string ObtenerFolioPaypalVIP(decimal clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
