namespace _221048.Views
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRenda = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCidades = new System.Windows.Forms.ComboBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxVenda = new System.Windows.Forms.CheckBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(433, 26);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(139, 112);
            this.pictureBoxFoto.TabIndex = 54;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Renda:";
            // 
            // textBoxRenda
            // 
            this.textBoxRenda.Location = new System.Drawing.Point(266, 171);
            this.textBoxRenda.Name = "textBoxRenda";
            this.textBoxRenda.Size = new System.Drawing.Size(149, 20);
            this.textBoxRenda.TabIndex = 52;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(156, 171);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(104, 20);
            this.dateTimePickerDataNascimento.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(18, 171);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxCpf.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "CPF:";
            // 
            // comboBoxCidades
            // 
            this.comboBoxCidades.FormattingEnabled = true;
            this.comboBoxCidades.Location = new System.Drawing.Point(18, 118);
            this.comboBoxCidades.Name = "comboBoxCidades";
            this.comboBoxCidades.Size = new System.Drawing.Size(316, 21);
            this.comboBoxCidades.TabIndex = 47;
            this.comboBoxCidades.SelectedIndexChanged += new System.EventHandler(this.comboBoxCidades_SelectedIndexChanged);
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(18, 78);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(400, 20);
            this.textBoxNomeCliente.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Nome";
            // 
            // checkBoxVenda
            // 
            this.checkBoxVenda.AutoSize = true;
            this.checkBoxVenda.Location = new System.Drawing.Point(137, 28);
            this.checkBoxVenda.Name = "checkBoxVenda";
            this.checkBoxVenda.Size = new System.Drawing.Size(116, 17);
            this.checkBoxVenda.TabIndex = 44;
            this.checkBoxVenda.Text = "Bloquear a venda?";
            this.checkBoxVenda.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(18, 271);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(554, 150);
            this.dataGridViewClientes.TabIndex = 43;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(340, 242);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 42;
            this.buttonConsultar.Text = "Pesquisar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(18, 244);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(316, 20);
            this.textBoxPesquisa.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Digite o nome da cidade para pesquisar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "UF:";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(340, 118);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(75, 20);
            this.textBoxUF.TabIndex = 38;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(340, 197);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 37;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(259, 197);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 36;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(177, 197);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(96, 197);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 34;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(18, 197);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluir.TabIndex = 33;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.AutoSize = true;
            this.textBoxNome.Location = new System.Drawing.Point(12, 101);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(43, 13);
            this.textBoxNome.TabIndex = 32;
            this.textBoxNome.Text = "Cidade:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(15, 26);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Código:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogArquivo";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 438);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRenda);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCidades);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxVenda);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label11);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRenda;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCidades;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxVenda;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Label textBoxNome;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}