using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.AplicationInterface
{
    public partial class sobre : Form
    {
        public sobre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 n4 = new Form1();
            n4.Show();
            this.Hide();
        }

        private void sobre_Load(object sender, EventArgs e)
        {

        }
    }
}
