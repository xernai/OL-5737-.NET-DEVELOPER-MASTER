using Gigante.Ventas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigante.Ventas.Domain
{
    public class PagosManejo : IPaypal
    {
        public int ID { get; set; }
        public int ClienteId { get; set; }

        public string ObtenerFolioPaypal(decimal clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
