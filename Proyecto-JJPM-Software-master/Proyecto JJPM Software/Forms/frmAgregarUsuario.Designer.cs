namespace Proyecto_JJPM_Software.Forms
{
    partial class frmAgregarUsuario
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
            this.SuspendLayout();
            // 
            // frmAgregarUsuario
            // 
            this.ClientSize = new System.Drawing.Size(971, 530);
            this.Name = "frmAgregarUsuario";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Label lblidUsuario;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblApellidoP;
		private System.Windows.Forms.Label lblApellidoM;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblIngreso;
		private System.Windows.Forms.TextBox TBPass;
		private System.Windows.Forms.TextBox TBNombre;
		private System.Windows.Forms.TextBox TBAp;
		private System.Windows.Forms.TextBox TBAm;
		private System.Windows.Forms.TextBox TBIdInsert;
		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.TextBox TBIdDelete;
		private System.Windows.Forms.Button BTNDelete;
		private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.TextBox TBNombre2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.ComboBox cBoxTipo;
        private System.Windows.Forms.PictureBox pboxPassVisual;
        private System.Windows.Forms.DateTimePicker dateTPIngreso;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTituloCentral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}