using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banco.AplicationInterface
{
    public partial class IntroDen : Form
    {


        public IntroDen()
        {

            InitializeComponent();


        }
       
        public string Propriedade { get; set; }//recebe o cpf da tela de login
       
        //atualizar nome
        //=====================================================================================================
        private void label1_Click(object sender, EventArgs e)//nome do usuario
        {
            AtualizarNome();
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




        private void btnDeposito_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelsaldoreturn_Click(object sender, EventArgs e)
        {

        }

        private void buttonObterExtrato_Click(object sender, EventArgs e)
        {

        }
        //receber informação da tela de login
        //===============================================================================================================
        private void IntroDen_Load(object sender, EventArgs e)
        {
            if (!this.Propriedade.Equals(""))
            {
                textBox1.Text = this.Propriedade;// recebe o cpf da tela de login 
                AtualizarNome();
                AtualizarSaldo();
            }
           

        }
        //obter extrato
        //===========================================================================================================
        private void buttonObterExtrato_Click_1(object sender, EventArgs e)//btnextrato
        {
            AtualizarExtrato();// botão para chamar o método atualizar extrato, dentro da intro
        }
        private void AtualizarExtrato()
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

                // Obtenha o extrato pelo CPF, busca completa
                DataTable extrato = ObterExtratoPorCPF(db, cpf);

                dataGridView1.DataSource = extrato;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar extrato: " + ex.Message);
            }
            finally
            {
                db.Desconectar();
            }
        }
        private DataTable ObterExtratoPorCPF(Conexao db, string cpf)
        {
            DataTable extrato = new DataTable();

            string query = @"
            SELECT T.dataTransacao AS Data,FORMAT(T.valor, 'N2') AS Valor,FORMAT(T.saldo, 'N2') AS Saldo, T.tipo AS Tipo 
            FROM Movimento T
            JOIN Usuario U ON T.codigoUsuario = U.codigo
            WHERE U.cpf = @cpf
            ORDER BY T.dataTransacao DESC";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(extrato);
                }
            }

            return extrato;
        }


        private void btnsaldo_Click(object sender, EventArgs e)
        {

        }
        //exibir saldo na label
        //==========================================================================================================
        private void labelsaldoreturn_Click_1(object sender, EventArgs e)//label saldo
        {
            AtualizarSaldo();
            AtualizarNome();// tornando alabel clicavel
        }
        private void AtualizarSaldo() //método atualizar saldo, quase em todas as telas
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



        //saque
        //===================================================================================================================
       public void button1_Click(object sender, EventArgs e) // btnsaque
        {
            Saque sq = new Saque();
            sq.PropriedadeSaque = textBox1.Text; //envia o cpf para a outra tela saldo
            sq.Show();
            this.Hide();
        }
      
        


        private void btnsaldo_Click_1(object sender, EventArgs e)//btnsaldo
        {
            AtualizarSaldo();
            AtualizarNome();

        }

        //depósito
        //==================================================================================================================
        private void button4_Click(object sender, EventArgs e)//btndeposito
        {
            Deposito pv = new Deposito();
            pv.PropriedadeDeposito = textBox1.Text; //envia o cpf para a outra tela
            pv.PropriedadeDeposito1 = label1.Text; //envia o o nome para a outra tela deposito
            pv.Show();
            this.Hide();
            /* pv.Propriedade = maskedTextBox1.Text;*/ //envia o cpf para a outra tela

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e) //coleta de cpf
        {
            //PULO DO GATO
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//data grid extrato
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//textDepositoTeste
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
