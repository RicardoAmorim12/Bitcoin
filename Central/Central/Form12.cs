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
    public partial class exCompras : Form
    {
        public exCompras()
        {
            InitializeComponent();
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void exCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Compra'. Você pode movê-la ou removê-la conforme necessário.
            this.compraTableAdapter.Fill(this.btcCentralDataSet.Compra);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.compraBindingSource.RemoveCurrent();
            this.compraBindingSource.EndEdit();
            this.compraTableAdapter.Update(btcCentralDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.compraBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.compraBindingSource.MoveNext();
        }
    }
}
