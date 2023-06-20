using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Oak.Model;
using Projeto_Oak.Model.Entities;
using Projeto_Oak.View;

namespace Projeto_Oak.View
{
    public partial class CriarProduto : Form
    {
        public CriarProduto()
        {
            InitializeComponent();
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btConfirmarCadastro_Click(object sender, EventArgs e)
        {
            ListagemProdutos formListagem = new ListagemProdutos();
            Produto prod = new Produto();
            ProdutoIDAO prodIdao = new ProdutoIDAO();

            float valor;
            if (float.TryParse(txtValor.Text, out valor))
            {
                prod.ValorProduto = valor;
            }

            
            if (!string.IsNullOrEmpty(txtNomeProduto.Text) && !string.IsNullOrEmpty(txtValor.Text) && !string.IsNullOrEmpty(txtDisponibilidade.Text) && !string.IsNullOrEmpty(txtDescricao.Text))
            {
                prod.NomeProduto = txtNomeProduto.Text;
                prod.ValorProduto = valor;
                prod.DispProduto = txtDisponibilidade.Text;
                prod.DescProduto = txtDescricao.Text;

                int idInserido = prodIdao.inserir1(prod);

                DataTable ProdutoDataTable = (DataTable)prodIdao.consultar1(prod);
                ProdutoDataTable.DefaultView.Sort = "valorProduto ASC";
                this.Hide();
                formListagem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro: Preencha os Campos Corretamente para Ser Salvo no Banco Dados");
            }

        }

        private void txtDisponibilidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
