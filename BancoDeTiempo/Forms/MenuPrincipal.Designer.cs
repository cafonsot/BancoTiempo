namespace BancoDeTiempo
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnOfertas = new System.Windows.Forms.Button();
            this.btnDemandas = new System.Windows.Forms.Button();
            this.txtWellcome = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBandeja = new System.Windows.Forms.Button();
            this.anuncioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOfertas
            // 
            this.btnOfertas.BackColor = System.Drawing.SystemColors.Info;
            this.btnOfertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOfertas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertas.Location = new System.Drawing.Point(12, 94);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(153, 73);
            this.btnOfertas.TabIndex = 15;
            this.btnOfertas.Text = "Menu Ofertas";
            this.btnOfertas.UseVisualStyleBackColor = false;
            this.btnOfertas.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // btnDemandas
            // 
            this.btnDemandas.BackColor = System.Drawing.SystemColors.Info;
            this.btnDemandas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemandas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandas.Location = new System.Drawing.Point(12, 200);
            this.btnDemandas.Name = "btnDemandas";
            this.btnDemandas.Size = new System.Drawing.Size(153, 73);
            this.btnDemandas.TabIndex = 16;
            this.btnDemandas.Text = "Menu Demandas";
            this.btnDemandas.UseVisualStyleBackColor = false;
            this.btnDemandas.Click += new System.EventHandler(this.btnDemandas_Click);
            // 
            // txtWellcome
            // 
            this.txtWellcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtWellcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWellcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtWellcome.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWellcome.Location = new System.Drawing.Point(12, 12);
            this.txtWellcome.Name = "txtWellcome";
            this.txtWellcome.ReadOnly = true;
            this.txtWellcome.Size = new System.Drawing.Size(419, 36);
            this.txtWellcome.TabIndex = 17;
            this.txtWellcome.Text = "---";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(712, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(111, 14);
            this.txtUser.TabIndex = 18;
            this.txtUser.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 504);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(835, 23);
            this.btnLogOut.TabIndex = 30;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBandeja
            // 
            this.btnBandeja.BackColor = System.Drawing.SystemColors.Info;
            this.btnBandeja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBandeja.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBandeja.Location = new System.Drawing.Point(12, 308);
            this.btnBandeja.Name = "btnBandeja";
            this.btnBandeja.Size = new System.Drawing.Size(153, 73);
            this.btnBandeja.TabIndex = 31;
            this.btnBandeja.Text = "Bandeja Entrada";
            this.btnBandeja.UseVisualStyleBackColor = false;
            this.btnBandeja.Click += new System.EventHandler(this.btnBandeja_Click);
            // 
            // anuncioBindingSource
            // 
            this.anuncioBindingSource.DataSource = typeof(BancoDeTiempo.Anuncio);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BancoDeTiempo.Usuario);
            // 
            // MenuPrincipal
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 527);
            this.Controls.Add(this.btnBandeja);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtWellcome);
            this.Controls.Add(this.btnDemandas);
            this.Controls.Add(this.btnOfertas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco De Tiempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource anuncioBindingSource;
        private System.Windows.Forms.Button btnOfertas;
        private System.Windows.Forms.Button btnDemandas;
        private System.Windows.Forms.TextBox txtWellcome;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBandeja;
    }
}

