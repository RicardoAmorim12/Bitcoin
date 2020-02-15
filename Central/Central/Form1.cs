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
    public partial class Verificacao : Form
    {
        public Verificacao()
        {
            InitializeComponent();
        }

        private void Verificacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Jozao90" && textBox2.Text == "ph279976@") {
                telaPrincipal tela_principal = new telaPrincipal();
                tela_principal.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
                textBox2.Text = "";
            }

           
        }
    }
}
