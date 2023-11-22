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
    public partial class FormClientes : Form
    {

        Cidade ci;
        Cliente cl;

        public FormClientes()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            textBoxId.Clear();
            textBoxNomeCliente.Clear();
            comboBoxCidades.SelectedIndex = -1;
            textBoxUF.Clear();
            maskedTextBoxCpf.Clear();
            dateTimePickerDataNascimento.Value = DateTime.Now;
            pictureBoxFoto.ImageLocation = "";
            checkBoxVenda.Checked = false;
        }


        void carregarGrid(string pesquisa)
        {
            cl = new Cliente() { nome = pesquisa };
            dataGridViewClientes.DataSource = ci.Consultar();
        }


        private void FormClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            comboBoxCidades.DataSource = ci.Consultar();
            comboBoxCidades.DisplayMember = "nome";
            comboBoxCidades.ValueMember = "id";

            limparControles();
            carregarGrid("");

            //dataGridViewClientes.Columns["idCidade"].Visible = false;
            //dataGridViewClientes.Columns["foto"].Visible = false;
        }

        private void comboBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)comboBoxCidades.SelectedItem;
                textBoxUF.Text = reg["uf"].ToString();
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/fotos/clientes/";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            pictureBoxFoto.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "") return;

            cl = new Cliente(){
                nome = textBoxNome.Text,
                idCidade = (int)comboBoxCidades.SelectedValue,
                dataNascimento = dateTimePickerDataNascimento.Value,
                renda = double.Parse(textBoxRenda.Text),
                cpf = maskedTextBoxCpf.Text,
                foto = pictureBoxFoto.ImageLocation,
                venda = checkBoxVenda.Checked

            };

            cl.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClientes.RowCount > 0)
            {
                textBoxId.Text = dataGridViewClientes.CurrentRow.Cells["id"].Value.ToString();
                textBoxNome.Text = dataGridViewClientes.CurrentRow.Cells["nome"].Value.ToString();
                comboBoxCidades.Text = dataGridViewClientes.CurrentRow.Cells["cidade"].Value.ToString();
                textBoxUF.Text = dataGridViewClientes.CurrentRow.Cells["uf"].Value.ToString();
                checkBoxVenda.Checked = (bool)dataGridViewClientes.CurrentRow.Cells["venda"].Value;
                maskedTextBoxCpf.Text = dataGridViewClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dateTimePickerDataNascimento.Text = dataGridViewClientes.CurrentRow.Cells["dataNascimento"].Value.ToString();
                textBoxRenda.Text = dataGridViewClientes.CurrentRow.Cells["renda"].Value.ToString();
                pictureBoxFoto.ImageLocation = dataGridViewClientes.CurrentRow.Cells["foto"].Value.ToString();

            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "") return;

            cl = new Cliente()
            {
                id = int.Parse(textBoxId.Text),
                nome = textBoxNome.Text,
                idCidade = (int)comboBoxCidades.SelectedValue,
                dataNascimento = dateTimePickerDataNascimento.Value,
                renda = double.Parse(textBoxRenda.Text),
                cpf = maskedTextBoxCpf.Text,
                foto = pictureBoxFoto.ImageLocation,
                venda = checkBoxVenda.Checked
            };

            cl.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "") return;

            if( MessageBox.Show("Deseja excluir o cliente?", "Excluisão", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(textBoxId.Text),
                };
                cl.Excluir();

                limparControles() ;
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
    }
}
