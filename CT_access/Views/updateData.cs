using CT_access.DataAcess;
using CT_access.Models;

namespace CT_access.Views
{
    //PASSANDO OS DADOS PARA A TELA DE ATUALIZAÇÃO 
    public partial class updateData : Form
    {
        public updateData(string kmEntrada, string h_entrada)
        {
            InitializeComponent();

            //maskHREntrada.Text = h_entrada;
            txtKMentra.Text = kmEntrada;
            maskHREntrada.Text = h_entrada;
            //maskdataEntrada.Text = Convert.ToDateTime(kmEntrada).ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            VeiculosEmpDAO veiculos = new VeiculosEmpDAO();
            CtVeiuloEmp ctVeiuloEmp = new CtVeiuloEmp();
            try
            {
                ctVeiuloEmp.horaentrada = maskHREntrada.Text;
                ctVeiuloEmp.kmchentrada = txtKMentra.Text;
                //ctVeiuloEmp.Date_entrada = Convert.ToDateTime(maskdataEntrada.Text);
                veiculos.updateDados(ctVeiuloEmp);
                lblok.Text = "Dados Atualizado!!";
            }
            catch (Exception ex)
            {
                lblok.ForeColor=Color.Red;
                lblok.Text="Erro ao atualizar dados"+ex.Message;
            }

        }

        private void updateData_Load(object sender, EventArgs e)
        {
            maskdataEntrada.Focus();
        }
    }
}
