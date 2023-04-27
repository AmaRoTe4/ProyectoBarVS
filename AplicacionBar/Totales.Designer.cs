namespace AplicacionBar
{
    partial class Totales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Totales));
            this.GridTotales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTotales
            // 
            this.GridTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTotales.Location = new System.Drawing.Point(184, 118);
            this.GridTotales.Name = "GridTotales";
            this.GridTotales.Size = new System.Drawing.Size(444, 301);
            this.GridTotales.TabIndex = 1;
            this.GridTotales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTotales_CellClick);
            this.GridTotales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTotales_CellContentClick);
            this.GridTotales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridTotales_KeyDown);
            // 
            // Totales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridTotales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Totales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totales";
            this.Load += new System.EventHandler(this.Totales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTotales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridTotales;
    }
}