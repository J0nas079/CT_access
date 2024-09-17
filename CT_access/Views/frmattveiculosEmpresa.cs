using CT_access.DataAcess;
using CT_access.Models;

namespace CT_access.Views
{
    //PASSANDO OS DADOS PARA A TELA DE ATUALIZAÇÃO 
    public partial class frmattveiculosEmpresa : Form
    {
        public frmattveiculosEmpresa(string h_entrada,string kmEntrada,string id,string dataAtual)
        {
            InitializeComponent();
            txtKMentra.Text = kmEntrada;
            maskHREntrada.Text = h_entrada;
            txtid.Text = id;
            maskdata.Text = dataAtual;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            VeiculosEmpDAO veiculos = new VeiculosEmpDAO();
            CtVeiuloEmp ctVeiuloEmp = new CtVeiuloEmp();
            try
            {
                ctVeiuloEmp.horaentrada = maskHREntrada.Text;
                ctVeiuloEmp.kmchentrada = txtKMentra.Text;
                ctVeiuloEmp.idVeiulo =Convert.ToInt32(txtid.Text);
                veiculos.updateDados(ctVeiuloEmp);
                lblATT.ForeColor=Color.Red;
                lblATT.Text = "Dados Atualizados";
                maskHREntrada.Clear();
                txtKMentra.Clear();
                
            }
            catch (Exception ex)
            {
                lblATT.ForeColor= Color.Red;
                lblATT.Text = "Erro ao atualizar";
            }
        }

        private void updateData_Load(object sender, EventArgs e)
        {
            txtid.Enabled=false;
            txtid.Focus();
        }
    }
}
