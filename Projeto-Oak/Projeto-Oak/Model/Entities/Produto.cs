using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Oak.Model.Entities
{
    public class Produto
    {
        private int idProduto;
        private string nomeProduto;
        private float valorProduto;
        private string dispProduto;
        private string descProduto;

        public Produto()
        {
            idProduto = 0;
            nomeProduto = "";
            valorProduto = 0;
            dispProduto = "";
            descProduto = "";

        }

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public float ValorProduto
        {
            get { return valorProduto; }
            set { valorProduto = value; }
        }

        public string DispProduto
        {
            get { return dispProduto; }
            set { dispProduto = value; }
        }
        public string DescProduto
        {
            get { return descProduto; }
            set { descProduto = value; }
        }

    }


}
