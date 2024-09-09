using CT_access.DataAcess;
using CT_access.Models;
using System.Data.Entity.Infrastructure;

namespace CT_access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConectionDb.CurrentDBDiretory();
            ConectionDb.Dbconection();
            ConectionDb.CreateTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            
        }
        private void btm01_Click(object sender, EventArgs e)
        {          
            string txtuser=textBox1.Text;
            string txtpwd=textBox2.Text;

            Usuario usuario = new Usuario
            {
                usuario = txtuser,
                senha = txtpwd
            };
            FluxoDAO fx = new FluxoDAO();
            fx.Validaruser(usuario);
            bool DadosValidados=fx.Validaruser(usuario);
            
            if (DadosValidados)
            {
                //frm.Hide();
                
                this.DialogResult = DialogResult.OK; // retorna pra main form que o resultado foi ok
                
            }

            else
            {
                labelSenha.Text = "Usuário ou senha incorreto!";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            } //se tivesse um botão 'cancelar' retornava tipo um 
            // this.DialogResult = DialogResult.Cancel;
            // e ai fechava pelo main quando fosse = cancel;
          
        }
    }
}
