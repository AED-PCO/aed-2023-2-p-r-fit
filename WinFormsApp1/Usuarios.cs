using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    internal class Usuarios
    {
        public string Nome { get; set; }
        public string cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public string Edereco { get; set; }
        public string Nascimento { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Idade { get; set; }
        public string Unidade { get; set; }
        public string Cadastro { get; set; }
        public string Sexo { get; set; }

        public bool JsonSerializar(Usuarios usuario, string path)
        {
            var srtJson = JsonConvert.SerializeObject(usuario);
            return SaveFileUsuario(srtJson, path);
        }
        public bool JsonSerializarLista(List<Usuarios> lista, string path)
        {
            var srtJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
            return SaveFileUsuario(srtJson, path);
        }
        public static Usuarios JsonDesserializar(string path)
        {
            var srtJson = OpenFileUsuario(path);
            if (srtJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Usuarios>(srtJson);
            }
            else
            {
                var usuario = new Usuarios();
                usuario.Nome = srtJson;
                return usuario;
            }

        }

        public static List<Usuarios> JsonDesserializarLista(string path)
        {
            var srtJson = OpenFileUsuario(path);
            if (srtJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Usuarios>>(srtJson);
            }
            else
            {
                var listaUsuarios = new List<Usuarios>();
                var usuario = new Usuarios();
                usuario.Nome = srtJson;
                listaUsuarios.Add(usuario);
                usuario.Nome = srtJson;
                return listaUsuarios;
            }
        }

        private bool SaveFileUsuario(string srtJson, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(srtJson);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
                return false;
            }
        }

        private static string OpenFileUsuario(string path)
        {
            try
            {
                var srtJson = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    srtJson = sr.ReadToEnd();
                }
                return srtJson;
            }
            catch (Exception ex)
            {
                return "Falha: " + ex.Message;
            }
        }
    }
}
