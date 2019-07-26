namespace ControlaRelatorio.Forms
{
    partial class FrmCobrarRelatorioAtendente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataCobrarRelatorioAtndente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlerelatorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_relatorioDataSet = new ControlaRelatorio.controle_relatorioDataSet();
            this.rTxtCobrarAtendente = new System.Windows.Forms.RichTextBox();
            this.cobrarAtendenteBtn = new System.Windows.Forms.Button();
            this.AtualizadosPendenteValidacaoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataCobrarRelatorioAtndente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlerelatorioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_relatorioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataCobrarRelatorioAtndente
            // 
            this.DataCobrarRelatorioAtndente.AllowUserToAddRows = false;
            this.DataCobrarRelatorioAtndente.AllowUserToDeleteRows = false;
            this.DataCobrarRelatorioAtndente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataCobrarRelatorioAtndente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataCobrarRelatorioAtndente.AutoGenerateColumns = false;
            this.DataCobrarRelatorioAtndente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCobrarRelatorioAtndente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataCobrarRelatorioAtndente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataCobrarRelatorioAtndente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCobrarRelatorioAtndente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn27});
            this.DataCobrarRelatorioAtndente.DataSource = this.controlerelatorioDataSetBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataCobrarRelatorioAtndente.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataCobrarRelatorioAtndente.Location = new System.Drawing.Point(0, 1);
            this.DataCobrarRelatorioAtndente.Name = "DataCobrarRelatorioAtndente";
            this.DataCobrarRelatorioAtndente.ReadOnly = true;
            this.DataCobrarRelatorioAtndente.RowHeadersVisible = false;
            this.DataCobrarRelatorioAtndente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataCobrarRelatorioAtndente.Size = new System.Drawing.Size(458, 521);
            this.DataCobrarRelatorioAtndente.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Requisito";
            this.dataGridViewTextBoxColumn25.HeaderText = "Requisito";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn27.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // controlerelatorioDataSetBindingSource
            // 
            this.controlerelatorioDataSetBindingSource.DataSource = this.controle_relatorioDataSet;
            this.controlerelatorioDataSetBindingSource.Position = 0;
            // 
            // controle_relatorioDataSet
            // 
            this.controle_relatorioDataSet.DataSetName = "controle_relatorioDataSet";
            this.controle_relatorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rTxtCobrarAtendente
            // 
            this.rTxtCobrarAtendente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.rTxtCobrarAtendente.Location = new System.Drawing.Point(82, 141);
            this.rTxtCobrarAtendente.Name = "rTxtCobrarAtendente";
            this.rTxtCobrarAtendente.Size = new System.Drawing.Size(294, 235);
            this.rTxtCobrarAtendente.TabIndex = 27;
            this.rTxtCobrarAtendente.Text = "";
            this.rTxtCobrarAtendente.Visible = false;
            // 
            // cobrarAtendenteBtn
            // 
            this.cobrarAtendenteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cobrarAtendenteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.cobrarAtendenteBtn.FlatAppearance.BorderSize = 0;
            this.cobrarAtendenteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cobrarAtendenteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.cobrarAtendenteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobrarAtendenteBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrarAtendenteBtn.Image = global::ControlaRelatorio.Properties.Resources.icons8_bebê_chorando_60;
            this.cobrarAtendenteBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cobrarAtendenteBtn.Location = new System.Drawing.Point(178, 417);
            this.cobrarAtendenteBtn.Name = "cobrarAtendenteBtn";
            this.cobrarAtendenteBtn.Size = new System.Drawing.Size(72, 69);
            this.cobrarAtendenteBtn.TabIndex = 28;
            this.cobrarAtendenteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobrarAtendenteBtn.UseVisualStyleBackColor = false;
            this.cobrarAtendenteBtn.Click += new System.EventHandler(this.cobrarAtendenteBtn_Click);
            // 
            // AtualizadosPendenteValidacaoLbl
            // 
            this.AtualizadosPendenteValidacaoLbl.AutoSize = true;
            this.AtualizadosPendenteValidacaoLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AtualizadosPendenteValidacaoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizadosPendenteValidacaoLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AtualizadosPendenteValidacaoLbl.Location = new System.Drawing.Point(159, 489);
            this.AtualizadosPendenteValidacaoLbl.Name = "AtualizadosPendenteValidacaoLbl";
            this.AtualizadosPendenteValidacaoLbl.Size = new System.Drawing.Size(116, 18);
            this.AtualizadosPendenteValidacaoLbl.TabIndex = 29;
            this.AtualizadosPendenteValidacaoLbl.Text = "Cobrar Atendente";
            // 
            // FrmCobrarRelatorioAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 523);
            this.Controls.Add(this.AtualizadosPendenteValidacaoLbl);
            this.Controls.Add(this.cobrarAtendenteBtn);
            this.Controls.Add(this.rTxtCobrarAtendente);
            this.Controls.Add(this.DataCobrarRelatorioAtndente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmCobrarRelatorioAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCobrarRelatorioAtendente";
            this.Load += new System.EventHandler(this.FrmCobrarRelatorioAtendente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCobrarRelatorioAtendente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DataCobrarRelatorioAtndente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlerelatorioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_relatorioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataCobrarRelatorioAtndente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.BindingSource controlerelatorioDataSetBindingSource;
        private controle_relatorioDataSet controle_relatorioDataSet;
        public System.Windows.Forms.Button cobrarAtendenteBtn;
        private System.Windows.Forms.RichTextBox rTxtCobrarAtendente;
        public System.Windows.Forms.Label AtualizadosPendenteValidacaoLbl;
    }
}