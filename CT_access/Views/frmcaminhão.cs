﻿using CT_access.DataAcess;
using CT_access.Models;
using CT_access.Views;
using System.Data;

namespace CT_access

{
    public partial class frmcaminhão : Form
    {
        public frmcaminhão()
        {
            InitializeComponent();
            masksaida.Enabled = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtempresa.Focus();
            cbx01.DropDownStyle = ComboBoxStyle.DropDownList;
            lblData.Text = DateTime.Today.ToString("dd-MM-yyyy");

            frmlogin form1 = new frmlogin(); // se quiser uma form de login ou uma que seja antes, cria ela no load
            form1.ShowDialog(); // depois abre como dialog
            if (form1.DialogResult == DialogResult.OK) // se o result dessa form for OK, continua pra main
            {
                WindowState = FormWindowState.Maximized;
                ConectionDb.Dbconection();
                ConectionDb.CreateTable();
                LimparCampos();
                AtualizarDatagrade();
            }
            else //  se não for, fecha tudo
            {
                Environment.Exit(Environment.ExitCode);
            }

        }
        private void LimparCampos()
        {
            maskentrada.Clear();
            masksaida.Clear();
            cbx01.SelectedIndex = -1;
            txtautorizado.Clear();
            txtcnh.Clear();
            txtempresa.Clear();
            txtmotorista.Clear();
            txtplaca.Clear();
        }

        public void AtualizarDatagrade()
        {
            FluxoDAO fx = new FluxoDAO();
            DataTable dt = new DataTable();
            List<Caminhao> caminhaos = fx.ObterCaminhao();
            datagradeView.DataSource = caminhaos;
        }
        private void btnenviar_Click(object sender, EventArgs e)
        {
            Caminhao caminhao = new Caminhao();
            FluxoDAO fluxo = new FluxoDAO();

            try
            {
                // Validação de campos obrigatórias
                if (String.IsNullOrWhiteSpace(txtempresa.Text))
                {
                    MessageBox.Show("Favor preencher o campo Empresa.");
                    return;
                }
                else
                {
                    caminhao.empresa = txtempresa.Text;
                }

                if (String.IsNullOrWhiteSpace(txtplaca.Text))
                {
                    MessageBox.Show("Favor informar o campo Placa.");
                    return;
                }
                else
                {
                    caminhao.placa = txtplaca.Text;
                }

                if (string.IsNullOrEmpty(cbx01.Text))
                {
                    MessageBox.Show("Você precisa informar o campo Setor.");
                    return;
                }
                else
                {
                    caminhao.setor = cbx01.Text;
                }

                if (String.IsNullOrEmpty(maskentrada.Text) || String.IsNullOrEmpty(masksaida.Text))
                {
                    MessageBox.Show("Favor informar uma hora válida para entrada e saída.");
                    return;
                }
                else
                {
                    caminhao.h_entrada = maskentrada.Text;
                    caminhao.h_saida = masksaida.Text;
                }

                if (String.IsNullOrWhiteSpace(txtcnh.Text))
                {
                    MessageBox.Show("Favor informar a CNH do motorista.");
                    return;
                }
                else
                {
                    caminhao.cnh = txtcnh.Text;
                }

                if (String.IsNullOrWhiteSpace(txtmotorista.Text))
                {
                    MessageBox.Show("Favor informar o nome do motorista.");
                    return;
                }
                else
                {
                    caminhao.motorista = txtmotorista.Text;
                }
                DateTime parsedDate;
                string format = "dd-MM-yyyy"; // Defina o formato esperado

                if (DateTime.TryParseExact(lblData.Text, format, null, System.Globalization.DateTimeStyles.None, out parsedDate))
                {
                    caminhao.data = parsedDate.Date;
                }
                else
                {
                    MessageBox.Show("Formato de data inválido. Use o formato " + format);
                }
                if (!String.IsNullOrEmpty(txtautorizado.Text))
                {
                    caminhao.autorizado = txtautorizado.Text;
                }
                else
                {
                    MessageBox.Show("Favor informar o setor autorizado");
                    return;

                }
                // Inserção no banco de dados
                fluxo.AdcionarCaminhao(caminhao);
                MessageBox.Show("Dados Inseridos com suceso" + MessageBoxButtons.OK);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao inserir dados no banco de Dados" + ex);
            }
            AtualizarDatagrade();
        }

        private void entradaDeCaminhoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmveiculoCaminhaoCompleto formCompleto = new frmveiculoCaminhaoCompleto();

            formCompleto.Show();
        }
        private void veiculosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmveiculoEmpresa v_Empresa = new frmveiculoEmpresa();
            v_Empresa.Show();
        }
        private void veiculosEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmveiculosEmpresaCompleto veiculos = new frmveiculosEmpresaCompleto();
            veiculos.Show();
        }

        private void datagradeView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                VeiculosEmpDAO vei = new VeiculosEmpDAO();
                masksaida.Text = datagradeView.CurrentRow.Cells[6].Value.ToString();
                Bloquearcampos();
            }
        }
        private void Bloquearcampos()
        {
            masksaida.Enabled = true;
            txtautorizado.Enabled = false;
            txtcnh.Enabled = false;
            txtempresa.Enabled = false;
            maskentrada.Enabled = false;
            txtplaca.Enabled = false;
            txtmotorista.Enabled = false;
            cbx01.Enabled = false;
            btnenviar.Enabled = false;
            btndeletar.Enabled = false;

        }

        private void DesbloquerCampos()
        {
            masksaida.Enabled = true;
            txtautorizado.Enabled = true;
            masksaida.Clear();
            txtcnh.Enabled = true;
            txtempresa.Enabled = true;
            maskentrada.Enabled = true;
            txtplaca.Enabled = true;
            txtmotorista.Enabled = true;
            cbx01.Enabled = true;
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (masksaida.Text == String.Empty)
                {
                    MessageBox.Show("Favor infomar a Hora da Saída");
                    return;
                }
                else
                {
                    Caminhao caminhao = new Caminhao();
                    FluxoDAO fx = new FluxoDAO();
                    caminhao.h_saida = masksaida.Text;
                    string id = Convert.ToString(datagradeView.CurrentRow.Cells[0].Value);
                    caminhao.id = Convert.ToInt32(id);
                    fx.AtualizarCaminhao(caminhao);
                    MessageBox.Show("Dados atualizados");
                    AtualizarDatagrade();
                    DesbloquerCampos();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void enrraSaidaDeFuncionaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmveiculosterceiro ctVeiculosTerceiro = new frmveiculosterceiro();
            ctVeiculosTerceiro.Show();
        }

        private void entradaESaídaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmveiculorTerceiroCompleto veiculosTercerio=new frmveiculorTerceiroCompleto();
            veiculosTercerio.Show();
        }
    }
}
