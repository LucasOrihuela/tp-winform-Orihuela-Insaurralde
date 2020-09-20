namespace tp1_WinForm
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.PicArticulo = new System.Windows.Forms.PictureBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(728, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(206, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(728, 331);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(206, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(728, 380);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(206, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(38, 32);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.Size = new System.Drawing.Size(644, 364);
            this.DgvArticulos.TabIndex = 5;
            this.DgvArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvArticulos_MouseClick);
            // 
            // PicArticulo
            // 
            this.PicArticulo.Location = new System.Drawing.Point(728, 76);
            this.PicArticulo.Name = "PicArticulo";
            this.PicArticulo.Size = new System.Drawing.Size(206, 200);
            this.PicArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicArticulo.TabIndex = 6;
            this.PicArticulo.TabStop = false;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(728, 32);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(206, 20);
            this.TxtFiltro.TabIndex = 7;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.PicArticulo);
            this.Controls.Add(this.DgvArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.PictureBox PicArticulo;
        private System.Windows.Forms.TextBox TxtFiltro;
    }
}

