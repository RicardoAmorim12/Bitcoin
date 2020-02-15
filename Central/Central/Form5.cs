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
    public partial class cadBanco : Form
    {
        public cadBanco()
        {
            InitializeComponent();
        }

        private void bancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void cadBanco_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Banco'. Você pode movê-la ou removê-la conforme necessário.
            this.bancoTableAdapter.Fill(this.btcCentralDataSet.Banco);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            nomeTextBox.Enabled = true;
            moedaTextBox.Enabled = true;
            carteiraTextBox.Enabled = true;
            this.bancoBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);
            nomeTextBox.Enabled = false;
            moedaTextBox.Enabled = false;
            carteiraTextBox.Enabled = false;
            MessageBox.Show("Cadastro realizado com sucesso");
            nomeTextBox.Text = "";
            moedaTextBox.Text = "";
            carteiraTextBox.Text = "";
            button2.Enabled = false;
        }
    }
}
