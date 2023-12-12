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
        public F_menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f_login = new Form1();
            f_login.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            F_todosUsuarios f_CadastrarUsuario = new F_todosUsuarios();
            f_CadastrarUsuario.ShowDialog();

        }

        private void F_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
