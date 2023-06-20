
namespace Projeto_Oak.View
{
    partial class ListagemProdutos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemProdutos));
            this.btCriarProduto = new System.Windows.Forms.Button();
            this.dgListagem = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_OakDataSet = new Projeto_Oak.Projeto_OakDataSet();
            this.produtoTableAdapter = new Projeto_Oak.Projeto_OakDataSetTableAdapters.ProdutoTableAdapter();
            this.criarProduto = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_OakDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btCriarProduto
            // 
            this.btCriarProduto.Location = new System.Drawing.Point(456, 898);
            this.btCriarProduto.Name = "btCriarProduto";
            this.btCriarProduto.Size = new System.Drawing.Size(97, 64);
            this.btCriarProduto.TabIndex = 1;
            this.btCriarProduto.Text = "Criar Produto";
            this.btCriarProduto.UseVisualStyleBackColor = true;
            this.btCriarProduto.Click += new System.EventHandler(this.btCriarProduto_Click);
            // 
            // dgListagem
            // 
            this.dgListagem.AllowUserToAddRows = false;
            this.dgListagem.AllowUserToDeleteRows = false;
            this.dgListagem.AutoGenerateColumns = false;
            this.dgListagem.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.valorProdutoDataGridViewTextBoxColumn});
            this.dgListagem.DataSource = this.produtoBindingSource;
            this.dgListagem.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgListagem.Location = new System.Drawing.Point(12, 43);
            this.dgListagem.Name = "dgListagem";
            this.dgListagem.ReadOnly = true;
            this.dgListagem.RowHeadersWidth = 51;
            this.dgListagem.RowTemplate.Height = 24;
            this.dgListagem.Size = new System.Drawing.Size(371, 608);
            this.dgListagem.TabIndex = 2;
            this.dgListagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListagem_CellContentClick);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.projeto_OakDataSet;
            // 
            // projeto_OakDataSet
            // 
            this.projeto_OakDataSet.DataSetName = "Projeto_OakDataSet";
            this.projeto_OakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // criarProduto
            // 
            this.criarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.criarProduto.Image = ((System.Drawing.Image)(resources.GetObject("criarProduto.Image")));
            this.criarProduto.Location = new System.Drawing.Point(59, 669);
            this.criarProduto.Name = "criarProduto";
            this.criarProduto.Size = new System.Drawing.Size(274, 58);
            this.criarProduto.TabIndex = 3;
            this.criarProduto.UseVisualStyleBackColor = true;
            this.criarProduto.Click += new System.EventHandler(this.criarProduto_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btVoltar.Image")));
            this.btVoltar.Location = new System.Drawing.Point(112, 744);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(155, 58);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Frozen = true;
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorProdutoDataGridViewTextBoxColumn
            // 
            this.valorProdutoDataGridViewTextBoxColumn.DataPropertyName = "valorProduto";
            this.valorProdutoDataGridViewTextBoxColumn.HeaderText = "Valor do Produto";
            this.valorProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorProdutoDataGridViewTextBoxColumn.Name = "valorProdutoDataGridViewTextBoxColumn";
            this.valorProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ListagemProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(411, 851);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.criarProduto);
            this.Controls.Add(this.dgListagem);
            this.Controls.Add(this.btCriarProduto);
            this.Name = "ListagemProdutos";
            this.Text = "Listagem de Produtos";
            this.Load += new System.EventHandler(this.ListagemProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_OakDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCriarProduto;
        private System.Windows.Forms.DataGridView dgListagem;
        private Projeto_OakDataSet projeto_OakDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private Projeto_OakDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button criarProduto;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProdutoDataGridViewTextBoxColumn;
    }
}