using CT_access.DataAcess;
using CT_access.Models;

namespace CT_access.Views
{
    public partial class frmveiculosterceiro : Form
    {
        Ct_veiculosTercDAO veiculosdao = new Ct_veiculosTercDAO();
        Ct_VeiculosTer ct_veiculos = new Ct_VeiculosTer();
        public frmveiculosterceiro()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            ListarTabela();
        }

        private void ValidarCampos()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtempresa.Text))
                {
                    ct_veiculos.empresa = txtempresa.Text;
                    ct_veiculos.data = Convert.ToDateTime(maskdata.Text).Date;
                    MessageBox.Show(ct_veiculos.data.ToString());
                }
                else
                {
                    MessageBox.Show("Favor informar o campo Empresa");
                    return;
                }
                if (!String.IsNullOrEmpty(txtempresa.Text))
                {
                    ct_veiculos.h_entrada = maskh_entrada.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar a Hora da entrada");
                    return;
                }
                if (!string.IsNullOrEmpty(txtmotorista.Text))
                {
                    ct_veiculos.nome = txtmotorista.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar o motorista");
                    return;
                }
                if (!String.IsNullOrEmpty(txtplaca.Text))
                {
                    ct_veiculos.placa = txtplaca.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar a Placa");
                    return;
                }
                if (!String.IsNullOrEmpty(txtfabrica.Text))
                {
                    ct_veiculos.fabrica = txtfabrica.Text;
                }
                else
                {
                    MessageBox.Show("Favor preencher Fabrica");
                    return;
                }
                if (!String.IsNullOrEmpty(txtautorizado.Text))
                {
                    ct_veiculos.autorizado = txtautorizado.Text;
                }
                else
                {
                    MessageBox.Show("Favor preencher Autorizado");
                    return;
                }
                if (!String.IsNullOrEmpty(txtcnh.Text))
                {
                    ct_veiculos.cnh = txtcnh.Text;
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CNH");
                    return;
                }
                veiculosdao.SetvTerceiro(ct_veiculos);
                MessageBox.Show("DADOS INSERIDOS COM SUCESSO!");
                Limparcampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO INSERIR DADOS NO DB" + ex.Message);
            }
        }

        private void Limparcampos()
        {
            txtempresa.Clear();
            txtautorizado.Clear();
            txtcnh.Clear();
            txtfabrica.Clear();
            txtplaca.Clear();
            maskh_saida.Clear();
            txtmotorista.Clear();
            maskh_entrada.Clear();

        }
        private void ListarTabela()
        {
            // Obtém a lista de veículos
            List<Ct_VeiculosTer> ctVeiculos = veiculosdao.GetCtVeiculosTerceis();
            dataGridView1.DataSource = ctVeiculos;
        }
        private void CtVeiculosTerceiro_Load(object sender, EventArgs e)
        {
            ListarTabela();
            txtempresa.Focus();
            maskdata.Enabled = false;
            maskdata.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }
    }
}
