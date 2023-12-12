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
            listaUsuarios = Usuarios.JsonDesserializarLista(@"C:\Users\faelr\OneDrive\Documentos\AED\aed-2023-2-p-r-fit\arquivo.json");
            dataGridView1.DataSource = listaUsuarios;
        }


        private void btn_inserir_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            usuario.Nome = txt_nome.Text;
            usuario.cpf = mtb_cpf.Text;
            usuario.Email = txt_email.Text;
            usuario.Telefone = mtb_telefone.Text;
            usuario.Edereco = txt_endereco.Text;
            usuario.Nascimento = mtb_dataNascimento.Text;
            usuario.Peso = mtb_peso.Text;
            usuario.Altura = mtb_altura.Text;
            usuario.Idade = txt_idade.Text;
            usuario.Unidade = cb_unidade.Text;
            usuario.Cadastro = mtb_dataCadastro.Text;
            usuario.Sexo = cb_sexo.Text;

            listaUsuarios.Add(usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios;

            MessageBox.Show("Usuário inserido");
            txt_nome.Focus();
            txt_nome.Text = "";
            mtb_cpf.Text = "";
            txt_email.Text = "";
            mtb_telefone.Text = "";
            txt_endereco.Text = "";
            mtb_dataNascimento.Text = "";
            mtb_peso.Text = "";
            mtb_altura.Text = "";
            txt_idade.Text = "";
            cb_unidade.Text = "";
            mtb_dataCadastro.Text = "";
            cb_sexo.Text = "";
        }

        private void btn_serealizarLista_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            if (usuario.JsonSerializarLista(listaUsuarios, @"C:\Users\faelr\OneDrive\Documentos\AED\aed-2023-2-p-r-fit\arquivo.json"))
            {
                MessageBox.Show("Salvo");
            }

            F_menu f_menu = new F_menu();
            f_menu.ShowDialog();

            OrdenarUsuariosPorNome();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_todosUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            OrdenarUsuariosPorNome();
        }

        private void OrdenarUsuariosPorNome()
        {
            listaUsuarios.Sort((u1, u2) => string.Compare(u1.Nome, u2.Nome, StringComparison.Ordinal));

            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios;
        }
    }
}
