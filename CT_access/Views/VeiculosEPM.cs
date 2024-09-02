using CT_access.DataAcess;
using CT_access.Interface;
using CT_access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_access.Views
{
    public partial class VeiculosEPM : Form
    {
        public VeiculosEPM()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void VeiculosEPM_Load(object sender, EventArgs e)
        {
            CtVeiuloEmp ctVeiuloEmp = new CtVeiuloEmp();
            VeiculosEmpDAO veiculosEPM = new VeiculosEmpDAO();
            List<CtVeiuloEmp> CTCaminhao = veiculosEPM.GetVeiculos();
            dataGridView1.DataSource= CTCaminhao;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
