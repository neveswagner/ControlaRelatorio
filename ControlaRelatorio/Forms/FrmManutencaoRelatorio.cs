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
    public partial class FrmManutencaoRelatorio : Form
    {
        ManutencaoRelatorio m = new ManutencaoRelatorio();

        Previsao p = new Previsao();

        DaoPrevisao daoprevisao = new DaoPrevisao();

        DaoInclusaoManutencaoRelatorio daoManutencaoRelarotio = new DaoInclusaoManutencaoRelatorio();

        FrmIncluirRelatorio frmIRel = (FrmIncluirRelatorio)Application.OpenForms["FrmIncluirRelatorio"];

        FrmEscolhaGrid grid = (FrmEscolhaGrid)Application.OpenForms["FrmEscolhaGrid"];

        public bool MenuSize = true;

        public bool ModoRelatorio = true;

        public bool ModoPrevisao = false;

        public String TextoVersaoRelatorio = "Controle de Relatorio  -  Versao Mark III";
        public String TextoVersaoPrevisao = "Controle de Previsao  -  Versao Mark III";

        public FrmManutencaoRelatorio()
        {
            InitializeComponent();
            ModoExibicaoRelatorioMenuFechado();
            DiasCountAtendenteTbx.Text = "3";
            DiasCount();
            this.PesquisaNumRequisitoTelaPrincipalTbx.Focus();
            exibirRelatorioBtn.Visible = false;
            exibirRelatorioTxtBtn.Visible = false;

        }


        public void DesabilitaComponentesRelatorio()
        {
            dataGridPendenteAtualizado.Visible = false;
            AtualizadosPendenteValidacaoLbl.Visible = false;
            dataGridPendenteNaoAtualizado.Visible = false;
            dataGridPendenteTempo.Visible = false;
            DiasCountAtendenteTbx.Visible = false;
            QuantidadeAtendenteLbl.Visible = false;
            PendenteAtualizacaoLbl.Visible = false;
            dataGridCountAtendente.Visible = false;
            AtendenteLbl.Visible = false;

        }

        public void ModoExibicaoPrevisaoMenuFechado()
        {
            dataGridPrevisaoAbertoProgramacao.Visible = true;
            abertoNaProgramacaoLbl.Visible = true;

            dataGridPrevisaoAbertoProgramacao.Location = new Point(70, 56);
            abertoNaProgramacaoLbl.Location = new Point(76, 22);

            ePnl.Visible = false;
            MenuSize = true;

            


        }


        public void ModoExibicaoPrevisaoMenuAberto()
        {
            dataGridPrevisaoAbertoProgramacao.Visible = true;
            abertoNaProgramacaoLbl.Visible = true;

            dataGridPrevisaoAbertoProgramacao.Location = new Point(260, 56);
            abertoNaProgramacaoLbl.Location = new Point(260, 22);


            DesabilitaComponentesRelatorio();

            ePnl.Visible = true;
            MenuSize = false;
        }





        public void ModoExibicaoRelatorioMenuFechado()
        {
            dataGridPrevisaoAbertoProgramacao.Visible = false;
            abertoNaProgramacaoLbl.Visible = false;


            dataGridPendenteAtualizado.Visible = true;
            AtualizadosPendenteValidacaoLbl.Visible = true;
            AtendenteLbl.Visible = true;
            DiasCountAtendenteTbx.Visible = true;
            dataGridPendenteTempo.Visible = true;
            dataGridPendenteNaoAtualizado.Visible = true;
            PendenteAtualizacaoLbl.Visible = true;

            ePnl.Visible = false;
            dataGridPendenteAtualizado.Location = new Point(70, 56);
            AtualizadosPendenteValidacaoLbl.Location = new Point(76, 22);
            AtendenteLbl.Location = new Point(603, 22);
            DiasCountAtendenteTbx.Location = new Point(821, 22);
            dataGridPendenteTempo.Location = new Point(606, 56);
            dataGridPendenteNaoAtualizado.Location = new Point(606, 494);
            PendenteAtualizacaoLbl.Location = new Point(603, 458);


            dataGridCountAtendente.Visible = true;
            QuantidadeAtendenteLbl.Visible = true;
            MenuSize = true;

        }

        public void ModoExibicaoRelatorioMenuAberto()
        {
            // Relatorio
            if (ModoRelatorio == true)
            {
                dataGridPendenteAtualizado.Location = new Point(260, 56);
                AtualizadosPendenteValidacaoLbl.Location = new Point(260, 22);
                AtendenteLbl.Location = new Point(799, 22);
                DiasCountAtendenteTbx.Location = new Point(1016, 22);
                dataGridPendenteTempo.Location = new Point(799, 56);
                dataGridPendenteNaoAtualizado.Location = new Point(799, 494);
                PendenteAtualizacaoLbl.Location = new Point(799, 458);

                dataGridCountAtendente.Visible = false;
                QuantidadeAtendenteLbl.Visible = false;

               // dataGridPrevisaoAbertoProgramacao.Visible = false;
               // abertoNaProgramacaoLbl.Visible = false;

            }

            // Previsao
            if (ModoPrevisao == true)
            {
                



            }
            ePnl.Visible = true;
            MenuSize = false;


            // Previsao


        }



        public void BuscarTelapesquisa()
        {
            FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();

            FrmEditarRelatorio frmEditarRelatorio = new FrmEditarRelatorio();


            FrmBaixarReq frmbaixaereq = new FrmBaixarReq();

            FrmEscolhaGrid frmescolhagrid = new FrmEscolhaGrid();

            // editar
            m.Requisito = frmEditarRelatorio.requisitoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmEditarRelatorio.dtaInclusaoDtm.Text = dataGridPendenteTempo.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmEditarRelatorio.clientTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmEditarRelatorio.atendenteTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmEditarRelatorio.ObservacaoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmEditarRelatorio.id_relatorioTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[5].Value.ToString());
            m.PendenteStatus = frmEditarRelatorio.validadoCbx.Text = dataGridPendenteTempo.CurrentRow.Cells[6].Value.ToString();
            m.RequisitoCorrecao = frmEditarRelatorio.requisitoCorrecaoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[7].Value.ToString();
            m.RequisitoAtualizacao = frmEditarRelatorio.requisitoAtualizacaoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[8].Value.ToString();
            m.ClienteAtualizado = frmEditarRelatorio.clienteAtualizadoCbx.Text = dataGridPendenteTempo.CurrentRow.Cells[9].Value.ToString();



            //baixar
            m.Requisito = frmbaixaereq.requisitoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmbaixaereq.dtaInclusaoDtm.Text = dataGridPendenteTempo.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmbaixaereq.clientTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmbaixaereq.atendenteTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmbaixaereq.ObservacaoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmbaixaereq.id_relatorioTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[5].Value.ToString());
            m.RequisitoCorrecao = frmbaixaereq.requisitoCorrecaoTbx.Text = dataGridPendenteTempo.CurrentRow.Cells[7].Value.ToString();


            frmescolhagrid.ShowDialog();

            if (frmescolhagrid.ControlEdit == 0)
            {
                frmEditarRelatorio.ShowDialog();

                AtualizaGrids();
            }

            if (frmescolhagrid.ControlEdit == 1)
            {
                frmbaixaereq.ShowDialog();

                AtualizaGrids();
            }
        }

        public void PesquisarTelaPrincipal()
        {
            FrmPesquisaRelatorio frmpesquisarelatorio = new FrmPesquisaRelatorio();

            frmpesquisarelatorio.pesquisaRequisitoTbx.Text = this.PesquisaNumRequisitoTelaPrincipalTbx.Text;

            frmpesquisarelatorio.PesquisaPorNumeroRequisito();

            frmpesquisarelatorio.ShowDialog();

            this.PesquisaNumRequisitoTelaPrincipalTbx.Text = "";
        }

        public void DiasCount()
        {
            m.DiasCountAtendente = DiasCountAtendenteTbx.Text;
            dataGridPendenteTempo.DataSource = daoManutencaoRelarotio.BuscarRelatorioPendenteTempoAtualizado(m);
        }


        public void AtualizaGrids()
        {
            dataGridPendenteAtualizado.DataSource = daoManutencaoRelarotio.BuscarRelatoriolienteAtualizado(m);

            dataGridPendenteNaoAtualizado.DataSource = daoManutencaoRelarotio.BuscarRelatoriolienteNaoAtualizado(m);

            dataGridPendenteTempo.DataSource = daoManutencaoRelarotio.BuscarRelatorioPendenteTempoAtualizado(m);

            dataGridCountAtendente.DataSource = daoManutencaoRelarotio.CountAtendente(m);

            dataGridPrevisaoAbertoProgramacao.DataSource = daoprevisao.AbertoProgramacao(p);

        }

        private void incluirRelatorioBtn_Click(object sender, EventArgs e)
        {
            FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();
        
            frmIncluirRelatorio.ShowDialog();

            AtualizaGrids();
        }

        private void FrmManutencaoRelatorio_Load(object sender, EventArgs e)
        {
           
            AtualizaGrids();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void atualizarGridBtn_Click(object sender, EventArgs e)
        {
            AtualizaGrids();

        }

        private void dataGridPendenteAtualizado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridPendenteAtualizado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();

            FrmBaixarReq frmbaixaereq = new FrmBaixarReq();

            FrmEditarRelatorio frmEditarRelatorio = new FrmEditarRelatorio();


            FrmEscolhaGrid frmescolhagrid = new FrmEscolhaGrid();

            // editar
            m.Requisito = frmEditarRelatorio.requisitoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmEditarRelatorio.dtaInclusaoDtm.Text = dataGridPendenteAtualizado.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmEditarRelatorio.clientTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmEditarRelatorio.atendenteTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmEditarRelatorio.ObservacaoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmEditarRelatorio.id_relatorioTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[5].Value.ToString());
            m.PendenteStatus = frmEditarRelatorio.validadoCbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[6].Value.ToString();
            m.RequisitoCorrecao = frmEditarRelatorio.requisitoCorrecaoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[7].Value.ToString();
            m.RequisitoAtualizacao = frmEditarRelatorio.requisitoAtualizacaoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[8].Value.ToString();
            m.ClienteAtualizado = frmEditarRelatorio.clienteAtualizadoCbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[9].Value.ToString();



            //baixar
            m.Requisito = frmbaixaereq.requisitoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmbaixaereq.dtaInclusaoDtm.Text = dataGridPendenteAtualizado.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmbaixaereq.clientTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmbaixaereq.atendenteTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmbaixaereq.ObservacaoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmbaixaereq.id_relatorioTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[5].Value.ToString());
            m.RequisitoCorrecao = frmbaixaereq.requisitoCorrecaoTbx.Text = dataGridPendenteAtualizado.CurrentRow.Cells[7].Value.ToString();
           

            frmescolhagrid.ShowDialog();

            if (frmescolhagrid.ControlEdit == 0)
            {

                frmEditarRelatorio.ShowDialog();

                AtualizaGrids();
            }

            if (frmescolhagrid.ControlEdit == 1)
            {
                frmbaixaereq.ShowDialog();

                AtualizaGrids();
            }
            


        }

        private void dataGridPendenteTempo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridPendenteTempo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.BuscarTelapesquisa();
                       
        }

        private void dataGridPendenteNaoAtualizado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPendenteNaoAtualizado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();

            FrmEditarRelatorio frmEditarRelatorio = new FrmEditarRelatorio();

            FrmBaixarReq frmbaixaereq = new FrmBaixarReq();

            FrmEscolhaGrid frmescolhagrid = new FrmEscolhaGrid();

            m.Requisito = frmEditarRelatorio.requisitoTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[0].Value.ToString();
            m.DtaInclusao = Convert.ToDateTime(frmEditarRelatorio.dtaInclusaoDtm.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[1].Value.ToString());
            m.Cliente = frmEditarRelatorio.clientTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[2].Value.ToString();
            m.Atendente = frmEditarRelatorio.atendenteTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[3].Value.ToString();
            m.Observacao = frmEditarRelatorio.ObservacaoTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[4].Value.ToString();
            m.Id_relatorio = Convert.ToInt32(frmEditarRelatorio.id_relatorioTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[5].Value.ToString());
            m.PendenteStatus = frmEditarRelatorio.validadoCbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[6].Value.ToString();
            m.RequisitoCorrecao = frmEditarRelatorio.requisitoCorrecaoTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[7].Value.ToString();
            m.RequisitoAtualizacao = frmEditarRelatorio.requisitoAtualizacaoTbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[8].Value.ToString();
            m.ClienteAtualizado = frmEditarRelatorio.clienteAtualizadoCbx.Text = dataGridPendenteNaoAtualizado.CurrentRow.Cells[9].Value.ToString();

            frmEditarRelatorio.ShowDialog();

            AtualizaGrids();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CountAtendente
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmManutencaoRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)

            {

                case Keys.F5: 
                    atualizarGridBtn_Click(sender, e);
                    break;

                case Keys.F7:
                   incluirRelatorioBtn_Click(sender, e);
                    break;
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPesquisaRelatorio frmpesquisarelatorio = new FrmPesquisaRelatorio();

            frmpesquisarelatorio.ShowDialog();

        }

        private void DiasCountAtendenteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

                this.DiasCount();

        }

        private void DiasCountAtendenteTbx_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)

            {

                case Keys.F3:
                    DiasCount();
                    dataGridPendenteTempo.DataSource = daoManutencaoRelarotio.BuscarRelatorioPendenteTempoAtualizado(m);
                    break;


            }

        }

        private void AtualizarDiasBtn_Click(object sender, EventArgs e)
        {
            DiasCount();
        }

        private void DiasCountAtendenteTbx_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Enter Para Atualizar Os Dias", TB, 0, 0, VisibleTime);
        }

        private void DiasCountAtendenteTbx_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Enter Para Atualizar Os Dias", TB, 0, 0, VisibleTime);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPesquisaRelatorio frmpesquisarelatorio = new FrmPesquisaRelatorio();

            frmpesquisarelatorio.ShowDialog();
            AtualizaGrids();
        }

        private void PesquisaNumRequisitoTelaPrincipalTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaNumRequisitoTelaPrincipalTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            this.PesquisarTelaPrincipal();
            
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            // menu aberto modo relatorio
            if (MenuSize == true)
            {
                if(ModoPrevisao == true)
                {
                    ModoExibicaoPrevisaoMenuAberto();
                    DesabilitaComponentesRelatorio();
                }
                else if (ModoRelatorio == true)
                {
                    ModoExibicaoRelatorioMenuAberto();

                }



            }
            // menu fechado modo relatorio
            else if (MenuSize == false)
            {

                if (ModoPrevisao == true)
                {
                    ModoExibicaoPrevisaoMenuFechado();
                }
                else if (ModoRelatorio == true)
                {
                    ModoExibicaoRelatorioMenuFechado();

                }




            }

          




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();

            frmIncluirRelatorio.ShowDialog();

            AtualizaGrids();
        }

        private void MenuPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisarTelaPrincipal();
            AtualizaGrids();
        }

        private void AtualizarGrids_Click(object sender, EventArgs e)
        {
            AtualizaGrids();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizaGrids();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmIncluirPrevisao frmincluirprevisao = new FrmIncluirPrevisao();

            frmincluirprevisao.ShowDialog();

            AtualizaGrids();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmIncluirPrevisao frmincluirprevisao = new FrmIncluirPrevisao();

            frmincluirprevisao.ShowDialog();

            AtualizaGrids();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExibirPrevisaoBtn_Click(object sender, EventArgs e)
        {
            


            // Controle de Modo
            ModoRelatorio = false;
            ModoPrevisao = true;
            ePnl.BackColor = Color.FromArgb(16, 123, 17);
            MenuPnl.BackColor = Color.FromArgb(16, 123, 17);
            this.Text = TextoVersaoPrevisao;

            exibirPrevisaoBtn.Visible = false;
            exibirPrevisaoTxtBtn.Visible = false;

            exibirRelatorioBtn.Visible = true;
            exibirRelatorioTxtBtn.Visible = true;

            DesabilitaComponentesRelatorio();


            ModoExibicaoPrevisaoMenuFechado();

        }

        private void ExibirPrevisaoTxtBtn_Click(object sender, EventArgs e)
        {

            exibirPrevisaoBtn.Visible = false;
            exibirPrevisaoTxtBtn.Visible = false;

            exibirRelatorioBtn.Visible = true;
            exibirRelatorioTxtBtn.Visible = true;




        }

        private void ExibirRelatorioBtn_Click(object sender, EventArgs e)
        {

            
            // Controle de Modo
            ModoRelatorio = true;
            ModoPrevisao = false;

            ePnl.BackColor = Color.FromArgb(0, 127, 255);
            MenuPnl.BackColor = Color.FromArgb(0, 127, 255);
            this.Text = TextoVersaoRelatorio;


            exibirPrevisaoBtn.Visible = true;
            exibirPrevisaoTxtBtn.Visible = true;

            exibirRelatorioBtn.Visible = false;
            exibirRelatorioTxtBtn.Visible = false;

            ModoExibicaoRelatorioMenuFechado();





        }

        private void ExibirRelatorioTxtBtn_Click(object sender, EventArgs e)
        {
            exibirPrevisaoBtn.Visible = true;
            exibirPrevisaoTxtBtn.Visible = true;

            exibirRelatorioBtn.Visible = false;
            exibirRelatorioTxtBtn.Visible = false;


            /*
            ePnl.Visible = false;
            dataGridPendenteAtualizado.Location = new Point(70, 56);
            AtualizadosPendenteValidacaoLbl.Location = new Point(76, 22);
            AtendenteLbl.Location = new Point(603, 22);
            DiasCountAtendenteTbx.Location = new Point(821, 22);
            dataGridPendenteTempo.Location = new Point(606, 56);
            dataGridPendenteNaoAtualizado.Location = new Point(606, 494);
            PendenteAtualizacaoLbl.Location = new Point(603, 458);


            dataGridCountAtendente.Visible = true;
            QuantidadeAtendenteLbl.Visible = true;
            */

        }
    }
}
