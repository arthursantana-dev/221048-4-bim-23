using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221048
{
    public class Banco
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable dataTabela;

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao() {
            try
            {
                Conexao.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades" +
                    "(id int primary key auto_increment," +
                    "nome char(40)," +
                    "uf char(2));", Conexao);
                Comando.ExecuteNonQuery();

                FecharConexao();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
