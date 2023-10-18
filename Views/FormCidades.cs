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
    }
}
