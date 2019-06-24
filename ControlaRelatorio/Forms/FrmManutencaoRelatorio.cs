﻿using Services.Dao;
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

        DaoInclusaoManutencaoRelatorio daoManutencaoRelarotio = new DaoInclusaoManutencaoRelatorio();

        FrmIncluirRelatorio frmIRel = (FrmIncluirRelatorio)Application.OpenForms["FrmIncluirRelatorio"];

        FrmEscolhaGrid grid = (FrmEscolhaGrid)Application.OpenForms["FrmEscolhaGrid"];
        

        public FrmManutencaoRelatorio()
        {
            InitializeComponent();

        }


        public void AtualizaGrids()
        {
            dataGridPendenteAtualizado.DataSource = daoManutencaoRelarotio.BuscarRelatoriolienteAtualizado(m);

            dataGridPendenteNaoAtualizado.DataSource = daoManutencaoRelarotio.BuscarRelatoriolienteNaoAtualizado(m);

            dataGridPendenteTempo.DataSource = daoManutencaoRelarotio.BuscarRelatorioPendenteTempoAtualizado(m);

            dataGridCountAtendente.DataSource = daoManutencaoRelarotio.CountAtendente(m);

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
    }
}