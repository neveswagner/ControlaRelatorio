﻿using Services.Dao;
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
    public partial class FrmIncluirPrevisao : Form
    {
        Previsao p = new Previsao();

        DaoPrevisao dao = new DaoPrevisao();


        public FrmIncluirPrevisao()
        {
            InitializeComponent();
        }

        private void incluirRelatorioBtn_Click(object sender, EventArgs e)
        {

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


                p.DtaInclusao = Convert.ToDateTime(dtaInclusaoDtm.Text);
                p.DtaPrevisao = Convert.ToDateTime(dtaPrevisaoDtm.Text);
                p.Requisito = requisitoTbx.Text;
                p.Cliente = clientTbx.Text;
                p.Atendente = atendenteTbx.Text;
                p.ConcluidoStatus = validadoCbx.Text;
                p.ClienteAtualizado = clienteAtualizadoCbx.Text;
                p.Observacao = ObservacaoTbx.Text;
                p.RequisitoAtualizacao = requisitoAtualizacaoTbx.Text;
                p.BaixadoProgramacao = baixadoProgramacaoCbx.Text;

                dao.IncluirPrevisao(p);

                MessageBox.Show("Previsao Gravado Com Sucesso !");

                this.Close();


            }

        }
        }

}
