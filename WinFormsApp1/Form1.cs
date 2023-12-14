using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private const string jsonFilePath = "colaboradores.json";
        private List<Colaborador> listaColaborador;
        public Form1()
        {
            InitializeComponent();
            CarregarColaboradores();
        }


        private void CarregarColaboradores()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    listaColaborador = JsonConvert.DeserializeObject<List<Colaborador>>(json);
                }
                else
                {
                    listaColaborador= new List<Colaborador>();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao salvar dados de colaborador");
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {

            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            var colaborador = listaColaborador.FirstOrDefault(c => c.Cpf == usuario && c.Senha == senha);

            if (colaborador != null)
            {
                this.Hide();
                MessageBox.Show("Login efetuado");
                F_menu f_menu = new F_menu(colaborador.Nome);
                f_menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
