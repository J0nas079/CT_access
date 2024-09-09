using CT_access.DataAcess;
using CT_access.Models;

namespace CT_access.Views
{
    public partial class V_empresa : Form
    {
        public V_empresa()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ValidandoInputs();
            ValidarDados();
            PreencherDatagrad();

        }
        private void V_empresa_Load(object sender, EventArgs e)
        {
            ConectionDb.CreateTable();
            ConectionDb.Dbconection();
            ValidarDados();
            PreencherDatagrad();
        }
        private void ValidarDados()
        {
            cbxVigilantes.DropDownStyle = cbxVigilantes.DropDownStyle;
            maskDataAtual.Text = DateTime.Now.ToString();
            maskDataAtual.Enabled = false;
        }
        //Validandao os inputs dos usuários
        private void ValidandoInputs()
        {
            CtVeiuloEmp ctVeiuloEmp = new CtVeiuloEmp();
            VeiculosEmpDAO vd = new VeiculosEmpDAO();
            PreencherDatagrad();
            try
            {
                if (!String.IsNullOrEmpty(maskDataAtual.Text))
                {
                    ctVeiuloEmp.data = Convert.ToDateTime(maskDataAtual.Text);
                }
                else
                {
                    MessageBox.Show("Informe a data de hoje!");
                    return;
                }
                if (!String.IsNullOrEmpty(txtDestino.Text))
                {
                    ctVeiuloEmp.itinerario = txtDestino.Text;
                }
                else
                {
                    MessageBox.Show("Informe o Destino");
                    return;
                }
                if (!String.IsNullOrEmpty(maskh_saida.Text))
                {
                    ctVeiuloEmp.horasaida = maskh_saida.Text;
                }
                else
                {
                    MessageBox.Show("Informe a hora da saida");
                    return;
                }
                if (!String.IsNullOrEmpty(maskh_entrada.Text))
                {
                    ctVeiuloEmp.horaentrada = maskh_entrada.Text;
                }
                else
                {
                    MessageBox.Show("Informe a hora da entrada");
                    return;
                }

                //ESSE PROCESSO PRECISA SER AUTOMATICO
                if (!String.IsNullOrEmpty(maskTotalhoras.Text))
                {
                    ctVeiuloEmp.horfinal = maskTotalhoras.Text;
                }
                else
                {
                    MessageBox.Show("HORA TOTAL");
                    return;
                }
                if (!String.IsNullOrEmpty(txtkmSaida.Text))
                {
                    ctVeiuloEmp.kmSaida = txtkmSaida.Text;
                }
                else
                {
                    MessageBox.Show("km saida invalido");
                    return;
                }

                if (!String.IsNullOrEmpty(txtkmEntrada.Text))
                {
                    ctVeiuloEmp.kmchentrada = txtkmEntrada.Text;
                }
                else
                {
                    MessageBox.Show("Infome km entrada");
                    return;
                }
                //ESSE PROCESSO PRECISA SER AUTOMATICO
                if (!String.IsNullOrEmpty(txtTotalkm.Text))
                {
                    ctVeiuloEmp.kmrodados = txtTotalkm.Text;
                }
                else
                {
                    MessageBox.Show("Total KM ERRADO");
                    return;
                }
                if (!string.IsNullOrEmpty(txtCondutor.Text))
                {
                    ctVeiuloEmp.motorista = txtCondutor.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar o motorista");
                    return;
                }
                if (!String.IsNullOrEmpty(txtMatricula.Text))
                {
                    ctVeiuloEmp.Matricula = txtMatricula.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar matricula");
                    return;
                }
                if (!String.IsNullOrEmpty(cbxVigilantes.Text))
                {
                    ctVeiuloEmp.Vigilante = cbxVigilantes.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar o vigilante");
                    return;
                }
                if (!String.IsNullOrEmpty(txtObs.Text))
                {
                    ctVeiuloEmp.Observacoes = txtObs.Text;
                }
                else
                {
                    MessageBox.Show("Informe se existe alguma observação");
                    return;
                }
                vd.SetVeiculos(ctVeiuloEmp);
                ClearInput();
                MessageBox.Show("Dados inseridos com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados no banco de dados", ex.Message);
            }

        }
        private void PreencherDatagrad()
        {

            VeiculosEmpDAO veiculosEmpDAO = new VeiculosEmpDAO();
            List<CtVeiuloEmp> ctVeiuloEmps = new List<CtVeiuloEmp>();
            dataGridView1.DataSource = veiculosEmpDAO.GetVeiculos();
        }
        private void ClearInput()
        {
            txtCondutor.Clear();
            txtDestino.Clear();
            txtkmEntrada.Clear();
            txtkmEntrada.Clear();
            txtkmSaida.Clear();
            txtMatricula.Clear();
            txtObs.Clear();
            txtTotalkm.Clear();
            cbxVigilantes.SelectedIndex = -1;
            maskDataRetorno.Clear();
            maskh_entrada.Clear();
            maskh_saida.Clear();
            maskTotalhoras.Clear();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CtVeiuloEmp ctVeiuloEmp = new CtVeiuloEmp();
            VeiculosEmpDAO veiculosEmp = new VeiculosEmpDAO();


            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                string id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                string dataentrada = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string h_entrada = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string kmEntrada = dataGridView1.CurrentRow.Cells[7].Value.ToString();  
                updateData upData = new updateData(h_entrada,kmEntrada,id, dataentrada);
                upData.ShowDialog();

            }
            else
            {
                MessageBox.Show("Linha Vazia");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)    
        {
              PreencherDatagrad();
        }
    }
}
