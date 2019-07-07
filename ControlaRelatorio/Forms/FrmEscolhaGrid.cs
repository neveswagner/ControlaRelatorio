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
    public partial class FrmEscolhaGrid : Form
    {

        

        FrmIncluirRelatorio frmIncluirRelatorio = new FrmIncluirRelatorio();
        FrmEditarRelatorio frmEditarRelatorio = new FrmEditarRelatorio();
        FrmBaixarReq frmbaixareq = new FrmBaixarReq();
        ManutencaoRelatorio m = new ManutencaoRelatorio();



        public FrmEscolhaGrid()
        {
            InitializeComponent();
            ControlEdit = 2;

        }

        public int ControlEdit  { get; set; }


        private void editarRelatorioBtn_Click(object sender, EventArgs e)
        {

            ControlEdit = 0;

            this.Close();

        }

        private void FrmEscolhaGrid_Load(object sender, EventArgs e)
        {

        }

        private void baixarGridBtn_Click(object sender, EventArgs e)
        {
            ControlEdit = 1;

            this.Close();

        }

        private void FrmEscolhaGrid_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmEscolhaGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

                this.Close();
        }
    }
}
