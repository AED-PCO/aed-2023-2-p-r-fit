using Newtonsoft.Json;
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
    public partial class F_colaborador : Form
    {
        private string nomeColaborador;
        List<Colaborador> listaColaborador = new List<Colaborador>();
        private const string jsonFilePath = "colaboradores.json";
        public F_colaborador(string nomeColaborador)
        {
            InitializeComponent();
            this.nomeColaborador = nomeColaborador;
            CarregarColaboradores();
            AtualizarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var colaborador = new Colaborador();
            colaborador.Nome = txt_nomeColaborador.Text;
            colaborador.Cpf = txt_cpfColaborador.Text;
            colaborador.Unidade = cb_unidadeColaborador.Text;
            colaborador.Senha = txt_senhaColaborador.Text;

            listaColaborador.Add(colaborador);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaColaborador;
            MessageBox.Show("Colaborador inserido!");

            SalvarColaboradores();
        }

        private void EfetuarLogin(string cpf, string senha)
        {
            var colaborador = listaColaborador.FirstOrDefault(c => c.Cpf == cpf && c.Senha == senha);

            if (colaborador != null)
            {
                MessageBox.Show("Login efetuado");
                F_menu f_menu = new F_menu(nomeColaborador);
                f_menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto");
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalvarColaboradores()
        {
            try
            {
                string json = JsonConvert.SerializeObject(listaColaborador, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados de colaborador");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_menu f_menu = new F_menu(nomeColaborador);
            f_menu.ShowDialog();
            this.Close();
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaColaborador;
        }

        private void btn_excluirColaborador_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                listaColaborador.RemoveAt(selectedIndex);

                AtualizarDataGridView();

                MessageBox.Show("Usuário excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGridView();
        }

        private void btn_salvarColaborador_Click(object sender, EventArgs e)
        {
            SalvarColaboradores();
            MessageBox.Show("Colaboradores salvos!");
        }
    }
}
