namespace _221048.Views
{
    partial class FormCidades
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
            this.dataGridViewCidades = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCidades
            // 
            this.dataGridViewCidades.AllowUserToAddRows = false;
            this.dataGridViewCidades.AllowUserToDeleteRows = false;
            this.dataGridViewCidades.AllowUserToOrderColumns = true;
            this.dataGridViewCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCidades.Location = new System.Drawing.Point(18, 171);
            this.dataGridViewCidades.Name = "dataGridViewCidades";
            this.dataGridViewCidades.Size = new System.Drawing.Size(397, 150);
            this.dataGridViewCidades.TabIndex = 44;
            this.dataGridViewCidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCidades_CellClick_1);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(340, 142);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 43;
            this.buttonConsultar.Text = "Pesquisar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(18, 144);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(316, 20);
            this.textBoxPesquisa.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Digite o nome da cidade para pesquisar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "UF:";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(340, 70);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(75, 20);
            this.textBoxUF.TabIndex = 39;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(340, 97);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 38;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(259, 97);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 37;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(177, 97);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 36;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(96, 97);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 35;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(15, 97);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluir.TabIndex = 34;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(15, 70);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(319, 20);
            this.textBoxCidade.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cidade:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(15, 26);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 31;
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
            // FormCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewCidades);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label11);
            this.Name = "FormCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.Load += new System.EventHandler(this.FormCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCidades;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label11;
    }
}