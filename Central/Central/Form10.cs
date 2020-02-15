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
    public partial class exInfo : Form
    {
        public exInfo()
        {
            InitializeComponent();
        }

        private void informacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void exInfo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Informacao'. Você pode movê-la ou removê-la conforme necessário.
            this.informacaoTableAdapter.Fill(this.btcCentralDataSet.Informacao);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.informacaoBindingSource.RemoveCurrent();
            this.informacaoBindingSource.EndEdit();
            this.informacaoTableAdapter.Update(btcCentralDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.informacaoBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.informacaoBindingSource.MoveNext();
        }
    }
}
