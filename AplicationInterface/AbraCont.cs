using Banco.Usuario;
using System.Data.SqlClient;

namespace Banco.AplicationInterface
{
    public partial class AbraCont : Form
    {
        Conexao db = new Conexao();


        public AbraCont()
        {
            InitializeComponent();
        }

        private void AbraCont_Load(object sender, EventArgs e)
        {
            Form1 n4 = new Form1();
            n4.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //telefone
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //senha
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Obtém os valores de todos os campos de texto
            string nome = textBox1.Text;
            string email = textBox3.Text;
            string endereco = textBox4.Text;
            string telefone = maskedTextBox2.Text;
            string dataNascimento = maskedTextBox1.Text;
            string cpf = maskedTextBox3.Text;
            string senha = textBox2.Text;

            // Verifica se algum campo está vazio na tabela cadastro, validando todos os campos!
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(endereco) ||
                string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(dataNascimento) ||
                string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha com seus dados.");
                return;
            }

            Conexao db = new Conexao();
            try
            {
                db.Conectar();

                // Verifica se o usuário já existe no banco de dados, fazendo a busca completa por CPf
                if (UsuarioExiste(db, cpf))
                {
                    MessageBox.Show("Usuário já cadastrado.");
                    return;
                }

                // Insere o novo usuário no banco de dados, pelo insert
                string query = "INSERT INTO Usuario (nome, email, endereco, telefone, dataNascimento, cpf, senha) VALUES (@nome, @email, @endereco, @telefone, @dataNascimento, @cpf, @senha)";
                using (SqlCommand command = new SqlCommand(query, db.Connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@endereco", endereco);
                    command.Parameters.AddWithValue("@telefone", telefone);
                    command.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                    command.Parameters.AddWithValue("@cpf", cpf);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar cadastro: " + ex.Message);
            }
            finally
            {
                db.Desconectar();
            }

            UsuarioNS telaP = new UsuarioNS();
            telaP.Show();
            this.Hide();
        }

        private bool UsuarioExiste(Conexao db, string cpf)
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE cpf = @cpf";
            using (SqlCommand command = new SqlCommand(query, db.Connection))
            {
                command.Parameters.AddWithValue("@cpf", cpf);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

       



        private void textBox1_TextChanged(object sender, EventArgs e) //nome
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //endereço
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //email
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //data nascimento
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // cpf
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 telap = new Form1();
            telap.Show();
            this.Hide();
        }
    }
}
