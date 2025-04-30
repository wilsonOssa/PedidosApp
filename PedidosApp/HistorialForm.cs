using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            dgvPedidos.DataSource = RegistroPedidos.Instancia.Pedidos.Select(p => new
            {
                p.Cliente,
                p.Producto,
                Metodo = p.MetodoEntrega.TipoEntrega(),
                Costo = p.ObtenerCosto()
            }).ToList();
        }
    }
}
