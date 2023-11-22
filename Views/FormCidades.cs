using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _221048.Models;

namespace _221048.Views
{
    public partial class FormCidades : Form
    {
        Cidade c;
        public FormCidades()
        {
            InitializeComponent();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Cidade(){nome = pesquisa};
            dataGridViewCidades.DataSource = c.Consultar();
        }

        void limparControles()
        {
            textBoxID.Clear();
            textBoxCidade.Clear();
            textBoxUF.Clear();
            textBoxPesquisa.Clear();
        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            if (textBoxCidade.Text == String.Empty) return;

            c = new Cidade() { 
                nome = textBoxCidade.Text,
                uf = textBoxUF.Text
            };

            c.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dataGridViewCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewCidades.RowCount > 0)
            {
                textBoxID.Text = dataGridViewCidades.CurrentRow.Cells["id"].Value.ToString();
                textBoxCidade.Text = dataGridViewCidades.CurrentRow.Cells["nome"].Value.ToString();
                textBoxUF.Text = dataGridViewCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == String.Empty) { return; }

            c = new Cidade()
            {
                id = int.Parse(textBoxID.Text),
                nome = textBoxCidade.Text,
                uf = textBoxUF.Text
            };

            c.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == String.Empty) { return; }

            if(MessageBox.Show("Deseja excluir a cidade?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxVenda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCidades_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
