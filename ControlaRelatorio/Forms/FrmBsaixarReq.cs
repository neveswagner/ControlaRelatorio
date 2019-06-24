using Services.Dao;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaRelatorio.Forms
{
    public partial class FrmBaixarReq : Form
    {
        public FrmBaixarReq()
        {
            InitializeComponent();
        }

        ManutencaoRelatorio m = new ManutencaoRelatorio();
        DaoInclusaoManutencaoRelatorio dao = new DaoInclusaoManutencaoRelatorio();
        FrmManutencaoRelatorio frmmanutencaorelatorio = new FrmManutencaoRelatorio();


        private void ValidadoSimCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidadoSimCkb.Checked)
            {
                ValidadoSNaoCkb.Checked = false;

                sparkCkb.Checked = true;
                sparkCkb.Enabled = true;

                outrosCkb.Checked = false;
                outrosCkb.Enabled = true;

                obsBaixaTbx.Text = atendenteTbx.Text + " Deu OK Por Spark";

            }
            else
            {
                ValidadoSNaoCkb.Checked = true;
            }
        }

        private void ValidadoSNaoCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidadoSNaoCkb.Checked)
            {
                ValidadoSimCkb.Checked = false;

                sparkCkb.Checked = false;
                sparkCkb.Enabled = false;

                outrosCkb.Checked = false;
                outrosCkb.Enabled = false;

                requisitoCorrecaoLbl.Enabled = true;
                requisitoCorrecaoTbx.Enabled = true;

                obsBaixaTbx.Text = " ";

            }
            else
            {
                ValidadoSimCkb.Checked = true;
                requisitoCorrecaoLbl.Enabled = false;
                requisitoCorrecaoTbx.Enabled = false;
            }
        }

        private void sparkCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (sparkCkb.Checked == true)
            {
                outrosCkb.Checked = false;
                obsBaixaTbx.Text = atendenteTbx.Text + " Deu OK Por Spark";
            }
            else
            {
                outrosCkb.Checked = true;
            }
        }

       

        private void pessoalmenteCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (outrosCkb.Checked == true)
            {
                sparkCkb.Checked = false;
                obsBaixaTbx.Text = " ";
            }
            else
            {
                sparkCkb.Checked = true;
            }
        }

        private void FrmBaixarReq_Load(object sender, EventArgs e)
        {
            obsBaixaTbx.Text = atendenteTbx.Text + " Deu OK Por Spark";
        }

        private void incluirRelatorioBtn_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(obsBaixaTbx.Text))
            {
                MessageBox.Show("Campo observacao nao pode ser vazio");
                this.obsBaixaTbx.Focus();
            }

            if (ValidadoSNaoCkb.Checked == true)
            {
                if (String.IsNullOrEmpty(requisitoCorrecaoTbx.Text))
                {
                    MessageBox.Show("Campo requisito de correcao nao pode ser vazio");
                    this.requisitoCorrecaoTbx.Focus();
                }
                else if (!Regex.IsMatch(requisitoCorrecaoTbx.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Campo requisito de correcao deve conter somente Numeros");
                    this.requisitoCorrecaoTbx.Focus();

                }
            }

            else
            {


                m.Requisito = requisitoTbx.Text;
                m.DtaInclusao = Convert.ToDateTime(dtaInclusaoDtm.Text);
                m.Cliente = clientTbx.Text;
                m.Atendente = atendenteTbx.Text;
                m.Observacao = ObservacaoTbx.Text;
                m.Id_relatorio = Convert.ToInt32(id_relatorioTbx.Text);
                m.RequisitoCorrecao = requisitoCorrecaoTbx.Text;
                m.ObservacaoBaixa = obsBaixaTbx.Text;


                dao.BaixarRelatorio(m);

                this.Close();

                frmmanutencaorelatorio.AtualizaGrids();
            }
        }

        private void FrmBaixarReq_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void FrmBaixarReq_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)

            {

                case Keys.F10:
                    incluirRelatorioBtn_Click(sender, e);
                    break;


            }




        }



    }
}
