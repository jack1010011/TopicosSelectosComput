using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.Convertidor
{
    public interface InterfaceMoneda
    {
        public void DeMonedaXAMonedaY(double monedaX);

        public void DeMonedaYAMonedaX(double monedaY);

    }
}
