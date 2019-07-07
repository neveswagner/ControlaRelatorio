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
    public partial class FrmEditarRelatorio : Form
    {
        public FrmEditarRelatorio()
        {
            InitializeComponent();
        }

        FrmManutencaoRelatorio frmManRel = new FrmManutencaoRelatorio();

        ManutencaoRelatorio m = new ManutencaoRelatorio();

        DaoInclusaoManutencaoRelatorio dao = new DaoInclusaoManutencaoRelatorio();

        private void FrmEditarRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void incluirRelatorioBtn_Click(object sender, EventArgs e)
        {

            FrmEscolhaGrid frmEscGrid = (FrmEscolhaGrid)Application.OpenForms["FrmEscolhaGrid"];
            FrmEscolhaGrid frmgrid = new FrmEscolhaGrid();
            DaoInclusaoManutencaoRelatorio daoManutencaoRelarotio = new DaoInclusaoManutencaoRelatorio();


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

                m.Requisito = requisitoTbx.Text;

                m.DtaInclusao = Convert.ToDateTime(dtaInclusaoDtm.Text);
                m.Cliente = clientTbx.Text;
                m.Atendente = atendenteTbx.Text;
                m.Observacao = ObservacaoTbx.Text;
                m.Id_relatorio = Convert.ToInt32(id_relatorioTbx.Text);
                m.PendenteStatus = validadoCbx.Text;
                m.ClienteAtualizado = clienteAtualizadoCbx.Text;
                m.RequisitoAtualizacao = requisitoAtualizacaoTbx.Text;
                m.RequisitoCorrecao =  requisitoCorrecaoTbx.Text;

                dao.EditarRelatorio(m);
                MessageBox.Show("Requisito Editado Com Sucesso !");
                this.Close();


            }

        }

        private void FrmEditarRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)

            {

                case Keys.F10:
                    incluirRelatorioBtn_Click(sender, e);
                    break;

                
            }


        }

        private void requisitoCorrecaoTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEditarRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

                this.Close();
        }
    }
}


