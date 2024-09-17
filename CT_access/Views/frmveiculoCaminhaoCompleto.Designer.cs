namespace CT_access
{
    partial class frmveiculoCaminhaoCompleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmveiculoCaminhaoCompleto));
            dataGridView1 = new DataGridView();
            caminhaoBindingSource = new BindingSource(components);
            label1 = new Label();
            txtsearch = new TextBox();
            panel1 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caminhaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, empresaDataGridViewTextBoxColumn, setorDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, cnhDataGridViewTextBoxColumn, motoristaDataGridViewTextBoxColumn, autorizadoDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, hentradaDataGridViewTextBoxColumn, hsaidaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = caminhaoBindingSource;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(3, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(910, 367);
            dataGridView1.TabIndex = 2;
            // 
            // caminhaoBindingSource
            // 
            caminhaoBindingSource.DataSource = typeof(Models.Caminhao);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Antique Olive", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar";
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.FromArgb(224, 224, 224);
            txtsearch.Location = new Point(136, 28);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Informe o nome da empresa";
            txtsearch.Size = new Size(239, 24);
            txtsearch.TabIndex = 1;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 70);
            panel1.TabIndex = 5;
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
            nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Visible = false;
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
            motoristaDataGridViewTextBoxColumn.HeaderText = "Condutor";
            motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            // 
            // autorizadoDataGridViewTextBoxColumn
            // 
            autorizadoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // FormCompleto
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(917, 480);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Antique Olive", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCompleto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Truck";
            Load += FormCompleto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)caminhaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource caminhaoBindingSource;
        private Label label1;
        private TextBox txtsearch;
        private Panel panel1;
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