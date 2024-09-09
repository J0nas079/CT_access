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
            txtid = new TextBox();
            label3 = new Label();
            maskdata = new MaskedTextBox();
            groupBox1 = new GroupBox();
            lblATT = new Label();
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
            // groupBox1
            // 
            groupBox1.Location = new Point(63, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 247);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // lblATT
            // 
            lblATT.AutoSize = true;
            lblATT.Location = new Point(168, 277);
            lblATT.Name = "lblATT";
            lblATT.Size = new Size(0, 16);
            lblATT.TabIndex = 18;
            // 
            // updateData
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(432, 302);
            Controls.Add(lblATT);
            Controls.Add(maskdata);
            Controls.Add(label3);
            Controls.Add(txtid);
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
        private TextBox txtid;
        private Label label3;
        private MaskedTextBox maskdata;
        private GroupBox groupBox1;
        private Label lblATT;
    }
}