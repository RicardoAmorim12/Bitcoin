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
    public partial class cadCliente : Form
    {
        public cadCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void cadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.btcCentralDataSet.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            nomeTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            senhaTextBox.Enabled = true;
            this.clienteBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            senhaTextBox.Enabled = false;
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);
            MessageBox.Show("Cadastro realizado com sucesso");
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            senhaTextBox.Text = "";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.RemoveCurrent();
        }
    }
}
