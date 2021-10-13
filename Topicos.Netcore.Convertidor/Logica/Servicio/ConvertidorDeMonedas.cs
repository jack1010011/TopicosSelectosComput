using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.NetCore.Convertidor;

namespace Topicos.NetCore.ConsoleApp
{
    class ConvertidorDeMonedas : Topicos.NetCore.Convertidor.InterfaceMoneda
    {
        private string NombreMonedaX;
        private string NombreMonedaY;
        private double FactorConversion;

        public ConvertidorDeMonedas(string nombreMonedaX, string nombreMonedaY, double factorConversion)
        {
            NombreMonedaX = nombreMonedaX;
            NombreMonedaY = nombreMonedaY;
            FactorConversion = factorConversion; 
        }

        public void DeMonedaXAMonedaY(double monedaX)
        {
            double valorMonedaY = monedaX * FactorConversion; 
            System.Console.WriteLine($"{monedaX} {NombreMonedaX} equivalen a {valorMonedaY} {NombreMonedaY}.");
        }

        public void DeMonedaYAMonedaX(double monedaY)
        {
            double valorMonedaX = monedaY / FactorConversion;
            System.Console.WriteLine($"{monedaY} {NombreMonedaY} equivalen a {valorMonedaX} {NombreMonedaX}.");
        }
    }
}
