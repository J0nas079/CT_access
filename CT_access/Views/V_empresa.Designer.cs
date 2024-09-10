namespace CT_access.Views
{
    partial class V_empresa
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
            label2 = new Label();
            maskDataAtual = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDestino = new TextBox();
            maskh_saida = new MaskedTextBox();
            maskh_entrada = new MaskedTextBox();
            maskDataRetorno = new MaskedTextBox();
            txtkmSaida = new TextBox();
            txtkmEntrada = new TextBox();
            txtTotalkm = new TextBox();
            label9 = new Label();
            maskTotalhoras = new MaskedTextBox();
            txtCondutor = new TextBox();
            label10 = new Label();
            txtMatricula = new TextBox();
            label11 = new Label();
            cbxVigilantes = new ComboBox();
            label12 = new Label();
            btnEditar = new Button();
            btnEnviar = new Button();
            label13 = new Label();
            txtObs = new TextBox();
            dataGridView1 = new DataGridView();
            ctVeiuloEmpBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dateentradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiuloEmpBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Antique Olive", 9F);
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Data/Saida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Antique Olive", 9F);
            label2.Location = new Point(59, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Destino";
            // 
            // maskDataAtual
            // 
            maskDataAtual.Location = new Point(119, 12);
            maskDataAtual.Mask = "00/00/0000";
            maskDataAtual.Name = "maskDataAtual";
            maskDataAtual.Size = new Size(100, 23);
            maskDataAtual.TabIndex = 1;
            maskDataAtual.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Antique Olive", 9F);
            label3.Location = new Point(42, 98);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Hora/Saida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Antique Olive", 9F);
            label4.Location = new Point(30, 135);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "Hora/Entrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Antique Olive", 9F);
            label5.Location = new Point(29, 199);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 5;
            label5.Text = "Data/Retorno";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Antique Olive", 9F);
            label6.Location = new Point(48, 236);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 6;
            label6.Text = "Km/Saida";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Antique Olive", 9F);
            label7.Location = new Point(537, 15);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 7;
            label7.Text = "Km/Entrada";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Antique Olive", 9F);
            label8.Location = new Point(554, 58);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 8;
            label8.Text = "Total KM";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(120, 55);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(237, 23);
            txtDestino.TabIndex = 2;
            // 
            // maskh_saida
            // 
            maskh_saida.Location = new Point(119, 95);
            maskh_saida.Mask = "00:00";
            maskh_saida.Name = "maskh_saida";
            maskh_saida.Size = new Size(100, 23);
            maskh_saida.TabIndex = 3;
            maskh_saida.ValidatingType = typeof(DateTime);
            // 
            // maskh_entrada
            // 
            maskh_entrada.Location = new Point(119, 132);
            maskh_entrada.Mask = "90:00";
            maskh_entrada.Name = "maskh_entrada";
            maskh_entrada.Size = new Size(100, 23);
            maskh_entrada.TabIndex = 4;
            maskh_entrada.ValidatingType = typeof(DateTime);
            // 
            // maskDataRetorno
            // 
            maskDataRetorno.Location = new Point(119, 196);
            maskDataRetorno.Mask = "00/00/0000";
            maskDataRetorno.Name = "maskDataRetorno";
            maskDataRetorno.Size = new Size(100, 23);
            maskDataRetorno.TabIndex = 6;
            maskDataRetorno.ValidatingType = typeof(DateTime);
            // 
            // txtkmSaida
            // 
            txtkmSaida.Location = new Point(119, 233);
            txtkmSaida.Name = "txtkmSaida";
            txtkmSaida.Size = new Size(100, 23);
            txtkmSaida.TabIndex = 7;
            // 
            // txtkmEntrada
            // 
            txtkmEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtkmEntrada.Location = new Point(636, 13);
            txtkmEntrada.Name = "txtkmEntrada";
            txtkmEntrada.Size = new Size(100, 23);
            txtkmEntrada.TabIndex = 8;
            // 
            // txtTotalkm
            // 
            txtTotalkm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalkm.Location = new Point(636, 50);
            txtTotalkm.Name = "txtTotalkm";
            txtTotalkm.Size = new Size(100, 23);
            txtTotalkm.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Antique Olive", 9F);
            label9.Location = new Point(38, 167);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 16;
            label9.Text = "Total/Horas";
            // 
            // maskTotalhoras
            // 
            maskTotalhoras.Location = new Point(119, 164);
            maskTotalhoras.Mask = "90:00";
            maskTotalhoras.Name = "maskTotalhoras";
            maskTotalhoras.Size = new Size(100, 23);
            maskTotalhoras.TabIndex = 5;
            maskTotalhoras.ValidatingType = typeof(DateTime);
            // 
            // txtCondutor
            // 
            txtCondutor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCondutor.Location = new Point(636, 90);
            txtCondutor.Name = "txtCondutor";
            txtCondutor.Size = new Size(100, 23);
            txtCondutor.TabIndex = 10;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Antique Olive", 9F);
            label10.Location = new Point(549, 98);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 19;
            label10.Text = "Condutor";
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatricula.Location = new Point(636, 127);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Antique Olive", 9F);
            label11.Location = new Point(550, 135);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 21;
            label11.Text = "Matricula";
            // 
            // cbxVigilantes
            // 
            cbxVigilantes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxVigilantes.FormattingEnabled = true;
            cbxVigilantes.Items.AddRange(new object[] { "Elias", "Diego" });
            cbxVigilantes.Location = new Point(636, 159);
            cbxVigilantes.Name = "cbxVigilantes";
            cbxVigilantes.Size = new Size(121, 23);
            cbxVigilantes.TabIndex = 12;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Antique Olive", 9F);
            label12.Location = new Point(554, 167);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 23;
            label12.Text = "Vigilante";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(635, 461);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 37);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnviar.Font = new Font("Antique Olive", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(725, 461);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(86, 37);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Antique Olive", 9F);
            label13.Location = new Point(528, 211);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 24;
            label13.Text = "Observações";
            // 
            // txtObs
            // 
            txtObs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtObs.Location = new Point(636, 203);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(202, 23);
            txtObs.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dateentradaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ctVeiuloEmpBindingSource;
            dataGridView1.Location = new Point(31, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 167);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // ctVeiuloEmpBindingSource
            // 
            ctVeiuloEmpBindingSource.DataSource = typeof(Models.CtVeiuloEmp);
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "idVeiulo";
            dataGridViewTextBoxColumn2.HeaderText = "idVeiulo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Vigilante";
            dataGridViewTextBoxColumn3.HeaderText = "Vigilante";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "itinerario";
            dataGridViewTextBoxColumn4.HeaderText = "itinerario";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "data";
            dataGridViewTextBoxColumn5.HeaderText = "Data";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "horasaida";
            dataGridViewTextBoxColumn6.HeaderText = "Hora/saida";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "horaentrada";
            dataGridViewTextBoxColumn7.HeaderText = "Hora/Entrada";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "horfinal";
            dataGridViewTextBoxColumn8.HeaderText = "Hora/Final";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "kmSaida";
            dataGridViewTextBoxColumn9.HeaderText = "Km/Saida";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "kmchentrada";
            dataGridViewTextBoxColumn10.HeaderText = "km/Retorno";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "kmrodados";
            dataGridViewTextBoxColumn11.HeaderText = "Km/Rodados";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "motorista";
            dataGridViewTextBoxColumn12.HeaderText = "Motorista";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Matricula";
            dataGridViewTextBoxColumn13.HeaderText = "Matricula";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "Observacoes";
            dataGridViewTextBoxColumn14.HeaderText = "Observacoes";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dateentradaDataGridViewTextBoxColumn
            // 
            dateentradaDataGridViewTextBoxColumn.DataPropertyName = "Date_entrada";
            dateentradaDataGridViewTextBoxColumn.HeaderText = "Date_entrada";
            dateentradaDataGridViewTextBoxColumn.Name = "dateentradaDataGridViewTextBoxColumn";
            dateentradaDataGridViewTextBoxColumn.Visible = false;
            // 
            // V_empresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(850, 503);
            Controls.Add(label13);
            Controls.Add(txtObs);
            Controls.Add(btnEnviar);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditar);
            Controls.Add(label12);
            Controls.Add(cbxVigilantes);
            Controls.Add(label11);
            Controls.Add(txtMatricula);
            Controls.Add(label10);
            Controls.Add(txtCondutor);
            Controls.Add(maskTotalhoras);
            Controls.Add(label9);
            Controls.Add(txtTotalkm);
            Controls.Add(txtkmEntrada);
            Controls.Add(txtkmSaida);
            Controls.Add(maskDataRetorno);
            Controls.Add(maskh_entrada);
            Controls.Add(maskh_saida);
            Controls.Add(txtDestino);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskDataAtual);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Antique Olive", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "V_empresa";
            Text = "V_empresa";
            Load += V_empresa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiuloEmpBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskDataAtual;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDestino;
        private MaskedTextBox maskh_saida;
        private MaskedTextBox maskh_entrada;
        private MaskedTextBox maskDataRetorno;
        private TextBox txtkmSaida;
        private TextBox txtkmEntrada;
        private TextBox txtTotalkm;
        private Label label9;
        private MaskedTextBox maskTotalhoras;
        private TextBox txtCondutor;
        private Label label10;
        private TextBox txtMatricula;
        private Label label11;
        private ComboBox cbxVigilantes;
        private Label label12;
        private Button btnEditar;
        private DataGridViewTextBoxColumn abastecimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaFiscalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnEnviar;
        private Label label13;
        private TextBox txtObs;
        private DataGridViewTextBoxColumn idVeiuloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vigilanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itinerarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasaidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaentradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horfinalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kmSaidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kmchentradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kmrodadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private BindingSource ctVeiuloEmpBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dateentradaDataGridViewTextBoxColumn;
    }
}