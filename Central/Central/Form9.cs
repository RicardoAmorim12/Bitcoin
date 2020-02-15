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
    public partial class exCliente : Form
    {
        public exCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.btcCentralDataSet);

        }

        private void exCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'btcCentralDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.btcCentralDataSet.Cliente);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.RemoveCurrent();
            this.clienteBindingSource.EndEdit();
            this.clienteTableAdapter.Update(btcCentralDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.MoveNext();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
           
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
