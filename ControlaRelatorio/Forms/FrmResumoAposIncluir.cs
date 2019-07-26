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
    public partial class FrmResumoAposIncluir : Form
    {
        public FrmResumoAposIncluir()
        {
            InitializeComponent();
        }

        private void FrmResumoAposIncluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

                this.Close();
        }

        private void ResumoTbxBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
