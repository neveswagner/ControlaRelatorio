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
    public partial class FrmIncluirRelatorio : Form
    {
       // FrmManutencaoRelatorio FrmManRel = (FrmManutencaoRelatorio)Application.OpenForms["FrmManutencaoRelatorio"];


        FrmManutencaoRelatorio frmManRel = new FrmManutencaoRelatorio();

        ManutencaoRelatorio m = new ManutencaoRelatorio();

        DaoInclusaoManutencaoRelatorio dao = new DaoInclusaoManutencaoRelatorio();
       // FrmEscolhaGrid frmescolhagrid = new FrmEscolhaGrid();


       //  FrmEscolhaGrid frmEscGrid = new FrmEscolhaGrid();



        public FrmIncluirRelatorio()
        {
            InitializeComponent();

        }










        private void FrmIncluirRelatorio_Load(object sender, EventArgs e)
        {
            FrmEscolhaGrid frmEscGrid = (FrmEscolhaGrid)Application.OpenForms["FrmEscolhaGrid"];
            FrmEscolhaGrid frmgrid = new FrmEscolhaGrid();


          
                requisitoAtualizacaoLbl.Visible = false;
                requisitoAtualizacaoTbx.Visible = false;
                requisitoCorrecaoLbl.Visible = false;
                requisitoCorrecaoTbx.Visible = false;
                this.Refresh();
            
        }

        private void incluirRelatorioBtn_Click(object sender, EventArgs e)
        {

            FrmEscolhaGrid frmEscGrid = (FrmEscolhaGrid)Application.OpenForms["FrmEscolhaGrid"];
            FrmEscolhaGrid frmgrid = new FrmEscolhaGrid();

            if (String.IsNullOrEmpty(requisitoTbx.Text))
            {
                MessageBox.Show("Campo Requisito nao deve ser vazio");
                this.requisitoTbx.Focus();
            }
            else if (!Regex.IsMatch(requisitoTbx.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Campo Requisito deve conter somente Numeros");
                this.requisitoTbx.Focus();

            }
            else if (String.IsNullOrEmpty(clientTbx.Text))
            {
                MessageBox.Show("Campo Cliente nao deve ser vazio");
                this.clientTbx.Focus();
            }
            else if (String.IsNullOrEmpty(atendenteTbx.Text))
            {
                MessageBox.Show("Campo Atendente nao deve ser vazio");
                this.atendenteTbx.Focus();
            }
            
            else
            {


                m.DtaInclusao = Convert.ToDateTime(dtaInclusaoDtm.Text);
                m.Requisito = requisitoTbx.Text;
                m.Cliente = clientTbx.Text;
                m.Atendente = atendenteTbx.Text;
                m.PendenteStatus = validadoCbx.Text;
                m.ClienteAtualizado = clienteAtualizadoCbx.Text;
                m.Observacao = ObservacaoTbx.Text;

                dao.SalvarRelatorio(m);
                MessageBox.Show("Requisito Gravado Com Sucesso !");

                this.Close();

            }



        }

        private void FrmIncluirRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FrmIncluirRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)

            {

                case Keys.F10:
                    incluirRelatorioBtn_Click(sender, e);
                    break;
            }

            
        }

        private void incluirRelatorioBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }

        private void FrmIncluirRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

                this.Close();
        }

        private void FrmIncluirRelatorio_KeyUp(object sender, KeyEventArgs e)
        {

        }





    }
}
