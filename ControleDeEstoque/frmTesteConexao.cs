using BLL;
using System;
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
    public partial class frmTesteConexao : Form
    {
        public frmTesteConexao()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            TesteConexao teste = new TesteConexao();
            teste.Verificar();
            if (teste.conectar == null)
            {
                lblMensagem.BackColor = Color.Red;
                MessageBox.Show(teste.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblMensagem.BackColor = Color.Blue;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
