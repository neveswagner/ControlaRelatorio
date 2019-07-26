using Services.Dao;
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
    public partial class FrmCobrarRelatorioAtendente : Form
    {

        DaoInclusaoManutencaoRelatorio daoManutencaoRelarotio = new DaoInclusaoManutencaoRelatorio();

        public FrmCobrarRelatorioAtendente()
        {
            InitializeComponent();
        }

        private void FrmCobrarRelatorioAtendente_Load(object sender, EventArgs e)
        {
            DateTime horario = DateTime.Now;

            if (horario.Hour <= 12)
            {
                rTxtCobrarAtendente.AppendText ( "Bom Dia\n" + "Relatorio Pendente\n\n");
            }
            else
            {
                rTxtCobrarAtendente.AppendText("Boa Tarde\n" + "Relatorio Pendente\n\n");
            }

            for (int i = 0; i < DataCobrarRelatorioAtndente.Rows.Count; i++)
            {
                string Req = DataCobrarRelatorioAtndente.Rows[i].Cells[0].Value.ToString();
                rTxtCobrarAtendente.AppendText(Req + "  -  ");
                string Cliente = DataCobrarRelatorioAtndente.Rows[i].Cells[1].Value.ToString();
                rTxtCobrarAtendente.AppendText(Cliente + "\n");

            }
        }

        private void cobrarAtendenteBtn_Click(object sender, EventArgs e)
        {
            rTxtCobrarAtendente.Visible = true;
        }

        private void FrmCobrarRelatorioAtendente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

                this.Close();
        }
    }
}
