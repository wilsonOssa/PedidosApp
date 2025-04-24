using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    public sealed class RegistroPedidos
    {
        private static RegistroPedidos _instancia;
        private static readonly object _lock = new object();
        public List<Pedido> Pedidos { get; private set; }

        private RegistroPedidos() => Pedidos = new List<Pedido>();

        public static RegistroPedidos Instancia
        {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null) // Verificación explícita para C# 7.3
                    {
                        _instancia = new RegistroPedidos();
                    }
                    return _instancia;
                }
            }
        }

        public void AgregarPedido(Pedido pedido) => Pedidos.Add(pedido);
    }
}
