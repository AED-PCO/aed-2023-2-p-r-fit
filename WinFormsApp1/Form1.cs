namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text.Equals("rafael") && txt_senha.Text.Equals("123"))
                {
                    var menu = new F_menu();
                    menu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto",
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txt_usuario.Focus();
                    txt_senha.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
