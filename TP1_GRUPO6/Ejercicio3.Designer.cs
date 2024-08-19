namespace TP1_GRUPO6
{
    partial class Ejercicio3
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
            this.cajaSexo = new System.Windows.Forms.GroupBox();
            this.cajaEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtn_femenino = new System.Windows.Forms.RadioButton();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.rbtn_casado = new System.Windows.Forms.RadioButton();
            this.rbtn_soltero = new System.Windows.Forms.RadioButton();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lbl_MsjElemntoSelec = new System.Windows.Forms.Label();
            this.lbl_mostrarSeleccion = new System.Windows.Forms.Label();
            this.lbl_Mostrar = new System.Windows.Forms.Label();
            this.chek_lista = new System.Windows.Forms.CheckedListBox();
            this.cajaSexo.SuspendLayout();
            this.cajaEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // cajaSexo
            // 
            this.cajaSexo.Controls.Add(this.rbtn_masculino);
            this.cajaSexo.Controls.Add(this.rbtn_femenino);
            this.cajaSexo.Location = new System.Drawing.Point(44, 48);
            this.cajaSexo.Name = "cajaSexo";
            this.cajaSexo.Size = new System.Drawing.Size(130, 128);
            this.cajaSexo.TabIndex = 0;
            this.cajaSexo.TabStop = false;
            this.cajaSexo.Text = "Sexo";
            // 
            // cajaEstadoCivil
            // 
            this.cajaEstadoCivil.Controls.Add(this.rbtn_soltero);
            this.cajaEstadoCivil.Controls.Add(this.rbtn_casado);
            this.cajaEstadoCivil.Location = new System.Drawing.Point(243, 50);
            this.cajaEstadoCivil.Name = "cajaEstadoCivil";
            this.cajaEstadoCivil.Size = new System.Drawing.Size(170, 125);
            this.cajaEstadoCivil.TabIndex = 1;
            this.cajaEstadoCivil.TabStop = false;
            this.cajaEstadoCivil.Text = "Estado civil";
            // 
            // rbtn_femenino
            // 
            this.rbtn_femenino.AutoSize = true;
            this.rbtn_femenino.Checked = true;
            this.rbtn_femenino.Location = new System.Drawing.Point(7, 33);
            this.rbtn_femenino.Name = "rbtn_femenino";
            this.rbtn_femenino.Size = new System.Drawing.Size(71, 17);
            this.rbtn_femenino.TabIndex = 0;
            this.rbtn_femenino.TabStop = true;
            this.rbtn_femenino.Text = "Femenino";
            this.rbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Location = new System.Drawing.Point(7, 68);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(73, 17);
            this.rbtn_masculino.TabIndex = 1;
            this.rbtn_masculino.Text = "Masculino";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // rbtn_casado
            // 
            this.rbtn_casado.AutoSize = true;
            this.rbtn_casado.Checked = true;
            this.rbtn_casado.Location = new System.Drawing.Point(36, 31);
            this.rbtn_casado.Name = "rbtn_casado";
            this.rbtn_casado.Size = new System.Drawing.Size(61, 17);
            this.rbtn_casado.TabIndex = 0;
            this.rbtn_casado.TabStop = true;
            this.rbtn_casado.Text = "Casado";
            this.rbtn_casado.UseVisualStyleBackColor = true;
            // 
            // rbtn_soltero
            // 
            this.rbtn_soltero.AutoSize = true;
            this.rbtn_soltero.Location = new System.Drawing.Point(36, 66);
            this.rbtn_soltero.Name = "rbtn_soltero";
            this.rbtn_soltero.Size = new System.Drawing.Size(58, 17);
            this.rbtn_soltero.TabIndex = 1;
            this.rbtn_soltero.Text = "Soltero";
            this.rbtn_soltero.UseVisualStyleBackColor = true;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(144, 312);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(192, 23);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Mostrar lo que se Seleccionó";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lbl_MsjElemntoSelec
            // 
            this.lbl_MsjElemntoSelec.AutoSize = true;
            this.lbl_MsjElemntoSelec.Location = new System.Drawing.Point(79, 305);
            this.lbl_MsjElemntoSelec.Name = "lbl_MsjElemntoSelec";
            this.lbl_MsjElemntoSelec.Size = new System.Drawing.Size(0, 13);
            this.lbl_MsjElemntoSelec.TabIndex = 3;
            // 
            // lbl_mostrarSeleccion
            // 
            this.lbl_mostrarSeleccion.AutoSize = true;
            this.lbl_mostrarSeleccion.Location = new System.Drawing.Point(100, 305);
            this.lbl_mostrarSeleccion.Name = "lbl_mostrarSeleccion";
            this.lbl_mostrarSeleccion.Size = new System.Drawing.Size(0, 13);
            this.lbl_mostrarSeleccion.TabIndex = 4;
            // 
            // lbl_Mostrar
            // 
            this.lbl_Mostrar.AutoSize = true;
            this.lbl_Mostrar.Location = new System.Drawing.Point(100, 346);
            this.lbl_Mostrar.Name = "lbl_Mostrar";
            this.lbl_Mostrar.Size = new System.Drawing.Size(0, 13);
            this.lbl_Mostrar.TabIndex = 5;
            // 
            // chek_lista
            // 
            this.chek_lista.FormattingEnabled = true;
            this.chek_lista.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de Pc",
            "Reparador de PC",
            "Tester"});
            this.chek_lista.Location = new System.Drawing.Point(169, 197);
            this.chek_lista.Name = "chek_lista";
            this.chek_lista.Size = new System.Drawing.Size(150, 79);
            this.chek_lista.TabIndex = 6;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chek_lista);
            this.Controls.Add(this.lbl_Mostrar);
            this.Controls.Add(this.lbl_mostrarSeleccion);
            this.Controls.Add(this.lbl_MsjElemntoSelec);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.cajaEstadoCivil);
            this.Controls.Add(this.cajaSexo);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.cajaSexo.ResumeLayout(false);
            this.cajaSexo.PerformLayout();
            this.cajaEstadoCivil.ResumeLayout(false);
            this.cajaEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cajaSexo;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.RadioButton rbtn_femenino;
        private System.Windows.Forms.GroupBox cajaEstadoCivil;
        private System.Windows.Forms.RadioButton rbtn_soltero;
        private System.Windows.Forms.RadioButton rbtn_casado;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label lbl_MsjElemntoSelec;
        private System.Windows.Forms.Label lbl_mostrarSeleccion;
        private System.Windows.Forms.Label lbl_Mostrar;
        private System.Windows.Forms.CheckedListBox chek_lista;
    }
}