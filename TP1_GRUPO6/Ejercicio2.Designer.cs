namespace TP1_GRUPO6
{
    partial class Ejercicio2
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
            this.gbx_ingresoDatos = new System.Windows.Forms.GroupBox();
            this.gbx_elementos = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.lb_nmbreApellido = new System.Windows.Forms.ListBox();
            this.gbx_ingresoDatos.SuspendLayout();
            this.gbx_elementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_ingresoDatos
            // 
            this.gbx_ingresoDatos.Controls.Add(this.btn_aceptar);
            this.gbx_ingresoDatos.Controls.Add(this.txt_apellido);
            this.gbx_ingresoDatos.Controls.Add(this.txt_nombre);
            this.gbx_ingresoDatos.Controls.Add(this.lbl_apellido);
            this.gbx_ingresoDatos.Controls.Add(this.lbl_nombre);
            this.gbx_ingresoDatos.Location = new System.Drawing.Point(26, 25);
            this.gbx_ingresoDatos.Name = "gbx_ingresoDatos";
            this.gbx_ingresoDatos.Size = new System.Drawing.Size(299, 401);
            this.gbx_ingresoDatos.TabIndex = 0;
            this.gbx_ingresoDatos.TabStop = false;
            this.gbx_ingresoDatos.Text = "Ingreso de Datos";
            // 
            // gbx_elementos
            // 
            this.gbx_elementos.Controls.Add(this.lb_nmbreApellido);
            this.gbx_elementos.Controls.Add(this.btn_borrar);
            this.gbx_elementos.Location = new System.Drawing.Point(349, 25);
            this.gbx_elementos.Name = "gbx_elementos";
            this.gbx_elementos.Size = new System.Drawing.Size(304, 401);
            this.gbx_elementos.TabIndex = 1;
            this.gbx_elementos.TabStop = false;
            this.gbx_elementos.Text = "Elementos";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(16, 95);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(16, 129);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(52, 13);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(94, 92);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(94, 122);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(83, 238);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(74, 279);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(114, 23);
            this.btn_borrar.TabIndex = 1;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // lb_nmbreApellido
            // 
            this.lb_nmbreApellido.FormattingEnabled = true;
            this.lb_nmbreApellido.Location = new System.Drawing.Point(35, 36);
            this.lb_nmbreApellido.Name = "lb_nmbreApellido";
            this.lb_nmbreApellido.Size = new System.Drawing.Size(241, 225);
            this.lb_nmbreApellido.TabIndex = 2;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 428);
            this.Controls.Add(this.gbx_elementos);
            this.Controls.Add(this.gbx_ingresoDatos);
            this.Name = "Ejercicio2";
            this.Text = "Nombre y Apellido";
            this.gbx_ingresoDatos.ResumeLayout(false);
            this.gbx_ingresoDatos.PerformLayout();
            this.gbx_elementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_ingresoDatos;
        private System.Windows.Forms.GroupBox gbx_elementos;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.ListBox lb_nmbreApellido;
    }
}