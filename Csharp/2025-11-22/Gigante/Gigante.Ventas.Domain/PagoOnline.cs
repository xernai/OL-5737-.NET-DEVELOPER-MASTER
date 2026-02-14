using Gigante.Ventas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigante.Ventas.Domain
{
    public class PagoOnline : Pagos, IPaypal, IClientesVIP
    {
        public string Folio { get; set; }

        public string ObtenerFolioPaypal(decimal clienteId)
        {
            return "LLamar al Paypal para que nos den el folio";
        }

        public string ObtenerFolioPaypalVIP(decimal clienteId)
        {
            throw new NotImplementedException();
        }

        private IPagos _pagos;

        public PagoOnline(IPagos pagos)
        {
            _pagos = pagos;
        }

        //public string ObtenerPago()
        //{
        //    _pagos.
        //}
    }
}
