namespace ControlaRelatorio.Forms
{
    partial class FrmPesquisaRelatorio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaRelatorio));
            this.pesquisaRequisitoTbx = new System.Windows.Forms.TextBox();
            this.DtaInclusaoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisaAtendenteTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisaClienteTbx = new System.Windows.Forms.TextBox();
            this.controle_relatorioDataSet = new ControlaRelatorio.controle_relatorioDataSet();
            this.controlerelatorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridPesquisaPrincipal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlerelatorioDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PesqisaRelatorio = new System.Windows.Forms.Button();
            this.EmAbertoCbx = new System.Windows.Forms.CheckBox();
            this.BaixadoCbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.controle_relatorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlerelatorioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlerelatorioDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaRequisitoTbx
            // 
            this.pesquisaRequisitoTbx.Location = new System.Drawing.Point(89, 9);
            this.pesquisaRequisitoTbx.Name = "pesquisaRequisitoTbx";
            this.pesquisaRequisitoTbx.Size = new System.Drawing.Size(186, 20);
            this.pesquisaRequisitoTbx.TabIndex = 3;
            this.pesquisaRequisitoTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisaRequisitoTbx_KeyPress);
            // 
            // DtaInclusaoLbl
            // 
            this.DtaInclusaoLbl.AutoSize = true;
            this.DtaInclusaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtaInclusaoLbl.Location = new System.Drawing.Point(12, 9);
            this.DtaInclusaoLbl.Name = "DtaInclusaoLbl";
            this.DtaInclusaoLbl.Size = new System.Drawing.Size(63, 18);
            this.DtaInclusaoLbl.TabIndex = 30;
            this.DtaInclusaoLbl.Text = "Requisito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Atendente";
            // 
            // pesquisaAtendenteTbx
            // 
            this.pesquisaAtendenteTbx.Location = new System.Drawing.Point(89, 35);
            this.pesquisaAtendenteTbx.Name = "pesquisaAtendenteTbx";
            this.pesquisaAtendenteTbx.Size = new System.Drawing.Size(186, 20);
            this.pesquisaAtendenteTbx.TabIndex = 31;
            this.pesquisaAtendenteTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisaAtendenteTbx_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cliente";
            // 
            // pesquisaClienteTbx
            // 
            this.pesquisaClienteTbx.Location = new System.Drawing.Point(386, 9);
            this.pesquisaClienteTbx.Name = "pesquisaClienteTbx";
            this.pesquisaClienteTbx.Size = new System.Drawing.Size(186, 20);
            this.pesquisaClienteTbx.TabIndex = 33;
            this.pesquisaClienteTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisaClienteTbx_KeyPress);
            // 
            // controle_relatorioDataSet
            // 
            this.controle_relatorioDataSet.DataSetName = "controle_relatorioDataSet";
            this.controle_relatorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlerelatorioDataSetBindingSource
            // 
            this.controlerelatorioDataSetBindingSource.DataSource = this.controle_relatorioDataSet;
            this.controlerelatorioDataSetBindingSource.Position = 0;
            // 
            // dataGridPesquisaPrincipal
            // 
            this.dataGridPesquisaPrincipal.AllowUserToAddRows = false;
            this.dataGridPesquisaPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridPesquisaPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPesquisaPrincipal.AutoGenerateColumns = false;
            this.dataGridPesquisaPrincipal.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridPesquisaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPesquisaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesquisaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridPesquisaPrincipal.DataSource = this.controlerelatorioDataSetBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPesquisaPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPesquisaPrincipal.Location = new System.Drawing.Point(12, 74);
            this.dataGridPesquisaPrincipal.Name = "dataGridPesquisaPrincipal";
            this.dataGridPesquisaPrincipal.ReadOnly = true;
            this.dataGridPesquisaPrincipal.RowHeadersVisible = false;
            this.dataGridPesquisaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPesquisaPrincipal.Size = new System.Drawing.Size(906, 422);
            this.dataGridPesquisaPrincipal.TabIndex = 40;
            this.dataGridPesquisaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesquisaPrincipal_CellContentClick);
            this.dataGridPesquisaPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesquisaPrincipal_CellDoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Requisito";
            this.Column1.HeaderText = "Requisito";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DtaInclusao";
            this.Column3.HeaderText = "Data Inclusao";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cliente";
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Atendente";
            this.Column4.HeaderText = "Atendente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Observacao";
            this.Column5.HeaderText = "Observacao";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id_relatorio";
            this.Column6.HeaderText = "id_relatorio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PendenteStatus";
            this.Column8.HeaderText = "Validado";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RequisitoCorrecao";
            this.Column9.HeaderText = "Requisito Correcao";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "RequisitoAtualizacao";
            this.Column10.HeaderText = "Requisito Atualizacao";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ClienteAtualizado";
            this.Column11.HeaderText = "Cliente Atualizado";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // controlerelatorioDataSetBindingSource1
            // 
            this.controlerelatorioDataSetBindingSource1.DataSource = this.controle_relatorioDataSet;
            this.controlerelatorioDataSetBindingSource1.Position = 0;
            // 
            // PesqisaRelatorio
            // 
            this.PesqisaRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.PesqisaRelatorio.FlatAppearance.BorderSize = 2;
            this.PesqisaRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.PesqisaRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.PesqisaRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesqisaRelatorio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqisaRelatorio.Image = global::ControlaRelatorio.Properties.Resources.icons8_pesquisar_48;
            this.PesqisaRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PesqisaRelatorio.Location = new System.Drawing.Point(618, 12);
            this.PesqisaRelatorio.Name = "PesqisaRelatorio";
            this.PesqisaRelatorio.Size = new System.Drawing.Size(137, 47);
            this.PesqisaRelatorio.TabIndex = 39;
            this.PesqisaRelatorio.Text = "Pesquisar";
            this.PesqisaRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PesqisaRelatorio.UseVisualStyleBackColor = true;
            this.PesqisaRelatorio.Click += new System.EventHandler(this.incluirRelatorioBtn_Click);
            // 
            // EmAbertoCbx
            // 
            this.EmAbertoCbx.AutoSize = true;
            this.EmAbertoCbx.Checked = true;
            this.EmAbertoCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EmAbertoCbx.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.EmAbertoCbx.Location = new System.Drawing.Point(386, 51);
            this.EmAbertoCbx.Name = "EmAbertoCbx";
            this.EmAbertoCbx.Size = new System.Drawing.Size(90, 22);
            this.EmAbertoCbx.TabIndex = 41;
            this.EmAbertoCbx.Text = "Em Aberto";
            this.EmAbertoCbx.UseVisualStyleBackColor = true;
            this.EmAbertoCbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BaixadoCbx
            // 
            this.BaixadoCbx.AutoSize = true;
            this.BaixadoCbx.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.BaixadoCbx.Location = new System.Drawing.Point(492, 51);
            this.BaixadoCbx.Name = "BaixadoCbx";
            this.BaixadoCbx.Size = new System.Drawing.Size(76, 22);
            this.BaixadoCbx.TabIndex = 42;
            this.BaixadoCbx.Text = "Baixado";
            this.BaixadoCbx.UseVisualStyleBackColor = true;
            this.BaixadoCbx.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FrmPesquisaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 530);
            this.Controls.Add(this.BaixadoCbx);
            this.Controls.Add(this.EmAbertoCbx);
            this.Controls.Add(this.dataGridPesquisaPrincipal);
            this.Controls.Add(this.PesqisaRelatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pesquisaClienteTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesquisaAtendenteTbx);
            this.Controls.Add(this.DtaInclusaoLbl);
            this.Controls.Add(this.pesquisaRequisitoTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPesquisaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisaRelatorio_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPesquisaRelatorio_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.controle_relatorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlerelatorioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlerelatorioDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label DtaInclusaoLbl;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesquisaAtendenteTbx;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pesquisaClienteTbx;
        public System.Windows.Forms.Button PesqisaRelatorio;
        private System.Windows.Forms.BindingSource controlerelatorioDataSetBindingSource;
        private controle_relatorioDataSet controle_relatorioDataSet;
        public System.Windows.Forms.DataGridView dataGridPesquisaPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.BindingSource controlerelatorioDataSetBindingSource1;
        public System.Windows.Forms.TextBox pesquisaRequisitoTbx;
        private System.Windows.Forms.CheckBox EmAbertoCbx;
        private System.Windows.Forms.CheckBox BaixadoCbx;
    }
}