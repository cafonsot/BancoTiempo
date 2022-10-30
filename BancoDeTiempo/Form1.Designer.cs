namespace BancoDeTiempo
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUsrAñadir = new System.Windows.Forms.Button();
            this.btnUsrEditar = new System.Windows.Forms.Button();
            this.btnUsrEliminar = new System.Windows.Forms.Button();
            this.btnAnuEliminar = new System.Windows.Forms.Button();
            this.btnAnuEditar = new System.Windows.Forms.Button();
            this.btnAnuAñadir = new System.Windows.Forms.Button();
            this.idAnuncioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anuncioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasAcumuladasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.horasAcumuladasDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnuncioDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.anuncioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(844, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Tabla Usuario:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(13, 302);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Tabla Anuncio:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnUsrAñadir
            // 
            this.btnUsrAñadir.Location = new System.Drawing.Point(13, 195);
            this.btnUsrAñadir.Name = "btnUsrAñadir";
            this.btnUsrAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnUsrAñadir.TabIndex = 4;
            this.btnUsrAñadir.Text = "Añadir";
            this.btnUsrAñadir.UseVisualStyleBackColor = true;
            this.btnUsrAñadir.Click += new System.EventHandler(this.btnUsrAñadir_Click);
            // 
            // btnUsrEditar
            // 
            this.btnUsrEditar.Location = new System.Drawing.Point(94, 194);
            this.btnUsrEditar.Name = "btnUsrEditar";
            this.btnUsrEditar.Size = new System.Drawing.Size(75, 23);
            this.btnUsrEditar.TabIndex = 5;
            this.btnUsrEditar.Text = "Editar";
            this.btnUsrEditar.UseVisualStyleBackColor = true;
            this.btnUsrEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsrEliminar
            // 
            this.btnUsrEliminar.Location = new System.Drawing.Point(175, 195);
            this.btnUsrEliminar.Name = "btnUsrEliminar";
            this.btnUsrEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnUsrEliminar.TabIndex = 6;
            this.btnUsrEliminar.Text = "Eliminar";
            this.btnUsrEliminar.UseVisualStyleBackColor = true;
            this.btnUsrEliminar.Click += new System.EventHandler(this.btnUsrEliminar_Click);
            // 
            // btnAnuEliminar
            // 
            this.btnAnuEliminar.Location = new System.Drawing.Point(175, 484);
            this.btnAnuEliminar.Name = "btnAnuEliminar";
            this.btnAnuEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnAnuEliminar.TabIndex = 9;
            this.btnAnuEliminar.Text = "Eliminar";
            this.btnAnuEliminar.UseVisualStyleBackColor = true;
            this.btnAnuEliminar.Click += new System.EventHandler(this.btnAnuEliminar_Click);
            // 
            // btnAnuEditar
            // 
            this.btnAnuEditar.Location = new System.Drawing.Point(94, 483);
            this.btnAnuEditar.Name = "btnAnuEditar";
            this.btnAnuEditar.Size = new System.Drawing.Size(75, 23);
            this.btnAnuEditar.TabIndex = 8;
            this.btnAnuEditar.Text = "Editar";
            this.btnAnuEditar.UseVisualStyleBackColor = true;
            this.btnAnuEditar.Click += new System.EventHandler(this.btnAnuEditar_Click);
            // 
            // btnAnuAñadir
            // 
            this.btnAnuAñadir.Location = new System.Drawing.Point(13, 484);
            this.btnAnuAñadir.Name = "btnAnuAñadir";
            this.btnAnuAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnuAñadir.TabIndex = 7;
            this.btnAnuAñadir.Text = "Añadir";
            this.btnAnuAñadir.UseVisualStyleBackColor = true;
            this.btnAnuAñadir.Click += new System.EventHandler(this.btnAnuAñadir_Click);
            // 
            // idAnuncioDataGridViewTextBoxColumn
            // 
            this.idAnuncioDataGridViewTextBoxColumn.DataPropertyName = "idAnuncio";
            this.idAnuncioDataGridViewTextBoxColumn.HeaderText = "idAnuncio";
            this.idAnuncioDataGridViewTextBoxColumn.Name = "idAnuncioDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // anuncioBindingSource
            // 
            this.anuncioBindingSource.DataSource = typeof(BancoDeTiempo.Anuncio);
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // horasAcumuladasDataGridViewTextBoxColumn
            // 
            this.horasAcumuladasDataGridViewTextBoxColumn.DataPropertyName = "HorasAcumuladas";
            this.horasAcumuladasDataGridViewTextBoxColumn.HeaderText = "HorasAcumuladas";
            this.horasAcumuladasDataGridViewTextBoxColumn.Name = "horasAcumuladasDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BancoDeTiempo.Usuario);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(868, 673);
            this.Controls.Add(this.btnAnuEliminar);
            this.Controls.Add(this.btnAnuEditar);
            this.Controls.Add(this.btnAnuAñadir);
            this.Controls.Add(this.btnUsrEliminar);
            this.Controls.Add(this.btnUsrEditar);
            this.Controls.Add(this.btnUsrAñadir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUsrAñadir;
        private System.Windows.Forms.Button btnUsrEditar;
        private System.Windows.Forms.Button btnUsrEliminar;
        private System.Windows.Forms.Button btnAnuEliminar;
        private System.Windows.Forms.Button btnAnuEditar;
        private System.Windows.Forms.Button btnAnuAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasAcumuladasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnuncioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource anuncioBindingSource;
    }
}

