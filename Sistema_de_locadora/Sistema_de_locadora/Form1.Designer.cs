
namespace Sistema_de_locadora
{
    partial class FormLocadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.tbDiscricao = new System.Windows.Forms.TextBox();
            this.btInativo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dglocadora = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dglocadora)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 31);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(80, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Título do Filme:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(96, 28);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 1;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(15, 54);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(181, 23);
            this.BtnInserir.TabIndex = 2;
            this.BtnInserir.Text = "INSERIR";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(202, 54);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(181, 23);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(482, 28);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria.TabIndex = 4;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(672, 28);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 20);
            this.tbAno.TabIndex = 5;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(404, 54);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(181, 23);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Location = new System.Drawing.Point(401, 31);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(55, 13);
            this.LabelCategoria.TabIndex = 7;
            this.LabelCategoria.Text = "Categoria:";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(588, 31);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(69, 13);
            this.lbAno.TabIndex = 8;
            this.lbAno.Text = "Lançamento:";
            // 
            // tbDiscricao
            // 
            this.tbDiscricao.Location = new System.Drawing.Point(283, 28);
            this.tbDiscricao.Name = "tbDiscricao";
            this.tbDiscricao.Size = new System.Drawing.Size(100, 20);
            this.tbDiscricao.TabIndex = 9;
            // 
            // btInativo
            // 
            this.btInativo.Location = new System.Drawing.Point(591, 54);
            this.btInativo.Name = "btInativo";
            this.btInativo.Size = new System.Drawing.Size(181, 23);
            this.btInativo.TabIndex = 10;
            this.btInativo.Text = "EXCLUIR";
            this.btInativo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição:";
            // 
            // dglocadora
            // 
            this.dglocadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglocadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clNome,
            this.clCategoria,
            this.clDescricao,
            this.clAno});
            this.dglocadora.Location = new System.Drawing.Point(15, 83);
            this.dglocadora.Name = "dglocadora";
            this.dglocadora.Size = new System.Drawing.Size(757, 216);
            this.dglocadora.TabIndex = 12;
            // 
            // clID
            // 
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.Width = 50;
            // 
            // clNome
            // 
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            this.clNome.Width = 170;
            // 
            // clCategoria
            // 
            this.clCategoria.HeaderText = "Categoria";
            this.clCategoria.Name = "clCategoria";
            this.clCategoria.Width = 113;
            // 
            // clDescricao
            // 
            this.clDescricao.HeaderText = "Descrição";
            this.clDescricao.Name = "clDescricao";
            this.clDescricao.Width = 330;
            // 
            // clAno
            // 
            this.clAno.HeaderText = "Ano";
            this.clAno.Name = "clAno";
            this.clAno.Width = 50;
            // 
            // FormLocadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.dglocadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInativo);
            this.Controls.Add(this.tbDiscricao);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.labelNome);
            this.Name = "FormLocadora";
            this.Text = "locadora";
            this.Load += new System.EventHandler(this.FormLocadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglocadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox tbDiscricao;
        private System.Windows.Forms.Button btInativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dglocadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAno;
    }
}

