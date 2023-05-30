
namespace ControleDeEstoque
{
    partial class frmCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDadosProduto = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpDadosProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(109, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(517, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastros de Produtos";
            // 
            // grpDadosProduto
            // 
            this.grpDadosProduto.Controls.Add(this.txtQuantidade);
            this.grpDadosProduto.Controls.Add(this.cboFornecedor);
            this.grpDadosProduto.Controls.Add(this.txtPreco);
            this.grpDadosProduto.Controls.Add(this.txtCodigoDeBarras);
            this.grpDadosProduto.Controls.Add(this.cboCategoria);
            this.grpDadosProduto.Controls.Add(this.txtDescricao);
            this.grpDadosProduto.Controls.Add(this.txtNome);
            this.grpDadosProduto.Controls.Add(this.lblCategoria);
            this.grpDadosProduto.Controls.Add(this.lblQuantidade);
            this.grpDadosProduto.Controls.Add(this.lblFornecedor);
            this.grpDadosProduto.Controls.Add(this.lblPreco);
            this.grpDadosProduto.Controls.Add(this.lblCodigoDeBarras);
            this.grpDadosProduto.Controls.Add(this.lblDescricao);
            this.grpDadosProduto.Controls.Add(this.lblNome);
            this.grpDadosProduto.Location = new System.Drawing.Point(12, 83);
            this.grpDadosProduto.Name = "grpDadosProduto";
            this.grpDadosProduto.Size = new System.Drawing.Size(703, 168);
            this.grpDadosProduto.TabIndex = 1;
            this.grpDadosProduto.TabStop = false;
            this.grpDadosProduto.Text = "Dados do Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(610, 118);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(87, 26);
            this.txtQuantidade.TabIndex = 20;
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(374, 118);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(189, 26);
            this.cboFornecedor.TabIndex = 19;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(236, 118);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(88, 26);
            this.txtPreco.TabIndex = 18;
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(6, 118);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(180, 26);
            this.txtCodigoDeBarras.TabIndex = 17;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(493, 60);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(204, 26);
            this.cboCategoria.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(317, 60);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(138, 26);
            this.txtDescricao.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(255, 26);
            this.txtNome.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(490, 39);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 18);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(607, 97);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(37, 18);
            this.lblQuantidade.TabIndex = 11;
            this.lblQuantidade.Text = "Qtd:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(371, 97);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(93, 18);
            this.lblFornecedor.TabIndex = 9;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(233, 97);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(78, 18);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço R$:";
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(3, 97);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(137, 18);
            this.lblCodigoDeBarras.TabIndex = 5;
            this.lblCodigoDeBarras.Text = "Código de Barras:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(314, 39);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 18);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(272, 270);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(195, 50);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(195, 50);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(520, 270);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(195, 50);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 341);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.grpDadosProduto);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroProdutos_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastroProdutos_Load);
            this.grpDadosProduto.ResumeLayout(false);
            this.grpDadosProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDadosProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.TextBox txtPreco;
    }
}