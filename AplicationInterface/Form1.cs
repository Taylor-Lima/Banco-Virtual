using Banco.AplicationInterface;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioNS n1 = new UsuarioNS();
            n1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbraCont n2 = new AbraCont();
            n2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sobre n3 = new sobre();
            n3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
