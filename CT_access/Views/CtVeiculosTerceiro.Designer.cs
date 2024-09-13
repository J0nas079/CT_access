namespace CT_access.Views
{
    partial class CtVeiculosTerceiro
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtempresa = new TextBox();
            label2 = new Label();
            maskdata = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            maskh_entrada = new MaskedTextBox();
            maskh_saida = new MaskedTextBox();
            n = new Label();
            txtmotorista = new TextBox();
            label6 = new Label();
            txtplaca = new TextBox();
            label7 = new Label();
            txtfabrica = new TextBox();
            label8 = new Label();
            txtautorizado = new TextBox();
            label9 = new Label();
            txtcnh = new TextBox();
            dataGridView1 = new DataGridView();
            ctVeiculosTerBindingSource = new BindingSource(components);
            btnEnviar = new Button();
            btnEditar = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hentradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hsaidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fabricaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autorizadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cnhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiculosTerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 16);
            label1.TabIndex = 0;
            label1.Text = "Empresa";
            // 
            // txtempresa
            // 
            txtempresa.Location = new Point(123, 62);
            txtempresa.Margin = new Padding(4, 3, 4, 3);
            txtempresa.Name = "txtempresa";
            txtempresa.Size = new Size(196, 24);
            txtempresa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 2;
            label2.Text = "Data:";
            // 
            // maskdata
            // 
            maskdata.Location = new Point(123, 16);
            maskdata.Margin = new Padding(4, 3, 4, 3);
            maskdata.Mask = "00/00/0000";
            maskdata.Name = "maskdata";
            maskdata.Size = new Size(128, 24);
            maskdata.TabIndex = 3;
            maskdata.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 16);
            label3.TabIndex = 4;
            label3.Text = "Hora Entrada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 16);
            label4.TabIndex = 6;
            label4.Text = "Hora Saida";
            // 
            // maskh_entrada
            // 
            maskh_entrada.Location = new Point(123, 118);
            maskh_entrada.Margin = new Padding(4, 3, 4, 3);
            maskh_entrada.Mask = "90:00";
            maskh_entrada.Name = "maskh_entrada";
            maskh_entrada.Size = new Size(128, 24);
            maskh_entrada.TabIndex = 2;
            maskh_entrada.ValidatingType = typeof(DateTime);
            // 
            // maskh_saida
            // 
            maskh_saida.Location = new Point(123, 174);
            maskh_saida.Margin = new Padding(4, 3, 4, 3);
            maskh_saida.Mask = "90:00";
            maskh_saida.Name = "maskh_saida";
            maskh_saida.Size = new Size(128, 24);
            maskh_saida.TabIndex = 3;
            maskh_saida.ValidatingType = typeof(DateTime);
            // 
            // n
            // 
            n.AutoSize = true;
            n.Location = new Point(52, 230);
            n.Margin = new Padding(4, 0, 4, 0);
            n.Name = "n";
            n.Size = new Size(47, 16);
            n.TabIndex = 9;
            n.Text = "Nome";
            // 
            // txtmotorista
            // 
            txtmotorista.Location = new Point(123, 226);
            txtmotorista.Margin = new Padding(4, 3, 4, 3);
            txtmotorista.Name = "txtmotorista";
            txtmotorista.Size = new Size(196, 24);
            txtmotorista.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(531, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 11;
            label6.Text = "Placa";
            // 
            // txtplaca
            // 
            txtplaca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtplaca.Location = new Point(595, 16);
            txtplaca.Margin = new Padding(4, 3, 4, 3);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(133, 24);
            txtplaca.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(519, 79);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 16);
            label7.TabIndex = 13;
            label7.Text = "Fabrica";
            // 
            // txtfabrica
            // 
            txtfabrica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtfabrica.Location = new Point(595, 70);
            txtfabrica.Margin = new Padding(4, 3, 4, 3);
            txtfabrica.Name = "txtfabrica";
            txtfabrica.Size = new Size(196, 24);
            txtfabrica.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(496, 126);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 16);
            label8.TabIndex = 15;
            label8.Text = "Autorizado";
            // 
            // txtautorizado
            // 
            txtautorizado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtautorizado.Location = new Point(595, 126);
            txtautorizado.Margin = new Padding(4, 3, 4, 3);
            txtautorizado.Name = "txtautorizado";
            txtautorizado.Size = new Size(196, 24);
            txtautorizado.TabIndex = 7;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(529, 174);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 16);
            label9.TabIndex = 17;
            label9.Text = "CNH:";
            // 
            // txtcnh
            // 
            txtcnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtcnh.Location = new Point(595, 174);
            txtcnh.Margin = new Padding(4, 3, 4, 3);
            txtcnh.Name = "txtcnh";
            txtcnh.Size = new Size(219, 24);
            txtcnh.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, empresaDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, hentradaDataGridViewTextBoxColumn, hsaidaDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, fabricaDataGridViewTextBoxColumn, autorizadoDataGridViewTextBoxColumn, cnhDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ctVeiculosTerBindingSource;
            dataGridView1.Location = new Point(25, 289);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(876, 231);
            dataGridView1.TabIndex = 19;
            // 
            // ctVeiculosTerBindingSource
            // 
            ctVeiculosTerBindingSource.DataSource = typeof(Models.Ct_VeiculosTer);
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnviar.Location = new Point(705, 238);
            btnEnviar.Margin = new Padding(4, 3, 4, 3);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(85, 39);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(815, 238);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 39);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // hentradaDataGridViewTextBoxColumn
            // 
            hentradaDataGridViewTextBoxColumn.DataPropertyName = "h_entrada";
            hentradaDataGridViewTextBoxColumn.HeaderText = "Hora Entrada";
            hentradaDataGridViewTextBoxColumn.Name = "hentradaDataGridViewTextBoxColumn";
            // 
            // hsaidaDataGridViewTextBoxColumn
            // 
            hsaidaDataGridViewTextBoxColumn.DataPropertyName = "h_saida";
            hsaidaDataGridViewTextBoxColumn.HeaderText = "Hora Saida";
            hsaidaDataGridViewTextBoxColumn.Name = "hsaidaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // fabricaDataGridViewTextBoxColumn
            // 
            fabricaDataGridViewTextBoxColumn.DataPropertyName = "fabrica";
            fabricaDataGridViewTextBoxColumn.HeaderText = "Fabrica";
            fabricaDataGridViewTextBoxColumn.Name = "fabricaDataGridViewTextBoxColumn";
            // 
            // autorizadoDataGridViewTextBoxColumn
            // 
            autorizadoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            autorizadoDataGridViewTextBoxColumn.DataPropertyName = "autorizado";
            autorizadoDataGridViewTextBoxColumn.HeaderText = "Autorizado";
            autorizadoDataGridViewTextBoxColumn.Name = "autorizadoDataGridViewTextBoxColumn";
            // 
            // cnhDataGridViewTextBoxColumn
            // 
            cnhDataGridViewTextBoxColumn.DataPropertyName = "cnh";
            cnhDataGridViewTextBoxColumn.HeaderText = "CNH";
            cnhDataGridViewTextBoxColumn.Name = "cnhDataGridViewTextBoxColumn";
            // 
            // CtVeiculosTerceiro
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(915, 534);
            Controls.Add(btnEditar);
            Controls.Add(btnEnviar);
            Controls.Add(dataGridView1);
            Controls.Add(txtcnh);
            Controls.Add(label9);
            Controls.Add(txtautorizado);
            Controls.Add(label8);
            Controls.Add(txtfabrica);
            Controls.Add(label7);
            Controls.Add(txtplaca);
            Controls.Add(label6);
            Controls.Add(txtmotorista);
            Controls.Add(n);
            Controls.Add(maskh_saida);
            Controls.Add(maskh_entrada);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskdata);
            Controls.Add(label2);
            Controls.Add(txtempresa);
            Controls.Add(label1);
            Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CtVeiculosTerceiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CtVeiculosTerceiro";
            Load += CtVeiculosTerceiro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiculosTerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtempresa;
        private Label label2;
        private MaskedTextBox maskdata;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskh_entrada;
        private MaskedTextBox maskh_saida;
        private Label n;
        private TextBox txtmotorista;
        private Label label6;
        private TextBox txtplaca;
        private Label label7;
        private TextBox txtfabrica;
        private Label label8;
        private TextBox txtautorizado;
        private Label label9;
        private TextBox txtcnh;
        private DataGridView dataGridView1;
        private Button btnEnviar;
        private Button btnEditar;
        private BindingSource ctVeiculosTerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hentradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsaidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fabricaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorizadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnhDataGridViewTextBoxColumn;
    }
}