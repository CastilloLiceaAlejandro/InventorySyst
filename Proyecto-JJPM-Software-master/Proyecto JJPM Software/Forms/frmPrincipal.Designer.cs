namespace Proyecto_JJPM_Software
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1250, 530);
            this.Name = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxMax;
        private System.Windows.Forms.PictureBox pboxRestore;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblAgregarUsuario;
        private System.Windows.Forms.Label lblTituloCentral;
    }
}

