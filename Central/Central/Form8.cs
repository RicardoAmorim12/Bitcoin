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
    public partial class cadGasto : Form
    {
        public cadGasto()
        {
            InitializeComponent();
        }

        private void gastoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gastoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void cadGasto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Gasto'. Você pode movê-la ou removê-la conforme necessário.
            this.gastoTableAdapter.Fill(this.btcCentralDataSet.Gasto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            descricaoTextBox.Enabled = true;
            valorTextBox.Enabled = true;
            vencimentoDateTimePicker.Enabled = true;
            mensalCheckBox.Enabled = true;
            this.gastoBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gastoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

            descricaoTextBox.Enabled = false;
            valorTextBox.Enabled = false;
            vencimentoDateTimePicker.Enabled = false;
            mensalCheckBox.Enabled = false;
            MessageBox.Show("Cadastro realizado com sucesso");
            descricaoTextBox.Enabled = false;
            valorTextBox.Text = "";
            vencimentoDateTimePicker.Text = "";
            mensalCheckBox.Text = "";
            button2.Enabled = false;
        }
    }
}
