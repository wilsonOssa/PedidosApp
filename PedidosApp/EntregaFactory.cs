using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    public static class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "accesorio" && !urgente && peso < 2)
                return new EntregaBicicleta();
            else if (tipoProducto == "tecnologia" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio")
                return new EntregaMoto();
            else if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else
                return new EntregaMoto(); // Valor por defecto
        }
    }
}
