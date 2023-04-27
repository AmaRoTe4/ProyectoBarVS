namespace AplicacionBar
{
    partial class FechaIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FechaIndividual));
            this.DataDay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Label_Cantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataDay
            // 
            this.DataDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDay.Location = new System.Drawing.Point(12, 108);
            this.DataDay.Name = "DataDay";
            this.DataDay.Size = new System.Drawing.Size(776, 276);
            this.DataDay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Precio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Label_Cantidad);
            this.panel1.Location = new System.Drawing.Point(12, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 26);
            this.panel1.TabIndex = 2;
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.BackColor = System.Drawing.Color.Transparent;
            this.Label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Precio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Precio.Location = new System.Drawing.Point(553, 1);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(71, 25);
            this.Label_Precio.TabIndex = 2;
            this.Label_Precio.Text = "precio";
            this.Label_Precio.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_Cantidad
            // 
            this.Label_Cantidad.AutoSize = true;
            this.Label_Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.Label_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Cantidad.Location = new System.Drawing.Point(392, 1);
            this.Label_Cantidad.Name = "Label_Cantidad";
            this.Label_Cantidad.Size = new System.Drawing.Size(94, 25);
            this.Label_Cantidad.TabIndex = 3;
            this.Label_Cantidad.Text = "cantidad";
            this.Label_Cantidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // FechaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionBar.Properties.Resources.mesa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FechaIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fecha";
            this.Load += new System.EventHandler(this.fechaIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.Label Label_Cantidad;
    }
}