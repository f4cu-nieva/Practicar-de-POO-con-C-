namespace Gestor_de_tareas__con_interfaz_grafica_
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
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnContador = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(296, 73);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(166, 20);
            this.txtNombreTarea.TabIndex = 0;
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTarea.Location = new System.Drawing.Point(35, 71);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(244, 20);
            this.lblNombreTarea.TabIndex = 1;
            this.lblNombreTarea.Text = "Nombre de la tarea a agregar";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(296, 108);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(166, 21);
            this.cmbPrioridad.TabIndex = 2;
            this.cmbPrioridad.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridad_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(296, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(101, 109);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(178, 20);
            this.lblPrioridad.TabIndex = 4;
            this.lblPrioridad.Text = "Seleccionar prioridad";
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.Location = new System.Drawing.Point(105, 191);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(574, 212);
            this.lstTareas.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(264, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 37);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Gestor de tareas";
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(437, 415);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(75, 23);
            this.btnContador.TabIndex = 7;
            this.btnContador.Text = "Contador";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(247, 415);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(75, 23);
            this.btnCompletar.TabIndex = 8;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(530, 415);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(161, 20);
            this.lblContador.TabIndex = 9;
            this.lblContador.Text = "Tareas completadas: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(753, 479);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.txtNombreTarea);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label lblContador;
    }
}

