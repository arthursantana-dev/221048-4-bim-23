using _221048.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221048.Views
{
    public partial class FormCategoria : Form
    {

        Categoria c;
        public FormCategoria()
        {
            InitializeComponent();
        }


        void carregarGrid(string pesquisa)
        {
            c = new Categoria() { categoria = pesquisa };
            dataGridViewCidades.DataSource = c.Consultar();
        }

        void limparControles()
        {
            textBoxID.Clear();
            textBoxCategoria.Clear();
            textBoxPesquisa.Clear();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            if (textBoxCategoria.Text == String.Empty) return;

            c = new Categoria()
            {
                categoria = textBoxCategoria.Text
            };

            c.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dataGridViewCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCidades.RowCount > 0)
            {
                textBoxID.Text = dataGridViewCidades.CurrentRow.Cells["id"].Value.ToString();
                textBoxCategoria.Text = dataGridViewCidades.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == String.Empty) { return; }

            c = new Categoria()
            {
                id = int.Parse(textBoxID.Text),
                categoria = textBoxCategoria.Text
            };

            c.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == String.Empty) { return; }

            if (MessageBox.Show("Deseja excluir a categoria?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Categoria()
                {
                    id = int.Parse(textBoxID.Text)
                };

                c.Excluir();

                limparControles();
                carregarGrid("");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(textBoxPesquisa.Text);
        }
    }
}
