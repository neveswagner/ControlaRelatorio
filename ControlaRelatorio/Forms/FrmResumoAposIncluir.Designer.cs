namespace ControlaRelatorio.Forms
{
    partial class FrmResumoAposIncluir
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
            this.ResumoTbxBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ResumoTbxBox
            // 
            this.ResumoTbxBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.ResumoTbxBox.Location = new System.Drawing.Point(-3, -4);
            this.ResumoTbxBox.Name = "ResumoTbxBox";
            this.ResumoTbxBox.Size = new System.Drawing.Size(217, 111);
            this.ResumoTbxBox.TabIndex = 0;
            this.ResumoTbxBox.Text = "";
            // 
            // FrmResumoAposIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 105);
            this.Controls.Add(this.ResumoTbxBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmResumoAposIncluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmResumoAposIncluir_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ResumoTbxBox;
    }
}