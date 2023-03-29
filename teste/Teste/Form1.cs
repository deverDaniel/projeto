using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MODEL;
using CONTROL;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            //chama o objeto modelo usuario
            Usuario us = new Usuario();
            //atribuo os valores no objeto estanciado
            us.setnome(TXTnome.Text);
            us.setemail(TXTemail.Text);
            us.setfone(TXTfone.Text);
            //crio um objeto controlle usuario
            Usuariocontroller usu = new Usuariocontroller();
            //se usuario foi cadastrado então...
            if (usu.cadastraUsuario(us) == true)
            {
                MessageBox.Show("cadastro feito com sucesso");
            }
            else
            {
                MessageBox.Show("falha ao realizar o cadastro");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            //atribuo os valores no objeto estanciado
            us.setcod(TXTcod.Text);
            //crio um objeto controlle usuario
            Usuariocontroller usu = new Usuariocontroller();
            //se usuario foi cadastrado então...
            if (usu.deletar_usuario(us) == true)
            {
                MessageBox.Show("cadastro excluido com sucesso");
            }
            else
            {
                MessageBox.Show("falha ao excluir cadastro");
            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            //atribuo os valores no objeto estanciado
            us.setnome(TXTnome.Text);
            us.setemail(TXTemail.Text);
            us.setfone(TXTfone.Text);
            us.setcod(TXTcod.Text);
            //crio um objeto controlle usuario
            Usuariocontroller usu = new Usuariocontroller();
            //se usuario foi cadastrado então...
            if (usu.alterar_usuario(us) == true)
            {
                MessageBox.Show("alteração feita com sucesso");
            }
            else
            {
                MessageBox.Show("alteração feita com sucesso");
            }

        }
    }
}
