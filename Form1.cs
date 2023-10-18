using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Die_Hello
{
    public partial class Login : Form
    {
        int contador = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Algum campo nao foi preenchido");
            }
            else {

                if (txtUsuario.Text == "etec" && txtSenha.Text == "123")
                {
                    MessageBox.Show("Bem vindo usuario");
                    telafornecedor telafornecedor = new telafornecedor();
                    telafornecedor.Show();
                    this.Close();
                }
                else
                {
                    contador -= 1;
                    MessageBox.Show("Usuario ou senha invalidos, voce tem mais "+ contador+" de chances para efetuar o login");
                    if(contador==0)
                    {
                        MessageBox.Show("Número de tentativas excedido, tente novamente mais tarde");
                        this.Close(); }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cad cad = new cad();
            cad.Show();
        }
    }
}
