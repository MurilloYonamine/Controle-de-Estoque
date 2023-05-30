using BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }
        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            CadastroDados cadastroDados = new CadastroDados();
            CadastroDTO cadastro = new CadastroDTO();
            ArrayList categoriaLista = cadastroDados.PegarCategoria(cadastro);
            ArrayList fornecedorLista = cadastroDados.PegarFornecedor(cadastro);

            foreach (var categoria in categoriaLista)
            {
                cboCategoria.Items.Add(categoria);
            }

            foreach (var fornecedor in fornecedorLista)
            {
                cboFornecedor.Items.Add(fornecedor);
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDTO cadastro = new CadastroDTO();
            CadastroDados cadastroDados = new CadastroDados();

            cadastro.Nome = txtNome.Text;
            cadastro.Descricao = txtDescricao.Text;
            cadastro.Categoria = Convert.ToInt32(cboCategoria.Text.Split('-')[0]);
            cadastro.CodigoBarras = txtCodigoDeBarras.Text;
            cadastro.Preco = Convert.ToDecimal(txtPreco.Text);
            cadastro.Fornecedor = Convert.ToInt32(cboFornecedor.Text.Split('-')[0]);
            cadastro.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            cadastroDados.InserirDados(cadastro);
            MessageBox.Show(cadastro.Mensagem, "Aviso", MessageBoxButtons.OK);

            Limpar();
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            cboCategoria.SelectedItem = null;
            txtCodigoDeBarras.Clear();
            txtPreco.Clear();
            cboFornecedor.SelectedItem = null;
            txtQuantidade.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCadastroProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEntradaSaida telaAnterior = new frmEntradaSaida();
            telaAnterior.Show();
            this.Hide();
        }
    }
}
