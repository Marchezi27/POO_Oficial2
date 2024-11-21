using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Oficial_2
{
    public partial class cadastro_funcionario : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        public cadastro_funcionario()
        {
            InitializeComponent();

            cmbCargoFuncionario.Items.Add("Caixa");
            cmbCargoFuncionario.Items.Add("Estoquista");
            cmbCargoFuncionario.Items.Add("Gerente");

            // Adiciona o evento de clique para o botão
            btnAdicionarFuncionario.Click += new EventHandler(ButtonAdicionarFuncionario_Click);
        }
        // Evento do botão para adicionar funcionário
        private void ButtonAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            // Validação para garantir que os campos não estejam vazios
            if (string.IsNullOrEmpty(txtNomeFuncionario.Text) || string.IsNullOrEmpty(txtSalarioFuncionario.Text) ||
                cmbCargoFuncionario.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                // Criação de um novo funcionário
                string nome = txtNomeFuncionario.Text;
                string cargo = cmbCargoFuncionario.SelectedItem.ToString();
                decimal salario = decimal.Parse(txtSalarioFuncionario.Text);

                Funcionario novoFuncionario = new Funcionario
                {
                    Nome = nome,
                    Cargo = cargo,
                    Salario = salario
                };

                // Adiciona o funcionário na lista
                funcionarios.Add(novoFuncionario);

                // Limpa os campos
                txtNomeFuncionario.Clear();
                txtSalarioFuncionario.Clear();
                cmbCargoFuncionario.SelectedItem = null;

                // Atualiza o ListBox com a lista de funcionários
                AtualizarListBoxFuncionarios();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um salário válido.");
            }
        }

        // Método para atualizar o ListBox com a lista de funcionários
        private void AtualizarListBoxFuncionarios()
        {
            listBoxFuncionarios.Items.Clear();
            foreach (var funcionario in funcionarios)
            {
                listBoxFuncionarios.Items.Add(funcionario);
            }
        }

        // Classe Funcionario
        public class Funcionario
        {
            public string Nome { get; set; }
            public string Cargo { get; set; }
            public decimal Salario { get; set; }

            // Método ToString para exibir os dados do funcionário no ListBox
            public override string ToString()
            {
                return $"{Nome} - {Cargo} - Salário: {Salario:C}";
            }
        }
    }
}
