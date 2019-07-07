namespace ControlaRelatorio.Forms
{
    partial class FrmEditarRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarRelatorio));
            this.requisitoAtualizacaoLbl = new System.Windows.Forms.Label();
            this.requisitoAtualizacaoTbx = new System.Windows.Forms.TextBox();
            this.requisitoCorrecaoLbl = new System.Windows.Forms.Label();
            this.requisitoCorrecaoTbx = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // requisitoAtualizacaoLbl
            // 
            this.requisitoAtualizacaoLbl.AutoSize = true;
            this.requisitoAtualizacaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitoAtualizacaoLbl.Location = new System.Drawing.Point(19, 289);
            this.requisitoAtualizacaoLbl.Name = "requisitoAtualizacaoLbl";
            this.requisitoAtualizacaoLbl.Size = new System.Drawing.Size(138, 18);
            this.requisitoAtualizacaoLbl.TabIndex = 45;
            this.requisitoAtualizacaoLbl.Text = "Requisito Atualizacao";
            // 
            // requisitoAtualizacaoTbx
            // 
            this.requisitoAtualizacaoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.requisitoAtualizacaoTbx.Location = new System.Drawing.Point(174, 287);
            this.requisitoAtualizacaoTbx.Name = "requisitoAtualizacaoTbx";
            this.requisitoAtualizacaoTbx.Size = new System.Drawing.Size(100, 20);
            this.requisitoAtualizacaoTbx.TabIndex = 6;
            // 
            // requisitoCorrecaoLbl
            // 
            this.requisitoCorrecaoLbl.AutoSize = true;
            this.requisitoCorrecaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitoCorrecaoLbl.Location = new System.Drawing.Point(35, 329);
            this.requisitoCorrecaoLbl.Name = "requisitoCorrecaoLbl";
            this.requisitoCorrecaoLbl.Size = new System.Drawing.Size(122, 18);
            this.requisitoCorrecaoLbl.TabIndex = 43;
            this.requisitoCorrecaoLbl.Text = "Requisito Correcao";
            // 
            // requisitoCorrecaoTbx
            // 
            this.requisitoCorrecaoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.requisitoCorrecaoTbx.Location = new System.Drawing.Point(174, 327);
            this.requisitoCorrecaoTbx.Name = "requisitoCorrecaoTbx";
            this.requisitoCorrecaoTbx.Size = new System.Drawing.Size(100, 20);
            this.requisitoCorrecaoTbx.TabIndex = 7;
            this.requisitoCorrecaoTbx.TextChanged += new System.EventHandler(this.requisitoCorrecaoTbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id Relatorio";
            // 
            // id_relatorioTbx
            // 
            this.id_relatorioTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.id_relatorioTbx.Enabled = false;
            this.id_relatorioTbx.Location = new System.Drawing.Point(174, 19);
            this.id_relatorioTbx.Name = "id_relatorioTbx";
            this.id_relatorioTbx.Size = new System.Drawing.Size(100, 20);
            this.id_relatorioTbx.TabIndex = 40;
            // 
            // ObservacaoTbx
            // 
            this.ObservacaoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ObservacaoTbx.Location = new System.Drawing.Point(174, 252);
            this.ObservacaoTbx.Name = "ObservacaoTbx";
            this.ObservacaoTbx.Size = new System.Drawing.Size(212, 20);
            this.ObservacaoTbx.TabIndex = 5;
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
            this.incluirRelatorioBtn.Location = new System.Drawing.Point(149, 385);
            this.incluirRelatorioBtn.Name = "incluirRelatorioBtn";
            this.incluirRelatorioBtn.Size = new System.Drawing.Size(125, 47);
            this.incluirRelatorioBtn.TabIndex = 8;
            this.incluirRelatorioBtn.Text = "Gravar F10";
            this.incluirRelatorioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirRelatorioBtn.UseVisualStyleBackColor = true;
            this.incluirRelatorioBtn.Click += new System.EventHandler(this.incluirRelatorioBtn_Click);
            // 
            // ObservacoesLbl
            // 
            this.ObservacoesLbl.AutoSize = true;
            this.ObservacoesLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservacoesLbl.Location = new System.Drawing.Point(72, 254);
            this.ObservacoesLbl.Name = "ObservacoesLbl";
            this.ObservacoesLbl.Size = new System.Drawing.Size(85, 18);
            this.ObservacoesLbl.TabIndex = 37;
            this.ObservacoesLbl.Text = "Observacoes";
            // 
            // clienteAtualizadoCbx
            // 
            this.clienteAtualizadoCbx.FormattingEnabled = true;
            this.clienteAtualizadoCbx.Items.AddRange(new object[] {
            "S",
            "N"});
            this.clienteAtualizadoCbx.Location = new System.Drawing.Point(174, 219);
            this.clienteAtualizadoCbx.Name = "clienteAtualizadoCbx";
            this.clienteAtualizadoCbx.Size = new System.Drawing.Size(37, 21);
            this.clienteAtualizadoCbx.TabIndex = 4;
            this.clienteAtualizadoCbx.Text = "S";
            // 
            // validadoCbx
            // 
            this.validadoCbx.FormattingEnabled = true;
            this.validadoCbx.Items.AddRange(new object[] {
            "N",
            "S"});
            this.validadoCbx.Location = new System.Drawing.Point(174, 185);
            this.validadoCbx.Name = "validadoCbx";
            this.validadoCbx.Size = new System.Drawing.Size(37, 21);
            this.validadoCbx.TabIndex = 3;
            this.validadoCbx.Text = "N";
            // 
            // validadeLbl
            // 
            this.validadeLbl.AutoSize = true;
            this.validadeLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validadeLbl.Location = new System.Drawing.Point(96, 185);
            this.validadeLbl.Name = "validadeLbl";
            this.validadeLbl.Size = new System.Drawing.Size(61, 18);
            this.validadeLbl.TabIndex = 34;
            this.validadeLbl.Text = "Validado";
            // 
            // clienteAtualizadoLbl
            // 
            this.clienteAtualizadoLbl.AutoSize = true;
            this.clienteAtualizadoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteAtualizadoLbl.Location = new System.Drawing.Point(38, 222);
            this.clienteAtualizadoLbl.Name = "clienteAtualizadoLbl";
            this.clienteAtualizadoLbl.Size = new System.Drawing.Size(119, 18);
            this.clienteAtualizadoLbl.TabIndex = 33;
            this.clienteAtualizadoLbl.Text = "Cliente Atualizado";
            // 
            // AtendenteLbl
            // 
            this.AtendenteLbl.AutoSize = true;
            this.AtendenteLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtendenteLbl.Location = new System.Drawing.Point(87, 152);
            this.AtendenteLbl.Name = "AtendenteLbl";
            this.AtendenteLbl.Size = new System.Drawing.Size(70, 18);
            this.AtendenteLbl.TabIndex = 32;
            this.AtendenteLbl.Text = "Atendente";
            // 
            // atendenteTbx
            // 
            this.atendenteTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.atendenteTbx.Location = new System.Drawing.Point(174, 150);
            this.atendenteTbx.Name = "atendenteTbx";
            this.atendenteTbx.Size = new System.Drawing.Size(100, 20);
            this.atendenteTbx.TabIndex = 2;
            // 
            // dtaInclusaoDtm
            // 
            this.dtaInclusaoDtm.Location = new System.Drawing.Point(174, 53);
            this.dtaInclusaoDtm.Name = "dtaInclusaoDtm";
            this.dtaInclusaoDtm.Size = new System.Drawing.Size(212, 20);
            this.dtaInclusaoDtm.TabIndex = 30;
            // 
            // DtaInclusaoLbl
            // 
            this.DtaInclusaoLbl.AutoSize = true;
            this.DtaInclusaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtaInclusaoLbl.Location = new System.Drawing.Point(65, 53);
            this.DtaInclusaoLbl.Name = "DtaInclusaoLbl";
            this.DtaInclusaoLbl.Size = new System.Drawing.Size(92, 18);
            this.DtaInclusaoLbl.TabIndex = 29;
            this.DtaInclusaoLbl.Text = "Data Inclusao";
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLbl.Location = new System.Drawing.Point(107, 117);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(50, 18);
            this.clienteLbl.TabIndex = 28;
            this.clienteLbl.Text = "Cliente";
            // 
            // clientTbx
            // 
            this.clientTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clientTbx.Location = new System.Drawing.Point(174, 117);
            this.clientTbx.Name = "clientTbx";
            this.clientTbx.Size = new System.Drawing.Size(100, 20);
            this.clientTbx.TabIndex = 1;
            // 
            // requisitoLbl
            // 
            this.requisitoLbl.AutoSize = true;
            this.requisitoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitoLbl.Location = new System.Drawing.Point(94, 86);
            this.requisitoLbl.Name = "requisitoLbl";
            this.requisitoLbl.Size = new System.Drawing.Size(63, 18);
            this.requisitoLbl.TabIndex = 26;
            this.requisitoLbl.Text = "Requisito";
            // 
            // requisitoTbx
            // 
            this.requisitoTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.requisitoTbx.Location = new System.Drawing.Point(174, 84);
            this.requisitoTbx.Name = "requisitoTbx";
            this.requisitoTbx.Size = new System.Drawing.Size(100, 20);
            this.requisitoTbx.TabIndex = 0;
            // 
            // FrmEditarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(415, 470);
            this.Controls.Add(this.requisitoAtualizacaoLbl);
            this.Controls.Add(this.requisitoAtualizacaoTbx);
            this.Controls.Add(this.requisitoCorrecaoLbl);
            this.Controls.Add(this.requisitoCorrecaoTbx);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmEditarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Relatorio";
            this.Load += new System.EventHandler(this.FrmEditarRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEditarRelatorio_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmEditarRelatorio_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label requisitoAtualizacaoLbl;
        public System.Windows.Forms.TextBox requisitoAtualizacaoTbx;
        public System.Windows.Forms.Label requisitoCorrecaoLbl;
        public System.Windows.Forms.TextBox requisitoCorrecaoTbx;
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
    }
}