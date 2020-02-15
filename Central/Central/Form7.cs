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
    public partial class cadRecibo : Form
    {
        public cadRecibo()
        {
            InitializeComponent();
        }

        private void reciboBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reciboBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void cadRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Recibo'. Você pode movê-la ou removê-la conforme necessário.
            this.reciboTableAdapter.Fill(this.btcCentralDataSet.Recibo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            nomeTextBox.Enabled = true;
            valorTextBox.Enabled = true;
            descricaoTextBox.Enabled = true;
            this.reciboBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reciboBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);
            nomeTextBox.Enabled = false;
            valorTextBox.Enabled = false;
            descricaoTextBox.Enabled = false;
            MessageBox.Show("Cadastro realizado com sucesso");
            nomeTextBox.Text = "";
            valorTextBox.Text = "";
            descricaoTextBox.Text = "";
            button2.Enabled = false;
        }
    }
}
