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
    public partial class exBanco : Form
    {
        public exBanco()
        {
            InitializeComponent();
        }

        private void bancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void exBanco_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Banco'. Você pode movê-la ou removê-la conforme necessário.
            this.bancoTableAdapter.Fill(this.btcCentralDataSet.Banco);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bancoBindingSource.RemoveCurrent();
            this.bancoBindingSource.EndEdit();
            this.bancoTableAdapter.Update(btcCentralDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bancoBindingSource.MovePrevious();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bancoBindingSource.MoveNext();
        }
    }
}
