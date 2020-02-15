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
    public partial class exRecibo : Form
    {
        public exRecibo()
        {
            InitializeComponent();
        }

        private void reciboBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reciboBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void exRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Recibo'. Você pode movê-la ou removê-la conforme necessário.
            this.reciboTableAdapter.Fill(this.btcCentralDataSet.Recibo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reciboBindingSource.RemoveCurrent();
            this.reciboBindingSource.EndEdit();
            this.reciboTableAdapter.Update(btcCentralDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reciboBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.reciboBindingSource.MoveNext();
        }
    }
}
