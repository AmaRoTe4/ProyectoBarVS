namespace AplicacionBar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_mesas = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_nosotros = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mesas
            // 
            this.btn_mesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_mesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mesas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_mesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mesas.Location = new System.Drawing.Point(116, 170);
            this.btn_mesas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_mesas.Name = "btn_mesas";
            this.btn_mesas.Size = new System.Drawing.Size(168, 141);
            this.btn_mesas.TabIndex = 0;
            this.btn_mesas.Text = "Mesas";
            this.btn_mesas.UseVisualStyleBackColor = false;
            this.btn_mesas.Click += new System.EventHandler(this.btn_mesas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.Location = new System.Drawing.Point(337, 170);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(168, 141);
            this.btn_productos.TabIndex = 1;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = false;
            this.btn_productos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nosotros
            // 
            this.btn_nosotros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_nosotros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nosotros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nosotros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nosotros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nosotros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nosotros.Location = new System.Drawing.Point(662, 341);
            this.btn_nosotros.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nosotros.Name = "btn_nosotros";
            this.btn_nosotros.Size = new System.Drawing.Size(168, 141);
            this.btn_nosotros.TabIndex = 3;
            this.btn_nosotros.Text = "Nosotros";
            this.btn_nosotros.UseVisualStyleBackColor = false;
            this.btn_nosotros.Visible = false;
            this.btn_nosotros.Click += new System.EventHandler(this.btn_nosotros_Click);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estadisticas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estadisticas.Location = new System.Drawing.Point(567, 170);
            this.btn_estadisticas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(168, 141);
            this.btn_estadisticas.TabIndex = 2;
            this.btn_estadisticas.Text = "Estadisticas";
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 491);
            this.Controls.Add(this.btn_nosotros);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_mesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mesas;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_nosotros;
        private System.Windows.Forms.Button btn_estadisticas;
    }
}

