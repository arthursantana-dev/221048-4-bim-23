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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _221048.Views
{
    public partial class FormMarca : Form
    {
        Marca m;
        public FormMarca()
        {
            InitializeComponent();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca() { marca = pesquisa };
            dataGridViewCidades.DataSource = m.Consultar();
        }


        void limparControles()
        {
            textBoxID.Clear();
            textBoxMarca.Clear();
            textBoxPesquisa.Clear();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            if (textBoxMarca.Text == String.Empty) return;

             m = new Marca()
            {
                marca = textBoxMarca.Text
            };

            m.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dataGridViewCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCidades.RowCount > 0)
            {
                textBoxID.Text = dataGridViewCidades.CurrentRow.Cells["id"].Value.ToString();
                textBoxMarca.Text = dataGridViewCidades.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == String.Empty) { return; }

            m = new Marca()
            {
                id = int.Parse(textBoxID.Text),
                marca = textBoxMarca.Text
            };

            m.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == String.Empty) { return; }

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    id = int.Parse(textBoxID.Text)
                };

                m.Excluir();

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
