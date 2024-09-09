namespace CT_access.Views
{
    partial class VeiculosEPM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtsearch = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idVeiuloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            observacoesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vigilanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itinerarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasaidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaentradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horfinalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kmSaidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kmchentradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kmrodadosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motoristaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matriculaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ctVeiuloEmpBindingSource = new BindingSource(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiuloEmpBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.Location = new Point(115, 19);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Informe o nome do Motorista";
            txtsearch.Size = new Size(210, 23);
            txtsearch.TabIndex = 4;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Antique Olive", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idVeiuloDataGridViewTextBoxColumn, observacoesDataGridViewTextBoxColumn, vigilanteDataGridViewTextBoxColumn, itinerarioDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, horasaidaDataGridViewTextBoxColumn, horaentradaDataGridViewTextBoxColumn, horfinalDataGridViewTextBoxColumn, kmSaidaDataGridViewTextBoxColumn, kmchentradaDataGridViewTextBoxColumn, kmrodadosDataGridViewTextBoxColumn, motoristaDataGridViewTextBoxColumn, matriculaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ctVeiuloEmpBindingSource;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(3, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(796, 378);
            dataGridView1.TabIndex = 5;
            // 
            // idVeiuloDataGridViewTextBoxColumn
            // 
            idVeiuloDataGridViewTextBoxColumn.DataPropertyName = "idVeiulo";
            idVeiuloDataGridViewTextBoxColumn.HeaderText = "idVeiulo";
            idVeiuloDataGridViewTextBoxColumn.Name = "idVeiuloDataGridViewTextBoxColumn";
            idVeiuloDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            observacoesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // vigilanteDataGridViewTextBoxColumn
            // 
            vigilanteDataGridViewTextBoxColumn.DataPropertyName = "Vigilante";
            vigilanteDataGridViewTextBoxColumn.HeaderText = "Vigilante";
            vigilanteDataGridViewTextBoxColumn.Name = "vigilanteDataGridViewTextBoxColumn";
            // 
            // itinerarioDataGridViewTextBoxColumn
            // 
            itinerarioDataGridViewTextBoxColumn.DataPropertyName = "itinerario";
            itinerarioDataGridViewTextBoxColumn.HeaderText = "Itinerario";
            itinerarioDataGridViewTextBoxColumn.Name = "itinerarioDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // horasaidaDataGridViewTextBoxColumn
            // 
            horasaidaDataGridViewTextBoxColumn.DataPropertyName = "horasaida";
            horasaidaDataGridViewTextBoxColumn.HeaderText = "Hora/Saida";
            horasaidaDataGridViewTextBoxColumn.Name = "horasaidaDataGridViewTextBoxColumn";
            // 
            // horaentradaDataGridViewTextBoxColumn
            // 
            horaentradaDataGridViewTextBoxColumn.DataPropertyName = "horaentrada";
            horaentradaDataGridViewTextBoxColumn.HeaderText = "Hora/Entrada";
            horaentradaDataGridViewTextBoxColumn.Name = "horaentradaDataGridViewTextBoxColumn";
            // 
            // horfinalDataGridViewTextBoxColumn
            // 
            horfinalDataGridViewTextBoxColumn.DataPropertyName = "horfinal";
            horfinalDataGridViewTextBoxColumn.HeaderText = "Hora/Final";
            horfinalDataGridViewTextBoxColumn.Name = "horfinalDataGridViewTextBoxColumn";
            // 
            // kmSaidaDataGridViewTextBoxColumn
            // 
            kmSaidaDataGridViewTextBoxColumn.DataPropertyName = "kmSaida";
            kmSaidaDataGridViewTextBoxColumn.HeaderText = "km/Saida";
            kmSaidaDataGridViewTextBoxColumn.Name = "kmSaidaDataGridViewTextBoxColumn";
            // 
            // kmchentradaDataGridViewTextBoxColumn
            // 
            kmchentradaDataGridViewTextBoxColumn.DataPropertyName = "kmchentrada";
            kmchentradaDataGridViewTextBoxColumn.HeaderText = "km/Entrada";
            kmchentradaDataGridViewTextBoxColumn.Name = "kmchentradaDataGridViewTextBoxColumn";
            // 
            // kmrodadosDataGridViewTextBoxColumn
            // 
            kmrodadosDataGridViewTextBoxColumn.DataPropertyName = "kmrodados";
            kmrodadosDataGridViewTextBoxColumn.HeaderText = "km/Rodados";
            kmrodadosDataGridViewTextBoxColumn.Name = "kmrodadosDataGridViewTextBoxColumn";
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            motoristaDataGridViewTextBoxColumn.DataPropertyName = "motorista";
            motoristaDataGridViewTextBoxColumn.HeaderText = "Motorista";
            motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // ctVeiuloEmpBindingSource
            // 
            ctVeiuloEmpBindingSource.DataSource = typeof(Models.CtVeiuloEmp);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtsearch);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 66);
            panel1.TabIndex = 6;
            // 
            // VeiculosEPM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(802, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "VeiculosEPM";
            Text = "VeiculosEPM";
            Load += VeiculosEPM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiuloEmpBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtsearch;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource ctVeiuloEmpBindingSource;
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
        private Panel panel1;
    }
}