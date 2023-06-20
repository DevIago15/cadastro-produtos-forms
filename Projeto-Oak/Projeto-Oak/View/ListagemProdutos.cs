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
    public partial class ListagemProdutos : Form
    {
        public ListagemProdutos()
        {
            InitializeComponent();
        }

        private void btCriarProduto_Click(object sender, EventArgs e)
        {
            CriarProduto formCriarProduto = new CriarProduto();
            formCriarProduto.ShowDialog();
        }

        public void dgListagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListagemProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_OakDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.projeto_OakDataSet.Produto);

            ProdutoIDAO prodIdao = new ProdutoIDAO();
            DataTable ProdutoDataTable = (DataTable)prodIdao.consultar2();
            dgListagem.DataSource = ProdutoDataTable;
        }

        private void criarProduto_Click(object sender, EventArgs e)
        {
            CriarProduto formCriarProduto = new CriarProduto();
            this.Hide();
            formCriarProduto.ShowDialog();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();

            this.Hide();
            formMenu.ShowDialog();
           
        }
    }
}
