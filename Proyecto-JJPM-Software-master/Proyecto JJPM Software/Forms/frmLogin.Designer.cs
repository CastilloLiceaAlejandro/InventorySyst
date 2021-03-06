namespace Proyecto_JJPM_Software.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTituloCentral = new System.Windows.Forms.Label();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxMax = new System.Windows.Forms.PictureBox();
            this.pboxRestore = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.pboxPassVisual = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.lblTituloCentral);
            this.panelTop.Controls.Add(this.pboxMin);
            this.panelTop.Controls.Add(this.pboxMax);
            this.panelTop.Controls.Add(this.pboxRestore);
            this.panelTop.Controls.Add(this.pboxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 58);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // lblTituloCentral
            // 
            this.lblTituloCentral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCentral.AutoSize = true;
            this.lblTituloCentral.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCentral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloCentral.Location = new System.Drawing.Point(525, 9);
            this.lblTituloCentral.Name = "lblTituloCentral";
            this.lblTituloCentral.Size = new System.Drawing.Size(308, 44);
            this.lblTituloCentral.TabIndex = 8;
            this.lblTituloCentral.Text = "Inicio de Sesion";
            // 
            // pboxMin
            // 
            this.pboxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMin.ErrorImage = null;
            this.pboxMin.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxMin.InitialImage")));
            this.pboxMin.Location = new System.Drawing.Point(1091, 5);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(48, 48);
            this.pboxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxMin.TabIndex = 7;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // pboxMax
            // 
            this.pboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMax.ErrorImage = null;
            this.pboxMax.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxMax.InitialImage")));
            this.pboxMax.Location = new System.Drawing.Point(1152, 5);
            this.pboxMax.Name = "pboxMax";
            this.pboxMax.Size = new System.Drawing.Size(48, 48);
            this.pboxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxMax.TabIndex = 6;
            this.pboxMax.TabStop = false;
            this.pboxMax.Click += new System.EventHandler(this.pboxMax_Click);
            // 
            // pboxRestore
            // 
            this.pboxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxRestore.Location = new System.Drawing.Point(1152, 7);
            this.pboxRestore.Name = "pboxRestore";
            this.pboxRestore.Size = new System.Drawing.Size(48, 48);
            this.pboxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxRestore.TabIndex = 5;
            this.pboxRestore.TabStop = false;
            this.pboxRestore.Click += new System.EventHandler(this.pboxRestore_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxClose.ErrorImage = null;
            this.pboxClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxClose.InitialImage")));
            this.pboxClose.Location = new System.Drawing.Point(1220, 7);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(48, 48);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxClose.TabIndex = 4;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(582, 201);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(199, 44);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(584, 373);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(187, 44);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(562, 574);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(195, 59);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.Location = new System.Drawing.Point(562, 420);
            this.txtBoxPassword.MaxLength = 20;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '·';
            this.txtBoxPassword.Size = new System.Drawing.Size(228, 31);
            this.txtBoxPassword.TabIndex = 10;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsername.Location = new System.Drawing.Point(562, 248);
            this.txtBoxUsername.MaxLength = 20;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(228, 31);
            this.txtBoxUsername.TabIndex = 9;
            // 
            // pboxPassVisual
            // 
            this.pboxPassVisual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxPassVisual.Location = new System.Drawing.Point(797, 420);
            this.pboxPassVisual.Name = "pboxPassVisual";
            this.pboxPassVisual.Size = new System.Drawing.Size(36, 31);
            this.pboxPassVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPassVisual.TabIndex = 14;
            this.pboxPassVisual.TabStop = false;
            this.pboxPassVisual.Click += new System.EventHandler(this.pboxPassVisual_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pboxPassVisual);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxMax;
        private System.Windows.Forms.PictureBox pboxRestore;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblTituloCentral;
        private System.Windows.Forms.PictureBox pboxPassVisual;
    }
}