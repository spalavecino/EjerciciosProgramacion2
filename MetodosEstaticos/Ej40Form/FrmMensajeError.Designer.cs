namespace Ej40Form
{
    partial class FrmMensajeError
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
            this.txtMensajeError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMensajeError
            // 
            this.txtMensajeError.Location = new System.Drawing.Point(1, 29);
            this.txtMensajeError.Name = "txtMensajeError";
            this.txtMensajeError.Size = new System.Drawing.Size(309, 20);
            this.txtMensajeError.TabIndex = 0;
            // 
            // FrmMensajeError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 92);
            this.Controls.Add(this.txtMensajeError);
            this.Name = "FrmMensajeError";
            this.Text = "FrmMensajeError";
            this.Load += new System.EventHandler(this.FrmMensajeError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensajeError;
    }
}