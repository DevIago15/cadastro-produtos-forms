using Projeto_Oak.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Oak
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            CriarProduto formProduto = new CriarProduto();
            this.Hide();
            formProduto.ShowDialog();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
