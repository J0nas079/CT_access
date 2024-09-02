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

namespace CT_access
{
    public partial class FormCompleto : Form
    {
        public FormCompleto()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void FormCompleto_Load(object sender, EventArgs e)
        {
            txtsearch.Enabled = true;
     
            Caminhao truck = new Caminhao();
            FluxoDAO fx = new FluxoDAO();
            DataTable dt = FluxoDAO.GetCaminhao();
            dataGridView1.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            if (txtsearch.Text!=string.Empty)
            {
                string usuario=txtsearch.Text;
                dt=FluxoDAO.Search(usuario);
            }
            else
            {
                dt = FluxoDAO.GetCaminhao();
            }
             dataGridView1.DataSource=dt;
        }
    }
}
