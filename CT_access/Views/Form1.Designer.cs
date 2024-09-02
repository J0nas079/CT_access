namespace CT_access
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btm01 = new Button();
            labelSenha = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(157, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(169, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 24);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 24);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // btm01
            // 
            btm01.BackColor = Color.Green;
            btm01.Font = new Font("Antique Olive", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btm01.ForeColor = Color.White;
            btm01.Location = new Point(319, 129);
            btm01.Name = "btm01";
            btm01.Size = new Size(90, 39);
            btm01.TabIndex = 4;
            btm01.Text = "Entrar";
            btm01.UseVisualStyleBackColor = false;
            btm01.Click += btm01_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.ForeColor = Color.Red;
            labelSenha.Location = new Point(278, 108);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(0, 16);
            labelSenha.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btm01;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(543, 180);
            Controls.Add(pictureBox1);
            Controls.Add(labelSenha);
            Controls.Add(btm01);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btm01;
        private Label labelSenha;
        private PictureBox pictureBox1;
    }
}
