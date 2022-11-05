namespace BancoDeTiempo.Forms
{
    partial class AnuAddEdit
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
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.anuncioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria:";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(86, 48);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(202, 20);
            this.textCategoria.TabIndex = 1;
            this.textCategoria.TextChanged += new System.EventHandler(this.textCategoria_TextChanged);
            // 
            // textDescripcion
            // 
            this.textDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anuncioBindingSource, "Descripcion", true));
            this.textDescripcion.Location = new System.Drawing.Point(86, 74);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(202, 45);
            this.textDescripcion.TabIndex = 3;
            this.textDescripcion.TextChanged += new System.EventHandler(this.textDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // textFecha
            // 
            this.textFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anuncioBindingSource, "Fecha", true));
            this.textFecha.Location = new System.Drawing.Point(86, 125);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(202, 20);
            this.textFecha.TabIndex = 5;
            this.textFecha.TextChanged += new System.EventHandler(this.textFecha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(182, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aplicar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // anuncioBindingSource
            // 
            this.anuncioBindingSource.DataSource = typeof(BancoDeTiempo.Anuncio);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id:";
            // 
            // textId
            // 
            this.textId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anuncioBindingSource, "idAnuncio", true));
            this.textId.Location = new System.Drawing.Point(86, 25);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(202, 20);
            this.textId.TabIndex = 8;
            // 
            // AnuAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 198);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnuAddEdit";
            this.Text = "AnuAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnuAddEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource anuncioBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textId;
    }
}