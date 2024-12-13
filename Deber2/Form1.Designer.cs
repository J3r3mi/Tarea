namespace Deber2
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
            this.NombrPais = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombrPais
            // 
            this.NombrPais.AutoSize = true;
            this.NombrPais.Location = new System.Drawing.Point(35, 13);
            this.NombrPais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.NombrPais.Name = "NombrPais";
            this.NombrPais.Size = new System.Drawing.Size(58, 13);
            this.NombrPais.TabIndex = 0;
            this.NombrPais.Text = "NombrPais";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(118, 27);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(12, 55);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(159, 147);
            this.Lista.TabIndex = 3;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(38, 208);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NombrPais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombrPais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btEliminar;
    }
}

