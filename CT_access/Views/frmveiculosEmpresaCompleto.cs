using CT_access.DataAcess;
using CT_access.Models;
using System.Data;

namespace CT_access.Views
{
    public partial class frmveiculosEmpresaCompleto : Form
    {
        public frmveiculosEmpresaCompleto()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void VeiculosEPM_Load(object sender, EventArgs e)
        {
            CtVeiuloEmp ctVeiuloEmp = new CtVeiuloEmp();
            VeiculosEmpDAO veiculosEPM = new VeiculosEmpDAO();
            List<CtVeiuloEmp> CTCaminhao = veiculosEPM.GetVeiculos();
            dataGridView1.DataSource = CTCaminhao;
            txtsearch.Focus();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            VeiculosEmpDAO ctveiculos = new VeiculosEmpDAO();
            List<CtVeiuloEmp> veiculos = new List<CtVeiuloEmp>();

            // Verificar se há texto para pesquisa
            if (txtsearch.Text != string.Empty)
            {
                string motorista = txtsearch.Text;
                // Obter a lista filtrada de acordo com o motorista e atribuir o retorno à variável
                veiculos = VeiculosEmpDAO.SearchCaminhao(motorista);
            }
            else
            {
                // Obter todos os veículos quando não há pesquisa
                veiculos = ctveiculos.GetVeiculos();
            }

            // Definir a lista como fonte de dados para o DataGridView
            dataGridView1.DataSource = veiculos;
        }

    }
}
