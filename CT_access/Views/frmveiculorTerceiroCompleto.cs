using CT_access.DataAcess;
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
    public partial class frmveiculorTerceiroCompleto : Form
    {
        public frmveiculorTerceiroCompleto()
        {
            InitializeComponent();
        }

        private void Ct_veiculosTerComp_Load(object sender, EventArgs e)
        {
            Ct_veiculosTercDAO veicuoloDao= new Ct_veiculosTercDAO();
            List<Ct_VeiculosTer> ctvei=veicuoloDao.GetCtVeiculosTerceis();
            dataGridView1.DataSource = ctvei;
        }
    }
}
