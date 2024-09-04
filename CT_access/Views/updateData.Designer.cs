namespace CT_access.Views
{
    partial class updateData
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
            label1 = new Label();
            label2 = new Label();
            txtKMentra = new TextBox();
            maskHREntrada = new MaskedTextBox();
            button1 = new Button();
            label4 = new Label();
            panel1 = new Panel();
            txtid = new TextBox();
            label3 = new Label();
            maskdata = new MaskedTextBox();
            lblok = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 203);
            label1.Name = "label1";
            label1.Size = new Size(98, 16);
            label1.TabIndex = 2;
            label1.Text = "Hora/Retorno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 86);
            label2.Name = "label2";
            label2.Size = new Size(20, 16);
            label2.TabIndex = 0;
            label2.Text = "id";
            // 
            // txtKMentra
            // 
            txtKMentra.Location = new Point(179, 160);
            txtKMentra.Name = "txtKMentra";
            txtKMentra.Size = new Size(142, 24);
            txtKMentra.TabIndex = 2;
            // 
            // maskHREntrada
            // 
            maskHREntrada.Location = new Point(179, 199);
            maskHREntrada.Mask = "00:00";
            maskHREntrada.Name = "maskHREntrada";
            maskHREntrada.Size = new Size(142, 24);
            maskHREntrada.TabIndex = 3;
            maskHREntrada.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Location = new Point(179, 243);
            button1.Name = "button1";
            button1.Size = new Size(86, 25);
            button1.TabIndex = 4;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 164);
            label4.Name = "label4";
            label4.Size = new Size(86, 16);
            label4.TabIndex = 11;
            label4.Text = "KM/Retorno";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblok);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 44);
            panel1.TabIndex = 12;
            // 
            // txtid
            // 
            txtid.Location = new Point(188, 83);
            txtid.Name = "txtid";
            txtid.Size = new Size(31, 24);
            txtid.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 122);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 15;
            label3.Text = "Data Retoro";
            // 
            // maskdata
            // 
            maskdata.Location = new Point(179, 121);
            maskdata.Mask = "00/00/0000";
            maskdata.Name = "maskdata";
            maskdata.Size = new Size(103, 24);
            maskdata.TabIndex = 16;
            maskdata.ValidatingType = typeof(DateTime);
            // 
            // lblok
            // 
            lblok.BackColor = Color.White;
            lblok.Font = new Font("Antique Olive", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblok.ForeColor = Color.Red;
            lblok.Location = new Point(119, 14);
            lblok.Name = "lblok";
            lblok.Size = new Size(182, 20);
            lblok.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(63, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 226);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // updateData
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(432, 335);
            Controls.Add(maskdata);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(maskHREntrada);
            Controls.Add(txtKMentra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "updateData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "updateData";
            Load += updateData_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtKMentra;
        private MaskedTextBox maskHREntrada;
        private Button button1;
        private Label label4;
        private Panel panel1;
        private TextBox txtid;
        private Label label3;
        private MaskedTextBox maskdata;
        private Label lblok;
        private GroupBox groupBox1;
    }
}