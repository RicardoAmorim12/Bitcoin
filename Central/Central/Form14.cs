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
    public partial class exGasto : Form
    {
        public exGasto()
        {
            InitializeComponent();
        }

        private void gastoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gastoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void exGasto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Gasto'. Você pode movê-la ou removê-la conforme necessário.
            this.gastoTableAdapter.Fill(this.btcCentralDataSet.Gasto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gastoBindingSource.RemoveCurrent();
            this.gastoBindingSource.EndEdit();
            this.gastoTableAdapter.Update(btcCentralDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gastoBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gastoBindingSource.MoveNext();
        }
    }
}
