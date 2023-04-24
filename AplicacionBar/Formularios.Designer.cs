namespace AplicacionBar
{
    partial class Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formularios));
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.cmbBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_clas = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.btn_funcion = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.text_comprobacion = new System.Windows.Forms.Label();
            this.btn_editarClas = new System.Windows.Forms.Button();
            this.cmBoxClasEdit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_precio
            // 
            this.textBox_precio.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_precio.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_precio.Location = new System.Drawing.Point(274, 192);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(257, 24);
            this.textBox_precio.TabIndex = 1;
            this.textBox_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_KeyPress);
            // 
            // cmbBoxClass
            // 
            this.cmbBoxClass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxClass.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbBoxClass.FormattingEnabled = true;
            this.cmbBoxClass.Location = new System.Drawing.Point(274, 253);
            this.cmbBoxClass.Name = "cmbBoxClass";
            this.cmbBoxClass.Size = new System.Drawing.Size(257, 33);
            this.cmbBoxClass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(274, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.BackColor = System.Drawing.Color.Transparent;
            this.label_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.ForeColor = System.Drawing.SystemColors.Control;
            this.label_precio.Location = new System.Drawing.Point(274, 165);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(64, 24);
            this.label_precio.TabIndex = 4;
            this.label_precio.Text = "Precio";
            // 
            // label_clas
            // 
            this.label_clas.AutoSize = true;
            this.label_clas.BackColor = System.Drawing.Color.Transparent;
            this.label_clas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clas.ForeColor = System.Drawing.SystemColors.Control;
            this.label_clas.Location = new System.Drawing.Point(274, 226);
            this.label_clas.Name = "label_clas";
            this.label_clas.Size = new System.Drawing.Size(114, 24);
            this.label_clas.TabIndex = 5;
            this.label_clas.Text = "Clasificacion";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_nombre.Location = new System.Drawing.Point(274, 131);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(257, 24);
            this.textBox_nombre.TabIndex = 6;
            // 
            // btn_funcion
            // 
            this.btn_funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_funcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_funcion.Location = new System.Drawing.Point(315, 311);
            this.btn_funcion.Name = "btn_funcion";
            this.btn_funcion.Size = new System.Drawing.Size(174, 49);
            this.btn_funcion.TabIndex = 7;
            this.btn_funcion.Text = "Agregar";
            this.btn_funcion.UseVisualStyleBackColor = false;
            this.btn_funcion.Click += new System.EventHandler(this.btn_funcion_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(315, 378);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(174, 49);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Visible = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // text_comprobacion
            // 
            this.text_comprobacion.AutoSize = true;
            this.text_comprobacion.Location = new System.Drawing.Point(17, 40);
            this.text_comprobacion.Name = "text_comprobacion";
            this.text_comprobacion.Size = new System.Drawing.Size(0, 13);
            this.text_comprobacion.TabIndex = 9;
            // 
            // btn_editarClas
            // 
            this.btn_editarClas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(233)))));
            this.btn_editarClas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarClas.Location = new System.Drawing.Point(12, 317);
            this.btn_editarClas.Name = "btn_editarClas";
            this.btn_editarClas.Size = new System.Drawing.Size(75, 43);
            this.btn_editarClas.TabIndex = 10;
            this.btn_editarClas.Text = "Editar";
            this.btn_editarClas.UseVisualStyleBackColor = false;
            this.btn_editarClas.Visible = false;
            this.btn_editarClas.Click += new System.EventHandler(this.btn_editarClas_Click);
            // 
            // cmBoxClasEdit
            // 
            this.cmBoxClasEdit.FormattingEnabled = true;
            this.cmBoxClasEdit.Location = new System.Drawing.Point(12, 378);
            this.cmBoxClasEdit.Name = "cmBoxClasEdit";
            this.cmBoxClasEdit.Size = new System.Drawing.Size(121, 21);
            this.cmBoxClasEdit.TabIndex = 11;
            this.cmBoxClasEdit.Visible = false;
            // 
            // Formularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmBoxClasEdit);
            this.Controls.Add(this.btn_editarClas);
            this.Controls.Add(this.text_comprobacion);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_funcion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_clas);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxClass);
            this.Controls.Add(this.textBox_precio);
            this.Name = "Formularios";
            this.Text = "Formularios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formularios_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.ComboBox cmbBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_clas;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button btn_funcion;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label text_comprobacion;
        private System.Windows.Forms.Button btn_editarClas;
        private System.Windows.Forms.ComboBox cmBoxClasEdit;
    }
}