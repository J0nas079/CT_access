namespace CT_access
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            entradaCaminhõesToolStripMenuItem = new ToolStripMenuItem();
            veiculosDaEmpresaToolStripMenuItem = new ToolStripMenuItem();
            enrraSaidaDeFuncionaroToolStripMenuItem = new ToolStripMenuItem();
            entregaDeChavesToolStripMenuItem = new ToolStripMenuItem();
            visualizarDadosCadastradosToolStripMenuItem = new ToolStripMenuItem();
            entradaDeCaminhoesToolStripMenuItem = new ToolStripMenuItem();
            veiculosEmpresaToolStripMenuItem = new ToolStripMenuItem();
            entradaESaídaDeFuncionariosToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            txtcnh = new TextBox();
            label8 = new Label();
            label9 = new Label();
            datagradeView = new DataGridView();
            caminhaoBindingSource = new BindingSource(components);
            btneditar = new Button();
            btndeletar = new Button();
            label1 = new Label();
            txtplaca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtempresa = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label10 = new Label();
            maskentrada = new MaskedTextBox();
            txtmotorista = new TextBox();
            masksaida = new MaskedTextBox();
            label11 = new Label();
            maskData = new MaskedTextBox();
            txtautorizado = new TextBox();
            btnenviar = new Button();
            cbx01 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            setorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cnhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motoristaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autorizadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hentradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hsaidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagradeView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caminhaoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarDadosCadastradosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(813, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaCaminhõesToolStripMenuItem, veiculosDaEmpresaToolStripMenuItem, enrraSaidaDeFuncionaroToolStripMenuItem, entregaDeChavesToolStripMenuItem });
            cadastrarToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem.Image");
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(97, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // entradaCaminhõesToolStripMenuItem
            // 
            entradaCaminhõesToolStripMenuItem.Image = (Image)resources.GetObject("entradaCaminhõesToolStripMenuItem.Image");
            entradaCaminhõesToolStripMenuItem.Name = "entradaCaminhõesToolStripMenuItem";
            entradaCaminhõesToolStripMenuItem.Size = new Size(269, 22);
            entradaCaminhõesToolStripMenuItem.Text = "Entrada Caminhões";
            // 
            // veiculosDaEmpresaToolStripMenuItem
            // 
            veiculosDaEmpresaToolStripMenuItem.Name = "veiculosDaEmpresaToolStripMenuItem";
            veiculosDaEmpresaToolStripMenuItem.Size = new Size(269, 22);
            veiculosDaEmpresaToolStripMenuItem.Text = "Veiculos da Empresa";
            veiculosDaEmpresaToolStripMenuItem.Click += veiculosDaEmpresaToolStripMenuItem_Click;
            // 
            // enrraSaidaDeFuncionaroToolStripMenuItem
            // 
            enrraSaidaDeFuncionaroToolStripMenuItem.Name = "enrraSaidaDeFuncionaroToolStripMenuItem";
            enrraSaidaDeFuncionaroToolStripMenuItem.Size = new Size(269, 22);
            enrraSaidaDeFuncionaroToolStripMenuItem.Text = "Entrada/Saida de Funcionario";
            // 
            // entregaDeChavesToolStripMenuItem
            // 
            entregaDeChavesToolStripMenuItem.Name = "entregaDeChavesToolStripMenuItem";
            entregaDeChavesToolStripMenuItem.Size = new Size(269, 22);
            entregaDeChavesToolStripMenuItem.Text = "Entrega de Chaves";
            // 
            // visualizarDadosCadastradosToolStripMenuItem
            // 
            visualizarDadosCadastradosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaDeCaminhoesToolStripMenuItem, veiculosEmpresaToolStripMenuItem, entradaESaídaDeFuncionariosToolStripMenuItem, eToolStripMenuItem });
            visualizarDadosCadastradosToolStripMenuItem.Image = (Image)resources.GetObject("visualizarDadosCadastradosToolStripMenuItem.Image");
            visualizarDadosCadastradosToolStripMenuItem.Name = "visualizarDadosCadastradosToolStripMenuItem";
            visualizarDadosCadastradosToolStripMenuItem.Size = new Size(224, 20);
            visualizarDadosCadastradosToolStripMenuItem.Text = "Visualizar dados cadastrados";
            // 
            // entradaDeCaminhoesToolStripMenuItem
            // 
            entradaDeCaminhoesToolStripMenuItem.Image = (Image)resources.GetObject("entradaDeCaminhoesToolStripMenuItem.Image");
            entradaDeCaminhoesToolStripMenuItem.Name = "entradaDeCaminhoesToolStripMenuItem";
            entradaDeCaminhoesToolStripMenuItem.Size = new Size(274, 22);
            entradaDeCaminhoesToolStripMenuItem.Text = "Entrada de Caminhoes";
            entradaDeCaminhoesToolStripMenuItem.Click += entradaDeCaminhoesToolStripMenuItem_Click;
            // 
            // veiculosEmpresaToolStripMenuItem
            // 
            veiculosEmpresaToolStripMenuItem.Image = (Image)resources.GetObject("veiculosEmpresaToolStripMenuItem.Image");
            veiculosEmpresaToolStripMenuItem.Name = "veiculosEmpresaToolStripMenuItem";
            veiculosEmpresaToolStripMenuItem.Size = new Size(274, 22);
            veiculosEmpresaToolStripMenuItem.Text = "Veiculos Empresa";
            veiculosEmpresaToolStripMenuItem.Click += veiculosEmpresaToolStripMenuItem_Click;
            // 
            // entradaESaídaDeFuncionariosToolStripMenuItem
            // 
            entradaESaídaDeFuncionariosToolStripMenuItem.Image = (Image)resources.GetObject("entradaESaídaDeFuncionariosToolStripMenuItem.Image");
            entradaESaídaDeFuncionariosToolStripMenuItem.Name = "entradaESaídaDeFuncionariosToolStripMenuItem";
            entradaESaídaDeFuncionariosToolStripMenuItem.Size = new Size(274, 22);
            entradaESaídaDeFuncionariosToolStripMenuItem.Text = "Entrada/Saída de funcionarios";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(274, 22);
            eToolStripMenuItem.Text = "Entrega de Chaves";
            // 
            // txtcnh
            // 
            txtcnh.Anchor = AnchorStyles.Left;
            txtcnh.Location = new Point(93, 309);
            txtcnh.Name = "txtcnh";
            txtcnh.Size = new Size(148, 24);
            txtcnh.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Antique Olive", 9.75F);
            label8.Location = new Point(31, 317);
            label8.Name = "label8";
            label8.Size = new Size(35, 16);
            label8.TabIndex = 5;
            label8.Text = "CNH";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 281);
            label9.Name = "label9";
            label9.Size = new Size(0, 16);
            label9.TabIndex = 17;
            // 
            // datagradeView
            // 
            datagradeView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datagradeView.AutoGenerateColumns = false;
            datagradeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagradeView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            datagradeView.BackgroundColor = Color.White;
            datagradeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagradeView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, empresaDataGridViewTextBoxColumn, setorDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, cnhDataGridViewTextBoxColumn, motoristaDataGridViewTextBoxColumn, autorizadoDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, hentradaDataGridViewTextBoxColumn, hsaidaDataGridViewTextBoxColumn });
            datagradeView.DataSource = caminhaoBindingSource;
            datagradeView.Location = new Point(14, 433);
            datagradeView.Name = "datagradeView";
            datagradeView.Size = new Size(785, 220);
            datagradeView.TabIndex = 23;
            datagradeView.CellContentDoubleClick += datagradeView_CellContentDoubleClick;
            // 
            // caminhaoBindingSource
            // 
            caminhaoBindingSource.DataSource = typeof(Models.Caminhao);
            // 
            // btneditar
            // 
            btneditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btneditar.Location = new Point(539, 659);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(91, 42);
            btneditar.TabIndex = 24;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btndeletar
            // 
            btndeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btndeletar.Location = new Point(680, 659);
            btndeletar.Name = "btndeletar";
            btndeletar.Size = new Size(90, 42);
            btndeletar.TabIndex = 25;
            btndeletar.Text = "Excluir";
            btndeletar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Antique Olive", 9.75F);
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(40, 16);
            label1.TabIndex = 11;
            label1.Text = "Data:";
            // 
            // txtplaca
            // 
            txtplaca.Anchor = AnchorStyles.Left;
            txtplaca.Location = new Point(93, 113);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(139, 24);
            txtplaca.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Antique Olive", 9.75F);
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(64, 16);
            label2.TabIndex = 1;
            label2.Text = "Empresa";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Antique Olive", 9.75F);
            label3.Location = new Point(30, 113);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 1;
            label3.Text = "Placa";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Antique Olive", 9.75F);
            label5.Location = new Point(23, 237);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 4;
            label5.Text = "Hora:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Antique Olive", 9.75F);
            label4.Location = new Point(27, 174);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 3;
            label4.Text = "Setor";
            // 
            // txtempresa
            // 
            txtempresa.Anchor = AnchorStyles.Left;
            txtempresa.Location = new Point(93, 68);
            txtempresa.Name = "txtempresa";
            txtempresa.Size = new Size(164, 24);
            txtempresa.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Antique Olive", 9.75F);
            label7.Location = new Point(243, 237);
            label7.Name = "label7";
            label7.Size = new Size(41, 16);
            label7.TabIndex = 12;
            label7.Text = "Saída";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Antique Olive", 9.75F);
            label6.Location = new Point(73, 237);
            label6.Name = "label6";
            label6.Size = new Size(59, 16);
            label6.TabIndex = 5;
            label6.Text = "Entrada";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Antique Olive", 9.75F);
            label10.Location = new Point(354, 43);
            label10.Name = "label10";
            label10.Size = new Size(72, 16);
            label10.TabIndex = 18;
            label10.Text = "Motorista";
            // 
            // maskentrada
            // 
            maskentrada.Anchor = AnchorStyles.Left;
            maskentrada.Location = new Point(142, 234);
            maskentrada.Mask = "90:00";
            maskentrada.Name = "maskentrada";
            maskentrada.Size = new Size(82, 24);
            maskentrada.TabIndex = 5;
            maskentrada.ValidatingType = typeof(DateTime);
            // 
            // txtmotorista
            // 
            txtmotorista.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtmotorista.Location = new Point(446, 34);
            txtmotorista.Name = "txtmotorista";
            txtmotorista.Size = new Size(174, 24);
            txtmotorista.TabIndex = 8;
            // 
            // masksaida
            // 
            masksaida.Anchor = AnchorStyles.Left;
            masksaida.Location = new Point(289, 234);
            masksaida.Mask = "90:00";
            masksaida.Name = "masksaida";
            masksaida.Size = new Size(82, 24);
            masksaida.TabIndex = 6;
            masksaida.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Antique Olive", 9.75F);
            label11.Location = new Point(346, 86);
            label11.Name = "label11";
            label11.Size = new Size(82, 16);
            label11.TabIndex = 20;
            label11.Text = "Autorizado";
            // 
            // maskData
            // 
            maskData.Anchor = AnchorStyles.Left;
            maskData.Location = new Point(93, 14);
            maskData.Mask = "00/00/0000";
            maskData.Name = "maskData";
            maskData.Size = new Size(114, 24);
            maskData.TabIndex = 1;
            maskData.ValidatingType = typeof(DateTime);
            // 
            // txtautorizado
            // 
            txtautorizado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtautorizado.Location = new Point(446, 83);
            txtautorizado.Name = "txtautorizado";
            txtautorizado.Size = new Size(174, 24);
            txtautorizado.TabIndex = 9;
            // 
            // btnenviar
            // 
            btnenviar.Anchor = AnchorStyles.Bottom;
            btnenviar.Location = new Point(299, 337);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(113, 45);
            btnenviar.TabIndex = 10;
            btnenviar.Text = "Enviar";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // cbx01
            // 
            cbx01.Anchor = AnchorStyles.Left;
            cbx01.FormattingEnabled = true;
            cbx01.Items.AddRange(new object[] { "Almoxarifado", "RH", "PESPONTO", "CALANDRA", "MONTAGEM", "TI", "EXPEDIÇÃO", "PCP" });
            cbx01.Location = new Point(93, 171);
            cbx01.Name = "cbx01";
            cbx01.Size = new Size(163, 24);
            cbx01.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthCalendar1.Location = new Point(434, 125);
            monthCalendar1.Margin = new Padding(10);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(cbx01);
            groupBox1.Controls.Add(btnenviar);
            groupBox1.Controls.Add(txtautorizado);
            groupBox1.Controls.Add(maskData);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtcnh);
            groupBox1.Controls.Add(masksaida);
            groupBox1.Controls.Add(txtmotorista);
            groupBox1.Controls.Add(maskentrada);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtempresa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtplaca);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 398);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            // 
            // setorDataGridViewTextBoxColumn
            // 
            setorDataGridViewTextBoxColumn.DataPropertyName = "setor";
            setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // cnhDataGridViewTextBoxColumn
            // 
            cnhDataGridViewTextBoxColumn.DataPropertyName = "cnh";
            cnhDataGridViewTextBoxColumn.HeaderText = "CNH";
            cnhDataGridViewTextBoxColumn.Name = "cnhDataGridViewTextBoxColumn";
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            motoristaDataGridViewTextBoxColumn.DataPropertyName = "motorista";
            motoristaDataGridViewTextBoxColumn.HeaderText = "Motorista";
            motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            // 
            // autorizadoDataGridViewTextBoxColumn
            // 
            autorizadoDataGridViewTextBoxColumn.DataPropertyName = "autorizado";
            autorizadoDataGridViewTextBoxColumn.HeaderText = "Autorizado";
            autorizadoDataGridViewTextBoxColumn.Name = "autorizadoDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // hentradaDataGridViewTextBoxColumn
            // 
            hentradaDataGridViewTextBoxColumn.DataPropertyName = "h_entrada";
            hentradaDataGridViewTextBoxColumn.HeaderText = "H_entrada";
            hentradaDataGridViewTextBoxColumn.Name = "hentradaDataGridViewTextBoxColumn";
            // 
            // hsaidaDataGridViewTextBoxColumn
            // 
            hsaidaDataGridViewTextBoxColumn.DataPropertyName = "h_saida";
            hsaidaDataGridViewTextBoxColumn.HeaderText = "H_saida";
            hsaidaDataGridViewTextBoxColumn.Name = "hsaidaDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(813, 714);
            Controls.Add(groupBox1);
            Controls.Add(btndeletar);
            Controls.Add(btneditar);
            Controls.Add(datagradeView);
            Controls.Add(label9);
            Controls.Add(menuStrip1);
            Font = new Font("Antique Olive", 9.75F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Veiculos";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagradeView).EndInit();
            ((System.ComponentModel.ISupportInitialize)caminhaoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem entradaCaminhõesToolStripMenuItem;
        private TextBox txtcnh;
        private Label label8;
        private Label label9;
        private DataGridView datagradeView;
        private Button btneditar;
        private Button btndeletar;
        private ToolStripMenuItem visualizarDadosCadastradosToolStripMenuItem;
        private ToolStripMenuItem entradaDeCaminhoesToolStripMenuItem;
        private ToolStripMenuItem veiculosEmpresaToolStripMenuItem;
        private ToolStripMenuItem entradaESaídaDeFuncionariosToolStripMenuItem;
        private Label label1;
        private TextBox txtplaca;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtempresa;
        private Label label7;
        private Label label6;
        private Label label10;
        private MaskedTextBox maskentrada;
        private TextBox txtmotorista;
        private MaskedTextBox masksaida;
        private Label label11;
        private MaskedTextBox maskData;
        private TextBox txtautorizado;
        private Button btnenviar;
        private ComboBox cbx01;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private ToolStripMenuItem veiculosDaEmpresaToolStripMenuItem;
        private ToolStripMenuItem enrraSaidaDeFuncionaroToolStripMenuItem;
        private ToolStripMenuItem entregaDeChavesToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private BindingSource caminhaoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorizadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hentradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsaidaDataGridViewTextBoxColumn;
    }
}