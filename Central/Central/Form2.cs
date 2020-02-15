using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadCliente cadastro_cliente = new cadCliente();
            cadastro_cliente.Show();

        }

        private void informaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadInfo cadastro_info = new cadInfo();
            cadastro_info.Show();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadBanco cadastro_banco = new  cadBanco();
            cadastro_banco.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCompra cadastro_compra = new cadCompra();
            cadastro_compra.Show();

        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadRecibo cadastro_recibo = new cadRecibo();
            cadastro_recibo.Show();
        }

        private void gastosMensaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadGasto cadastro_gasto = new cadGasto();
            cadastro_gasto.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exCliente exibir_cliente = new exCliente();
            exibir_cliente.Show();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exInfo exibir_info = new exInfo();
            exibir_info.Show();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exBanco exibir_banco = new exBanco();
            exibir_banco.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exCompras exibir_compra = new exCompras();
            exibir_compra.Show();
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exRecibo exibir_recibo = new exRecibo();
            exibir_recibo.Show();
        }

        private void gastosMensaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exGasto exibir_gasto = new exGasto();
            exibir_gasto.Show();
        }
    }
}
