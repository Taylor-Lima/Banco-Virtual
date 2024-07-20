namespace Banco.AplicationInterface
{
    partial class AbraCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbraCont));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox2 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(1142, 380);
            label1.Name = "label1";
            label1.Size = new Size(0, 42);
            label1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(64, 0, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(1083, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 19);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.BackColor = Color.FromArgb(64, 0, 64);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 7.8F);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(1083, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 19);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-37, -463);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1111, 1387);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(64, 0, 64);
            button1.Cursor = Cursors.AppStarting;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1167, 551);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(126, 43);
            button1.TabIndex = 9;
            button1.Text = "Cadastre-se";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top;
            maskedTextBox1.BackColor = Color.FromArgb(64, 0, 64);
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 7.8F);
            maskedTextBox1.ForeColor = SystemColors.Window;
            maskedTextBox1.Location = new Point(1081, 308);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(293, 19);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.Top;
            maskedTextBox2.BackColor = Color.FromArgb(64, 0, 64);
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 7.8F);
            maskedTextBox2.ForeColor = SystemColors.Window;
            maskedTextBox2.Location = new Point(1081, 239);
            maskedTextBox2.Mask = "(99) 0000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(293, 19);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(64, 0, 64);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 7.8F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(1078, 447);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 19);
            textBox2.TabIndex = 14;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Anchor = AnchorStyles.Top;
            maskedTextBox3.BackColor = Color.FromArgb(64, 0, 64);
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Font = new Font("Microsoft Sans Serif", 7.8F);
            maskedTextBox3.ForeColor = SystemColors.Window;
            maskedTextBox3.Location = new Point(1081, 378);
            maskedTextBox3.Mask = "000,000,000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(293, 19);
            maskedTextBox3.TabIndex = 15;
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top;
            textBox4.BackColor = Color.FromArgb(64, 0, 64);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Microsoft Sans Serif", 7.8F);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(1082, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 19);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1083, 26);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 17;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1083, 148);
            label3.Name = "label3";
            label3.Size = new Size(53, 13);
            label3.TabIndex = 18;
            label3.Text = "Endereço";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1079, 416);
            label4.Name = "label4";
            label4.Size = new Size(38, 13);
            label4.TabIndex = 19;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1079, 347);
            label5.Name = "label5";
            label5.Size = new Size(23, 13);
            label5.TabIndex = 20;
            label5.Text = "Cpf";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7.8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1078, 278);
            label6.Name = "label6";
            label6.Size = new Size(102, 13);
            label6.TabIndex = 21;
            label6.Text = "Data de nascimento";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.8F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1083, 210);
            label7.Name = "label7";
            label7.Size = new Size(49, 13);
            label7.TabIndex = 22;
            label7.Text = "Telefone";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1082, 84);
            label8.Name = "label8";
            label8.Size = new Size(32, 13);
            label8.TabIndex = 23;
            label8.Text = "Email";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(64, 0, 64);
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-31, 3);
            button2.Name = "button2";
            button2.Size = new Size(124, 8);
            button2.TabIndex = 24;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.BackColor = Color.FromArgb(64, 0, 64);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Microsoft Sans Serif", 7.8F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros", "Prefiro não dizer" });
            comboBox1.Location = new Point(1078, 491);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 21);
            comboBox1.TabIndex = 28;
            comboBox1.Text = "Gênero";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.FromArgb(64, 0, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift Condensed", 15F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(13, 9);
            button3.Name = "button3";
            button3.Size = new Size(101, 40);
            button3.TabIndex = 29;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AbraCont
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(17F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            CancelButton = button3;
            ClientSize = new Size(1384, 761);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(textBox2);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 23F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 8, 7, 8);
            Name = "AbraCont";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AbraCont";
            Load += AbraCont_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
    }
}