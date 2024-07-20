namespace Banco.AplicationInterface
{
    partial class UsuarioNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioNS));
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(664, 212);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(655, 294);
            label2.Name = "label2";
            label2.Size = new Size(97, 31);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(64, 0, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(658, 409);
            button2.Name = "button2";
            button2.Size = new Size(78, 26);
            button2.TabIndex = 5;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 0, 64);
            button3.Cursor = Cursors.AppStarting;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 2);
            button3.Name = "button3";
            button3.Size = new Size(103, 34);
            button3.TabIndex = 12;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(644, 377);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu a senha?";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top;
            maskedTextBox1.BackColor = Color.FromArgb(64, 0, 64);
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Cursor = Cursors.IBeam;
            maskedTextBox1.Font = new Font("Segoe UI", 15F);
            maskedTextBox1.ForeColor = SystemColors.Window;
            maskedTextBox1.Location = new Point(627, 257);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(144, 34);
            maskedTextBox1.TabIndex = 18;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected_1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.Top;
            maskedTextBox2.BackColor = Color.FromArgb(64, 0, 64);
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Cursor = Cursors.IBeam;
            maskedTextBox2.Font = new Font("Segoe UI", 15F);
            maskedTextBox2.Location = new Point(627, 340);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(144, 34);
            maskedTextBox2.TabIndex = 19;
            maskedTextBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-214, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 290);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-345, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(712, 425);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-166, 519);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(712, 425);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-206, 370);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(712, 425);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(193, -33);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(712, 425);
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click_2;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(529, -7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(712, 425);
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(300, 461);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(712, 425);
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(594, 195);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(712, 425);
            pictureBox9.TabIndex = 28;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(1200, 668);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(712, 425);
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(667, 461);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(769, 348);
            pictureBox8.TabIndex = 32;
            pictureBox8.TabStop = false;
            // 
            // UsuarioNS
            // 
            AcceptButton = button2;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            CancelButton = button3;
            ClientSize = new Size(1384, 761);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox9);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UsuarioNS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsuarioNS";
            Load += UsuarioNS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private PictureBox pictureBox8;
    }
}