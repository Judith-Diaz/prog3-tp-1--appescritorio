
namespace TP1_GRUPO6
{
    partial class Principal
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_Ej2 = new System.Windows.Forms.Button();
            this.btn_ej3 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 45);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 48);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "EJERCICIO 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn_Ej2
            // 
            this.btn_Ej2.Location = new System.Drawing.Point(199, 45);
            this.btn_Ej2.Name = "btn_Ej2";
            this.btn_Ej2.Size = new System.Drawing.Size(83, 39);
            this.btn_Ej2.TabIndex = 1;
            this.btn_Ej2.Text = "EJERCICIO 2";
            this.btn_Ej2.UseVisualStyleBackColor = true;
            this.btn_Ej2.Click += new System.EventHandler(this.btn_Ej2_Click);
            // 
            // btn_ej3
            // 
            this.btn_ej3.Location = new System.Drawing.Point(306, 45);
            this.btn_ej3.Name = "btn_ej3";
            this.btn_ej3.Size = new System.Drawing.Size(105, 39);
            this.btn_ej3.TabIndex = 2;
            this.btn_ej3.Text = "EJERCICIO 3";
            this.btn_ej3.UseVisualStyleBackColor = true;
            this.btn_ej3.Click += new System.EventHandler(this.btn_ej3_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Location = new System.Drawing.Point(90, 140);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(60, 13);
            this.lblIntegrantes.TabIndex = 3;
            this.lblIntegrantes.Text = "Integrantes";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btn_ej3);
            this.Controls.Add(this.btn_Ej2);
            this.Controls.Add(this.btn1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn_Ej2;
        private System.Windows.Forms.Button btn_ej3;
        private System.Windows.Forms.Label lblIntegrantes;
    }
}

