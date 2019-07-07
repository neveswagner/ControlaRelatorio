using Services.Dao;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaRelatorio.Forms
{
    public partial class FrmPesquisaRelatorio : Form
    {
        string StatusReq;

        ManutencaoRelatorio m = new ManutencaoRelatorio();


        DaoInclusaoManutencaoRelatorio daoManutencaoRelarotio = new DaoInclusaoManutencaoRelatorio();

        public FrmPesquisaRelatorio()
        {
            InitializeComponent();
        }

        public void PesquisaPorNumeroRequisito()
        {
            m.Requisito = pesquisaRequisitoTbx.Text;
            dataGridPesquisaPrincipal.DataSource = daoManutencaoRelarotio.PesquisarRequisito(m);
        }

        public void PesquisaGeral()
        {
            string Atendente = pesquisaAtendenteTbx.Text;
            string Requisito = pesquisaRequisitoTbx.Text;
            string Cliente = pesquisaClienteTbx.Text;

            if (EmAbertoCbx.Checked == true)
            {
                StatusReq = "N";
            }

            if (BaixadoCbx.Checked == true)
            {
                StatusReq = "S";
            }


            dataGridPesquisaPrincipal.DataSource = daoManutencaoRelarotio.PesquisarRequisitoAtendenteCliente(Atendente, Requisito, Cliente, StatusReq);

        }



        private void DataGridPendenteAtualizado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPesquisaRelatorio_Load(object sender, EventArgs e)
        {
           
        }

        private void incluirRelatorioBtn_Click(object sender, EventArgs e)
        {
            PesquisaGeral();

        }

        private void dataGridPesquisaPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        private void dataGridPesquisaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPesquisaPrincipal_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();

            FrmEditarRelatorio frmEditarRelatorio = new FrmEditarRelatorio();


            FrmBaixarReq frmbaixaereq = new FrmBaixarReq();

            FrmEscolhaGrid frmescolhagrid = new FrmEscolhaGrid();

            // editar
            m.Requisito = frmEditarRelatorio.requisitoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmEditarRelatorio.dtaInclusaoDtm.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmEditarRelatorio.clientTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmEditarRelatorio.atendenteTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmEditarRelatorio.ObservacaoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmEditarRelatorio.id_relatorioTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[5].Value.ToString());
            m.PendenteStatus = frmEditarRelatorio.validadoCbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[6].Value.ToString();
            m.RequisitoCorrecao = frmEditarRelatorio.requisitoCorrecaoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[7].Value.ToString();
            m.RequisitoAtualizacao = frmEditarRelatorio.requisitoAtualizacaoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[8].Value.ToString();
            m.ClienteAtualizado = frmEditarRelatorio.clienteAtualizadoCbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[9].Value.ToString();



            //baixar
            m.Requisito = frmbaixaereq.requisitoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmbaixaereq.dtaInclusaoDtm.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmbaixaereq.clientTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmbaixaereq.atendenteTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmbaixaereq.ObservacaoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmbaixaereq.id_relatorioTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[5].Value.ToString());

            m.RequisitoCorrecao = frmbaixaereq.requisitoCorrecaoTbx.Text = dataGridPesquisaPrincipal.CurrentRow.Cells[7].Value.ToString();


            if (m.PendenteStatus == "S")
            {
                frmescolhagrid.baixarGridBtn.Enabled = false;
                frmescolhagrid.MsgreqBaixadoLbl.Visible = true;
            }



            frmescolhagrid.ShowDialog();

            if (frmescolhagrid.ControlEdit == 0)
            {
                frmEditarRelatorio.ShowDialog();


                //AtualizaGrids();
            }

            if (frmescolhagrid.ControlEdit == 1)
            {
                frmbaixaereq.ShowDialog();

                //AtualizaGrids();
            }

        }

        private void FrmPesquisaRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

                this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (EmAbertoCbx.Checked == false)
            {
                BaixadoCbx.Checked = true;
            }
            else if (EmAbertoCbx.Checked == true)
            {
                BaixadoCbx.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (BaixadoCbx.Checked == false)
            {
                EmAbertoCbx.Checked = true;
            }
            else if (BaixadoCbx.Checked == true)
                {
                    EmAbertoCbx.Checked = false;
                }
        }

        private void pesquisaRequisitoTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.PesquisaGeral();

            }


        }

        private void pesquisaAtendenteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.PesquisaGeral();

            }

        }

        private void pesquisaClienteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.PesquisaGeral();

            }

        }
    }
}
