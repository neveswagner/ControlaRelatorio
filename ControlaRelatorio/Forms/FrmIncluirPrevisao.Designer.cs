﻿namespace ControlaRelatorio.Forms
{
    partial class FrmIncluirPrevisao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.requisitoAtualizacaoLbl = new System.Windows.Forms.Label();
            this.requisitoAtualizacaoTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_relatorioTbx = new System.Windows.Forms.TextBox();
            this.ObservacaoTbx = new System.Windows.Forms.TextBox();
            this.incluirRelatorioBtn = new System.Windows.Forms.Button();
            this.ObservacoesLbl = new System.Windows.Forms.Label();
            this.clienteAtualizadoCbx = new System.Windows.Forms.ComboBox();
            this.validadoCbx = new System.Windows.Forms.ComboBox();
            this.validadeLbl = new System.Windows.Forms.Label();
            this.clienteAtualizadoLbl = new System.Windows.Forms.Label();
            this.AtendenteLbl = new System.Windows.Forms.Label();
            this.atendenteTbx = new System.Windows.Forms.TextBox();
            this.dtaInclusaoDtm = new System.Windows.Forms.DateTimePicker();
            this.DtaInclusaoLbl = new System.Windows.Forms.Label();
            this.clienteLbl = new System.Windows.Forms.Label();
            this.clientTbx = new System.Windows.Forms.TextBox();
            this.requisitoLbl = new System.Windows.Forms.Label();
            this.requisitoTbx = new System.Windows.Forms.TextBox();
            this.dtaPrevisaoDtm = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.baixadoProgramacaoCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requisitoAtualizacaoLbl
            // 
            this.requisitoAtualizacaoLbl.AutoSize = true;
            this.requisitoAtualizacaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitoAtualizacaoLbl.Location = new System.Drawing.Point(16, 354);
            this.requisitoAtualizacaoLbl.Name = "requisitoAtualizacaoLbl";
            this.requisitoAtualizacaoLbl.Size = new System.Drawing.Size(138, 18);
            this.requisitoAtualizacaoLbl.TabIndex = 70;
            this.requisitoAtualizacaoLbl.Text = "Requisito Atualizacao";
            // 
            // requisitoAtualizacaoTbx
            // 
            this.requisitoAtualizacaoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.requisitoAtualizacaoTbx.Location = new System.Drawing.Point(171, 352);
            this.requisitoAtualizacaoTbx.Name = "requisitoAtualizacaoTbx";
            this.requisitoAtualizacaoTbx.Size = new System.Drawing.Size(100, 20);
            this.requisitoAtualizacaoTbx.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Id Previsao";
            // 
            // id_relatorioTbx
            // 
            this.id_relatorioTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.id_relatorioTbx.Enabled = false;
            this.id_relatorioTbx.Location = new System.Drawing.Point(171, 20);
            this.id_relatorioTbx.Name = "id_relatorioTbx";
            this.id_relatorioTbx.Size = new System.Drawing.Size(100, 20);
            this.id_relatorioTbx.TabIndex = 67;
            // 
            // ObservacaoTbx
            // 
            this.ObservacaoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ObservacaoTbx.Location = new System.Drawing.Point(171, 317);
            this.ObservacaoTbx.Name = "ObservacaoTbx";
            this.ObservacaoTbx.Size = new System.Drawing.Size(212, 20);
            this.ObservacaoTbx.TabIndex = 59;
            // 
            // incluirRelatorioBtn
            // 
            this.incluirRelatorioBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.incluirRelatorioBtn.FlatAppearance.BorderSize = 2;
            this.incluirRelatorioBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.incluirRelatorioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.incluirRelatorioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirRelatorioBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluirRelatorioBtn.Image = global::ControlaRelatorio.Properties.Resources.icons8_salvar_e_fechar_40;
            this.incluirRelatorioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.incluirRelatorioBtn.Location = new System.Drawing.Point(146, 417);
            this.incluirRelatorioBtn.Name = "incluirRelatorioBtn";
            this.incluirRelatorioBtn.Size = new System.Drawing.Size(125, 47);
            this.incluirRelatorioBtn.TabIndex = 63;
            this.incluirRelatorioBtn.Text = "Gravar F10";
            this.incluirRelatorioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirRelatorioBtn.UseVisualStyleBackColor = true;
            this.incluirRelatorioBtn.Click += new System.EventHandler(this.incluirRelatorioBtn_Click);
            // 
            // ObservacoesLbl
            // 
            this.ObservacoesLbl.AutoSize = true;
            this.ObservacoesLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservacoesLbl.Location = new System.Drawing.Point(69, 319);
            this.ObservacoesLbl.Name = "ObservacoesLbl";
            this.ObservacoesLbl.Size = new System.Drawing.Size(85, 18);
            this.ObservacoesLbl.TabIndex = 66;
            this.ObservacoesLbl.Text = "Observacoes";
            // 
            // clienteAtualizadoCbx
            // 
            this.clienteAtualizadoCbx.FormattingEnabled = true;
            this.clienteAtualizadoCbx.Items.AddRange(new object[] {
            "S",
            "N"});
            this.clienteAtualizadoCbx.Location = new System.Drawing.Point(171, 284);
            this.clienteAtualizadoCbx.Name = "clienteAtualizadoCbx";
            this.clienteAtualizadoCbx.Size = new System.Drawing.Size(37, 21);
            this.clienteAtualizadoCbx.TabIndex = 57;
            this.clienteAtualizadoCbx.Text = "N";
            // 
            // validadoCbx
            // 
            this.validadoCbx.FormattingEnabled = true;
            this.validadoCbx.Items.AddRange(new object[] {
            "N",
            "S"});
            this.validadoCbx.Location = new System.Drawing.Point(171, 219);
            this.validadoCbx.Name = "validadoCbx";
            this.validadoCbx.Size = new System.Drawing.Size(37, 21);
            this.validadoCbx.TabIndex = 56;
            this.validadoCbx.Text = "N";
            // 
            // validadeLbl
            // 
            this.validadeLbl.AutoSize = true;
            this.validadeLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validadeLbl.Location = new System.Drawing.Point(93, 219);
            this.validadeLbl.Name = "validadeLbl";
            this.validadeLbl.Size = new System.Drawing.Size(67, 18);
            this.validadeLbl.TabIndex = 65;
            this.validadeLbl.Text = "Concluido";
            // 
            // clienteAtualizadoLbl
            // 
            this.clienteAtualizadoLbl.AutoSize = true;
            this.clienteAtualizadoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteAtualizadoLbl.Location = new System.Drawing.Point(35, 287);
            this.clienteAtualizadoLbl.Name = "clienteAtualizadoLbl";
            this.clienteAtualizadoLbl.Size = new System.Drawing.Size(119, 18);
            this.clienteAtualizadoLbl.TabIndex = 64;
            this.clienteAtualizadoLbl.Text = "Cliente Atualizado";
            // 
            // AtendenteLbl
            // 
            this.AtendenteLbl.AutoSize = true;
            this.AtendenteLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtendenteLbl.Location = new System.Drawing.Point(84, 186);
            this.AtendenteLbl.Name = "AtendenteLbl";
            this.AtendenteLbl.Size = new System.Drawing.Size(70, 18);
            this.AtendenteLbl.TabIndex = 61;
            this.AtendenteLbl.Text = "Atendente";
            // 
            // atendenteTbx
            // 
            this.atendenteTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.atendenteTbx.Location = new System.Drawing.Point(171, 184);
            this.atendenteTbx.Name = "atendenteTbx";
            this.atendenteTbx.Size = new System.Drawing.Size(100, 20);
            this.atendenteTbx.TabIndex = 54;
            // 
            // dtaInclusaoDtm
            // 
            this.dtaInclusaoDtm.Location = new System.Drawing.Point(171, 54);
            this.dtaInclusaoDtm.Name = "dtaInclusaoDtm";
            this.dtaInclusaoDtm.Size = new System.Drawing.Size(212, 20);
            this.dtaInclusaoDtm.TabIndex = 71;
            // 
            // DtaInclusaoLbl
            // 
            this.DtaInclusaoLbl.AutoSize = true;
            this.DtaInclusaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtaInclusaoLbl.Location = new System.Drawing.Point(62, 54);
            this.DtaInclusaoLbl.Name = "DtaInclusaoLbl";
            this.DtaInclusaoLbl.Size = new System.Drawing.Size(92, 18);
            this.DtaInclusaoLbl.TabIndex = 58;
            this.DtaInclusaoLbl.Text = "Data Inclusao";
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLbl.Location = new System.Drawing.Point(104, 151);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(50, 18);
            this.clienteLbl.TabIndex = 55;
            this.clienteLbl.Text = "Cliente";
            // 
            // clientTbx
            // 
            this.clientTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clientTbx.Location = new System.Drawing.Point(171, 151);
            this.clientTbx.Name = "clientTbx";
            this.clientTbx.Size = new System.Drawing.Size(100, 20);
            this.clientTbx.TabIndex = 52;
            // 
            // requisitoLbl
            // 
            this.requisitoLbl.AutoSize = true;
            this.requisitoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitoLbl.Location = new System.Drawing.Point(91, 120);
            this.requisitoLbl.Name = "requisitoLbl";
            this.requisitoLbl.Size = new System.Drawing.Size(63, 18);
            this.requisitoLbl.TabIndex = 53;
            this.requisitoLbl.Text = "Requisito";
            // 
            // requisitoTbx
            // 
            this.requisitoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.requisitoTbx.Location = new System.Drawing.Point(171, 118);
            this.requisitoTbx.Name = "requisitoTbx";
            this.requisitoTbx.Size = new System.Drawing.Size(100, 20);
            this.requisitoTbx.TabIndex = 51;
            // 
            // dtaPrevisaoDtm
            // 
            this.dtaPrevisaoDtm.Location = new System.Drawing.Point(171, 88);
            this.dtaPrevisaoDtm.Name = "dtaPrevisaoDtm";
            this.dtaPrevisaoDtm.Size = new System.Drawing.Size(212, 20);
            this.dtaPrevisaoDtm.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Data Previsao";
            // 
            // baixadoProgramacaoCbx
            // 
            this.baixadoProgramacaoCbx.FormattingEnabled = true;
            this.baixadoProgramacaoCbx.Items.AddRange(new object[] {
            "S",
            "N"});
            this.baixadoProgramacaoCbx.Location = new System.Drawing.Point(171, 251);
            this.baixadoProgramacaoCbx.Name = "baixadoProgramacaoCbx";
            this.baixadoProgramacaoCbx.Size = new System.Drawing.Size(37, 21);
            this.baixadoProgramacaoCbx.TabIndex = 74;
            this.baixadoProgramacaoCbx.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "Baixado Programacao";
            // 
            // FrmIncluirPrevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 504);
            this.Controls.Add(this.baixadoProgramacaoCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtaPrevisaoDtm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.requisitoAtualizacaoLbl);
            this.Controls.Add(this.requisitoAtualizacaoTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_relatorioTbx);
            this.Controls.Add(this.ObservacaoTbx);
            this.Controls.Add(this.incluirRelatorioBtn);
            this.Controls.Add(this.ObservacoesLbl);
            this.Controls.Add(this.clienteAtualizadoCbx);
            this.Controls.Add(this.validadoCbx);
            this.Controls.Add(this.validadeLbl);
            this.Controls.Add(this.clienteAtualizadoLbl);
            this.Controls.Add(this.AtendenteLbl);
            this.Controls.Add(this.atendenteTbx);
            this.Controls.Add(this.dtaInclusaoDtm);
            this.Controls.Add(this.DtaInclusaoLbl);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.clientTbx);
            this.Controls.Add(this.requisitoLbl);
            this.Controls.Add(this.requisitoTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmIncluirPrevisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Previsao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label requisitoAtualizacaoLbl;
        public System.Windows.Forms.TextBox requisitoAtualizacaoTbx;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox id_relatorioTbx;
        public System.Windows.Forms.TextBox ObservacaoTbx;
        public System.Windows.Forms.Button incluirRelatorioBtn;
        public System.Windows.Forms.Label ObservacoesLbl;
        public System.Windows.Forms.ComboBox clienteAtualizadoCbx;
        public System.Windows.Forms.ComboBox validadoCbx;
        public System.Windows.Forms.Label validadeLbl;
        public System.Windows.Forms.Label clienteAtualizadoLbl;
        public System.Windows.Forms.Label AtendenteLbl;
        public System.Windows.Forms.TextBox atendenteTbx;
        public System.Windows.Forms.DateTimePicker dtaInclusaoDtm;
        public System.Windows.Forms.Label DtaInclusaoLbl;
        public System.Windows.Forms.Label clienteLbl;
        public System.Windows.Forms.TextBox clientTbx;
        public System.Windows.Forms.Label requisitoLbl;
        public System.Windows.Forms.TextBox requisitoTbx;
        public System.Windows.Forms.DateTimePicker dtaPrevisaoDtm;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox baixadoProgramacaoCbx;
        public System.Windows.Forms.Label label3;
    }
}