using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class F_todosUsuarios : Form
    {

        List<Usuarios> listaUsuarios = new List<Usuarios>();
        public F_todosUsuarios()
        {
            InitializeComponent();
            listaUsuarios = Usuarios.JsonDesserializarLista(@"C:\Users\faelr\OneDrive\Documentos\AED\WinFormsApp1\arquivo.json");
            dataGridView1.DataSource = listaUsuarios;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            usuario.Nome = txt_nome.Text;
            usuario.cpf = txt_cpf.Text;
            usuario.Email = txt_email.Text;
            usuario.Telefone = txt_telefone.Text;
            usuario.Edereco = txt_endereco.Text;
            usuario.Nascimento = txt_dataNascimento.Text;
            usuario.Peso = txt_peso.Text;
            usuario.Altura = txt_altura.Text;
            usuario.Idade = txt_idade.Text;
            usuario.Unidade = cb_unidade.Text;
            usuario.Cadastro = txt_dataCadastro.Text;
            usuario.Sexo = cb_sexo.Text;

            listaUsuarios.Add(usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios;

            MessageBox.Show("Usuário inserido");
            txt_nome.Focus();
            txt_nome.Text = "";
            txt_cpf.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "";
            txt_endereco.Text = "";
            txt_dataNascimento.Text = "";
            txt_peso.Text = "";
            txt_altura.Text = "";
            txt_idade.Text = "";
            cb_unidade.Text = "";
            txt_dataCadastro.Text = "";
            cb_sexo.Text = "";

        }

        private void btn_serealizarLista_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            if (usuario.JsonSerializarLista(listaUsuarios, @"C:\Users\faelr\OneDrive\Documentos\AED\WinFormsApp1\arquivo.json"))
            {
                MessageBox.Show("Salvo");
            }
                
            F_menu f_menu = new F_menu();
            f_menu.ShowDialog();
        }
    }
}
