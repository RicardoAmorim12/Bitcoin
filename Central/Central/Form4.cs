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
    public partial class cadInfo : Form
    {
        public cadInfo()
        {
            InitializeComponent();
        }

        private void informacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void cadInfo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Informacao'. Você pode movê-la ou removê-la conforme necessário.
            this.informacaoTableAdapter.Fill(this.btcCentralDataSet.Informacao);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            nomeTextBox.Enabled = true;
            maquinaTextBox.Enabled = true;
            quantidadeTextBox.Enabled = true;
            wattsTextBox.Enabled = true;
            moedaTextBox.Enabled = true;
            instalacaoDateTimePicker.Enabled = true;
            this.informacaoBindingSource.AddNew();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);
            nomeTextBox.Enabled = false;
            maquinaTextBox.Enabled = false;
            quantidadeTextBox.Enabled = false;
            wattsTextBox.Enabled = false;
            moedaTextBox.Enabled = false;
            instalacaoDateTimePicker.Enabled = false;
            MessageBox.Show("Cadastro realizado com sucesso");
            nomeTextBox.Text = "";
            maquinaTextBox.Text = "";
            quantidadeTextBox.Text = "";
            wattsTextBox.Text = "";
            moedaTextBox.Text = "";
            instalacaoDateTimePicker.Text = "";
            button2.Enabled = false;
        }
    }
}
