namespace AplicacionBar
{
    partial class ListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductos));
            this.GridData = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_filtro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).BeginInit();
            this.SuspendLayout();
            // 
            // GridData
            // 
            this.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridData.Location = new System.Drawing.Point(12, 120);
            this.GridData.MultiSelect = false;
            this.GridData.Name = "GridData";
            this.GridData.ReadOnly = true;
            this.GridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridData.Size = new System.Drawing.Size(776, 318);
            this.GridData.TabIndex = 2;
            this.GridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.GridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.GridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridData_CellEnter);
            this.GridData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridData_RowEnter);
            this.GridData.Enter += new System.EventHandler(this.GridData_Enter);
            this.GridData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridData_KeyDown);
            this.GridData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridData_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_filtro
            // 
            this.btn_filtro.Location = new System.Drawing.Point(12, 48);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(47, 31);
            this.btn_filtro.TabIndex = 2;
            this.btn_filtro.TabStop = false;
            this.btn_filtro.Text = "F";
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Visible = false;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GridData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaProductos_FormClosing);
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_filtro;
    }
}