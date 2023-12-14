using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class F_menu : Form
    {
        private string nomeColaborador;
        public F_menu(string nomeColaborador)
        {
            InitializeComponent();
            this.nomeColaborador = nomeColaborador;
            lb_usuarioLogado.Text = nomeColaborador;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_todosUsuarios f_TodosUsuarios = new F_todosUsuarios(nomeColaborador);
            f_TodosUsuarios.Close();
            Form1 f_login = new Form1();
            f_login.ShowDialog();
            this.Close();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_todosUsuarios f_CadastrarUsuario = new F_todosUsuarios(nomeColaborador);
            f_CadastrarUsuario.ShowDialog();
            this.Close();

        }

        private void F_menu_Load(object sender, EventArgs e)
        {

        }

        private void inserirColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_colaborador f_Colaborador = new F_colaborador(nomeColaborador);
            f_Colaborador.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
