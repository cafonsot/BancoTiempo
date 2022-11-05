namespace BancoDeTiempo.Forms
{
    partial class UsrAddEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textHorasAcumuladas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNombre
            // 
            this.textNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.textNombre.Location = new System.Drawing.Point(113, 50);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(235, 20);
            this.textNombre.TabIndex = 0;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BancoDeTiempo.Usuario);
            // 
            // textApellido1
            // 
            this.textApellido1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido1", true));
            this.textApellido1.Location = new System.Drawing.Point(113, 76);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(235, 20);
            this.textApellido1.TabIndex = 1;
            this.textApellido1.TextChanged += new System.EventHandler(this.textApellido1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textApellido2
            // 
            this.textApellido2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido2", true));
            this.textApellido2.Location = new System.Drawing.Point(113, 102);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(235, 20);
            this.textApellido2.TabIndex = 2;
            this.textApellido2.TextChanged += new System.EventHandler(this.textApellido2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido2:";
            // 
            // textEmail
            // 
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.textEmail.Location = new System.Drawing.Point(113, 128);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(235, 20);
            this.textEmail.TabIndex = 3;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // textTelefono
            // 
            this.textTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Telefono", true));
            this.textTelefono.Location = new System.Drawing.Point(113, 154);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(235, 20);
            this.textTelefono.TabIndex = 4;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Teléfono:";
            // 
            // textHorasAcumuladas
            // 
            this.textHorasAcumuladas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "HorasAcumuladas", true));
            this.textHorasAcumuladas.Location = new System.Drawing.Point(113, 180);
            this.textHorasAcumuladas.Name = "textHorasAcumuladas";
            this.textHorasAcumuladas.Size = new System.Drawing.Size(235, 20);
            this.textHorasAcumuladas.TabIndex = 5;
            this.textHorasAcumuladas.TextChanged += new System.EventHandler(this.textHorasAcumuladas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "HorasAcumuladas:";
            // 
            // textContraseña
            // 
            this.textContraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Contraseña", true));
            this.textContraseña.Location = new System.Drawing.Point(113, 206);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(235, 20);
            this.textContraseña.TabIndex = 6;
            this.textContraseña.TextChanged += new System.EventHandler(this.textContraseña_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(244, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aplicar cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textId
            // 
            this.textId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "UsuarioId", true));
            this.textId.Location = new System.Drawing.Point(113, 24);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(235, 20);
            this.textId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Id:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // UsrAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 278);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textHorasAcumuladas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsrAddEdit";
            this.Text = "UsrAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsrAddEdit_FormClosing);
            this.Load += new System.EventHandler(this.UsrAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHorasAcumuladas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label8;
    }
}