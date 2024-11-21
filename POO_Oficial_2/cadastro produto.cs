using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Oficial_2
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        private TextBox txtNomeProduto;
        private TextBox txtPrecoProduto;
        private TextBox txtQuantidadeEstoque;
        private TextBox txtCodigoBarras;
        private Button btnAdicionarProduto;
        private ListBox listBoxProdutos;

        public Form1()
        {
            InitializeComponent();

            txtNomeProduto = this.textBox1;
            txtPrecoProduto = this.textBox2;
            txtQuantidadeEstoque = this.textBox3;
            txtCodigoBarras = this.textBox4;
            btnAdicionarProduto = this.button1;
            listBoxProdutos = this.ListBoxProduto;

            // Criação do botão para abrir o formulário de funcionários
            Button btnAbrirFuncionario = new Button
            {
                Text = "Cadastro Funcionários",
                Location = new System.Drawing.Point(400, 10),
                Size = new System.Drawing.Size(100, 50)
            };

            // Evento para abrir o formulário de funcionários
            btnAbrirFuncionario.Click += new EventHandler(BtnAbrirFuncionario_Click);

            // Adiciona o botão no formulário principal
            this.Controls.Add(btnAbrirFuncionario);
        }

        // Evento de clique do botão para abrir o FormFuncionario
        private void BtnAbrirFuncionario_Click(object sender, EventArgs e)
        {
            cadastro_funcionario formFuncionario = new cadastro_funcionario();
            formFuncionario.ShowDialog();  // Abre o formulário de cadastro de funcionários
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            string nome = txtNomeProduto.Text;
            decimal preco = decimal.Parse(txtPrecoProduto.Text);
            int quantidade = int.Parse(txtQuantidadeEstoque.Text);
            string codigoDeBarras = txtCodigoBarras.Text;

            Produto novoProduto = new Produto
            {
                Nome = nome,
                Preco = preco,
                QuantidadeEstoque = quantidade,
                CodigoDeBarras = codigoDeBarras
            };

            produtos.Add(novoProduto);

            txtNomeProduto.Clear();
            txtPrecoProduto.Clear();
            txtQuantidadeEstoque.Clear();
            txtCodigoBarras.Clear();

            // Atualizar o ListBox
            listBoxProdutos.Items.Clear(); // Limpar itens antigos
            foreach (var produto in produtos)
            {
                listBoxProdutos.Items.Add(produto); // Adicionar os produtos à lista
            }
        }


        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int QuantidadeEstoque { get; set; }
            public string CodigoDeBarras { get; set; }

            // Método para formatar o produto para exibição
            public override string ToString()
            {
                return $"{Nome} - {Preco:C} - Estoque: {QuantidadeEstoque} - Código: {CodigoDeBarras}";
            }
        }
    }
}
