namespace ControlaRelatorio.Forms
{
    partial class FrmEscolhaGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscolhaGrid));
            this.baixarGridBtn = new System.Windows.Forms.Button();
            this.editarRelatorioBtn = new System.Windows.Forms.Button();
            this.MsgreqBaixadoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baixarGridBtn
            // 
            this.baixarGridBtn.BackColor = System.Drawing.Color.Azure;
            this.baixarGridBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.baixarGridBtn.FlatAppearance.BorderSize = 2;
            this.baixarGridBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.baixarGridBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.baixarGridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baixarGridBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baixarGridBtn.Image = global::ControlaRelatorio.Properties.Resources.icons8_downloads_48;
            this.baixarGridBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baixarGridBtn.Location = new System.Drawing.Point(23, 31);
            this.baixarGridBtn.Name = "baixarGridBtn";
            this.baixarGridBtn.Size = new System.Drawing.Size(118, 47);
            this.baixarGridBtn.TabIndex = 20;
            this.baixarGridBtn.Text = "Baixar";
            this.baixarGridBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baixarGridBtn.UseVisualStyleBackColor = false;
            this.baixarGridBtn.Click += new System.EventHandler(this.baixarGridBtn_Click);
            // 
            // editarRelatorioBtn
            // 
            this.editarRelatorioBtn.BackColor = System.Drawing.Color.Azure;
            this.editarRelatorioBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.editarRelatorioBtn.FlatAppearance.BorderSize = 2;
            this.editarRelatorioBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.editarRelatorioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.editarRelatorioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarRelatorioBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarRelatorioBtn.Image = global::ControlaRelatorio.Properties.Resources.icons8_lápis_48;
            this.editarRelatorioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editarRelatorioBtn.Location = new System.Drawing.Point(191, 31);
            this.editarRelatorioBtn.Name = "editarRelatorioBtn";
            this.editarRelatorioBtn.Size = new System.Drawing.Size(118, 47);
            this.editarRelatorioBtn.TabIndex = 19;
            this.editarRelatorioBtn.Text = "Editar";
            this.editarRelatorioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarRelatorioBtn.UseVisualStyleBackColor = false;
            this.editarRelatorioBtn.Click += new System.EventHandler(this.editarRelatorioBtn_Click);
            // 
            // MsgreqBaixadoLbl
            // 
            this.MsgreqBaixadoLbl.AutoSize = true;
            this.MsgreqBaixadoLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgreqBaixadoLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgreqBaixadoLbl.ForeColor = System.Drawing.Color.Red;
            this.MsgreqBaixadoLbl.Location = new System.Drawing.Point(101, 5);
            this.MsgreqBaixadoLbl.Name = "MsgreqBaixadoLbl";
            this.MsgreqBaixadoLbl.Size = new System.Drawing.Size(163, 23);
            this.MsgreqBaixadoLbl.TabIndex = 31;
            this.MsgreqBaixadoLbl.Text = "Requisito já Baixado ";
            this.MsgreqBaixadoLbl.Visible = false;
            // 
            // FrmEscolhaGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(334, 102);
            this.Controls.Add(this.MsgreqBaixadoLbl);
            this.Controls.Add(this.baixarGridBtn);
            this.Controls.Add(this.editarRelatorioBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmEscolhaGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEscolhaGrid_FormClosing);
            this.Load += new System.EventHandler(this.FrmEscolhaGrid_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmEscolhaGrid_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button editarRelatorioBtn;
        public System.Windows.Forms.Button baixarGridBtn;
        public System.Windows.Forms.Label MsgreqBaixadoLbl;
    }
}