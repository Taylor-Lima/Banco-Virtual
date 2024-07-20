using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Banco.AplicationInterface
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }
        public string PropriedadeDeposito { get; set; }// recebe o cpf da outra tela
        public string PropriedadeDeposito1 { get; set; }// recebe o nome da outra tela

        private void button2_Click(object sender, EventArgs e)
        {
            IntroDen pf = new IntroDen();
            pf.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//receber cpf
        {

        }

        private void button4_Click(object sender, EventArgs e)//botão depósito
        {
            RealizarDeposito();// chamar o método de depósito no botao 4
            AtualizarSaldo(); //
            AtualizarNome();

        }
        private void RealizarDeposito()
        {
            string cpf = textBox1.Text;
            string valorTexto = textDepositoTeste.Text;//txt teste que criei para digitar o valor

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(valorTexto))
            {
                MessageBox.Show("Por favor, insira um valor de depósito válido.");
                return;
            }
            //validação para números negativos e para ponto e vírgula
            valorTexto = valorTexto.Replace('.', ',');
            CultureInfo cultura = new CultureInfo("pt-BR");
            if (!decimal.TryParse(valorTexto, NumberStyles.Number, cultura, out decimal valorDeposito) || valorDeposito <= 0)
            {
                MessageBox.Show("Valor de depósito inválido.");
                return;
            }

            Conexao db = new Conexao();
            try
            {
                db.Conectar();

                // Insere a transação de depósito no banco de dados
                InserirDeposito(db, cpf, valorDeposito);

                // Atualize o saldo exibido
                //AtualizarSaldo(); --------> pendente
                MessageBox.Show("Depósito realizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar depósito: " + ex.Message);
            }
            finally
            {
                db.Desconectar();
            }
        }

        private void InserirDeposito(Conexao db, string cpf, decimal valorDeposito)
        {
            string query = @"INSERT INTO Movimento (codigoUsuario, valor, saldo, tipo)
            SELECT U.codigo, @valor, ISNULL((SELECT TOP 1 saldo FROM Movimento WHERE codigoUsuario = U.codigo ORDER BY dataTransacao DESC), 0) + @valor, 'Depósito'
             FROM Usuario U
             WHERE U.cpf = @cpf";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@valor", valorDeposito);
                cmd.ExecuteNonQuery();
            }
        }
        private void AtualizarNome()
        {
            string cpf = textBox1.Text;

            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.");
                return;
            }

            Conexao db = new Conexao();
            try
            {
                db.Conectar();

                // Obtenha o nome pelo CPF, busca completa
                string nome = ObterNomePorCPF(db, cpf);

                label1.Text = $" {nome}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar nome: " + ex.Message);
            }
            finally
            {
                db.Desconectar();
            }
        }
        private string ObterNomePorCPF(Conexao db, string cpf)
        {
            string nome = string.Empty;

            string query = @"
            SELECT nome 
            FROM Usuario
            WHERE cpf = @cpf";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nome = reader.GetString(0);
                    }
                }
            }

            return nome;
        }
        //recebe informação da tela IntroDen
        //===============================================================================================================
        private void Deposito_Load(object sender, EventArgs e)
        {
            if (!this.PropriedadeDeposito.Equals(""))
            {
                textBox1.Text = this.PropriedadeDeposito;
                label1.Text = this.PropriedadeDeposito1;
            }
            AtualizarNome();
            AtualizarSaldo();
        }

        private void labelsaldoreturn_Click(object sender, EventArgs e)
        {
            AtualizarSaldo();
            
        }
        private void AtualizarSaldo() 
        {
            string cpf = textBox1.Text;

            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.");
                return;
            }

            Conexao db = new Conexao();
            try
            {
                db.Conectar();

                // Obtenha o saldo pelo CPF, validação completa
                SqlMoney saldo = ObterSaldoPorCPF(db, cpf);

                labelsaldoreturn.Text = $"Saldo: {saldo.Value:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar saldo: " + ex.Message);
            }
            finally
            {
                db.Desconectar();
            }

        }

        private SqlMoney ObterSaldoPorCPF(Conexao db, string cpf)
        {
            SqlMoney saldo = 0;

            string query = @"
            SELECT TOP 1 saldo 
            FROM Movimento T
            JOIN Usuario U ON T.codigoUsuario = U.codigo
            WHERE U.cpf = @cpf
            ORDER BY T.dataTransacao DESC";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        saldo = reader.GetSqlMoney(0);
                    }
                }
            }

            return saldo;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            IntroDen pf = new IntroDen();
            pf.Propriedade = textBox1.Text; //envia o cpf para a outra tela saldo
            pf.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
