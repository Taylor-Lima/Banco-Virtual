using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.AplicationInterface
{
    public partial class Saque : Form
    {
        public Saque()
        {
            InitializeComponent();
        }
        public string PropriedadeSaque { get; set; }// recebe o cpf da outra tela

        public void button1_Click(object sender, EventArgs e)
        {
            IntroDen tr = new IntroDen();
            tr.Propriedade = textBox1.Text; //envia o cpf para a outra tela saldo
            tr.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)//saque btn

        {
            RealizarSaque();
            AtualizarSaldo();
            AtualizarNome();
        }

        private void RealizarSaque()
        {
            string cpf = textBox1.Text;
            string valorTexto = textDepositoTeste.Text; // txt teste que criei para digitar o valor

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(valorTexto))
            {
                MessageBox.Show("Por favor, insira um valor de saque válido.");
                return;
            }
            //validação para números negativos e para ponto e vírgula
            valorTexto = valorTexto.Replace('.', ',');// aceita ponto e vírgula, validando
            CultureInfo cultura = new CultureInfo("pt-BR");
            if (!decimal.TryParse(valorTexto, NumberStyles.Number, cultura, out decimal valorSaque) || valorSaque <= 0)
            {
                MessageBox.Show("Valor de saque inválido.");
                return;
            }

            // Verifica se o saldo é suficiente antes de realizar o saque
            if (!SaldoSuficiente(cpf, valorSaque))
            {
                MessageBox.Show("Saldo insuficiente para realizar o saque.");
                return;
            }

            Conexao db = new Conexao();
            try
            {
                db.Conectar();

                // Insira a transação de saque no banco de dados, consulta completa
                InserirSaque(db, cpf, valorSaque);

                AtualizarSaldo();

                MessageBox.Show("Saque realizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar saque: " + ex.Message);
            }
            finally
            {
                db.Desconectar();
            }
        }

        private void InserirSaque(Conexao db, string cpf, decimal valorSaque)
        {
            string query = @"INSERT INTO Movimento (codigoUsuario, valor, saldo, tipo)
            SELECT U.codigo, @valor, ISNULL((SELECT TOP 1 saldo FROM Movimento WHERE codigoUsuario = U.codigo ORDER BY dataTransacao DESC), 0) - @valor, 'Saque'
            FROM Usuario U
            WHERE U.cpf = @cpf";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@valor", valorSaque);
                cmd.ExecuteNonQuery();
            }
        }

        private bool SaldoSuficiente(string cpf, decimal valorSaque)
        {
            decimal saldoAtual = 0;

            string query = @"SELECT ISNULL((SELECT TOP 1 saldo FROM Movimento M 
                   JOIN Usuario U ON M.codigoUsuario = U.codigo 
                   WHERE U.cpf = @cpf ORDER BY dataTransacao DESC), 0)";

            using (Conexao db = new Conexao())
            {
                db.Conectar();
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    saldoAtual = (decimal)cmd.ExecuteScalar();
                }
            }

            return saldoAtual >= valorSaque;

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

                // Obtenha o saldo pelo CPF, busca completa
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Saque_Load(object sender, EventArgs e)//recebe
        {
            if (!this.PropriedadeSaque.Equals(""))
            {
                textBox1.Text = this.PropriedadeSaque;
            }
            AtualizarNome();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

