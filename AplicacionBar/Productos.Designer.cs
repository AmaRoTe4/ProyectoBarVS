namespace AplicacionBar
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.btn_nosotros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_productos
            // 
            this.btn_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.Location = new System.Drawing.Point(317, 148);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(168, 141);
            this.btn_productos.TabIndex = 5;
            this.btn_productos.Text = "Crear Productos";
            this.btn_productos.UseVisualStyleBackColor = false;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estadisticas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estadisticas.Location = new System.Drawing.Point(87, 148);
            this.btn_estadisticas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(168, 141);
            this.btn_estadisticas.TabIndex = 6;
            this.btn_estadisticas.Text = "Todos";
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // btn_nosotros
            // 
            this.btn_nosotros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.btn_nosotros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nosotros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nosotros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nosotros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nosotros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nosotros.Location = new System.Drawing.Point(548, 148);
            this.btn_nosotros.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nosotros.Name = "btn_nosotros";
            this.btn_nosotros.Size = new System.Drawing.Size(168, 141);
            this.btn_nosotros.TabIndex = 7;
            this.btn_nosotros.Text = "Crear Clasificacion";
            this.btn_nosotros.UseVisualStyleBackColor = false;
            this.btn_nosotros.Click += new System.EventHandler(this.btn_nosotros_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nosotros);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.Button btn_nosotros;
    }
}