using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System;
using Banco;
using Banco.Usuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;

namespace Banco.AplicationInterface
{
    public partial class UsuarioNS : Form
    {

        public UsuarioNS()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)// botão entrar
        {
            Conexao db = new Conexao();
            db.Conectar();

            Usuariob usuario = new Usuariob();
            usuario.cpf = maskedTextBox1.Text;
            usuario.senha = maskedTextBox2.Text;

            var retorno = db.BuscarUsuario(usuario.cpf, usuario.senha);

            if (!retorno)
            {
                MessageBox.Show("Dados incorretos");
            }

            if (retorno)
            {
                MessageBox.Show("Seja Bem Vindo a PX");
                IntroDen pv = new IntroDen();
                pv.Propriedade = maskedTextBox1.Text; //envia o cpf para a outra tela
                pv.Show();
                this.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 telalogin = new Form1();
            telalogin.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UsuarioNS_Load(object sender, EventArgs e)
        {
            //conn.Open();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 telalogin = new Form1();
            telalogin.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 telalogin = new Form1();
            telalogin.Show();
            this.Hide();
        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {

        }

        private void labelsaldoreturn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

