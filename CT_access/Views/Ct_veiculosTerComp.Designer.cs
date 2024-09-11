namespace CT_access.Views
{
    partial class Ct_veiculosTerComp
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
            dataGridView1 = new DataGridView();
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
            ctVeiculosTerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiculosTerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, empresaDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, hentradaDataGridViewTextBoxColumn, hsaidaDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, fabricaDataGridViewTextBoxColumn, autorizadoDataGridViewTextBoxColumn, cnhDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ctVeiculosTerBindingSource;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(887, 403);
            dataGridView1.TabIndex = 0;
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
            // 
            // hentradaDataGridViewTextBoxColumn
            // 
            hentradaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hentradaDataGridViewTextBoxColumn.DataPropertyName = "h_entrada";
            hentradaDataGridViewTextBoxColumn.HeaderText = "Hora Entrada";
            hentradaDataGridViewTextBoxColumn.Name = "hentradaDataGridViewTextBoxColumn";
            // 
            // hsaidaDataGridViewTextBoxColumn
            // 
            hsaidaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // ctVeiculosTerBindingSource
            // 
            ctVeiculosTerBindingSource.DataSource = typeof(Models.Ct_VeiculosTer);
            // 
            // Ct_veiculosTerComp
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(914, 480);
            Controls.Add(dataGridView1);
            Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Ct_veiculosTerComp";
            Text = "Ct_veiculosTerComp";
            Load += Ct_veiculosTerComp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctVeiculosTerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataFormatadaDataGridViewTextBoxColumn;
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