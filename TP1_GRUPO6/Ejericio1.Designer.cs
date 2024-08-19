namespace TP1_GRUPO6
{
    partial class Ejericio1
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
            this.lbl_IngreseNombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lb_listaNombresIzq = new System.Windows.Forms.ListBox();
            this.btn_itemDer = new System.Windows.Forms.Button();
            this.btn_itemDerTodos = new System.Windows.Forms.Button();
            this.lb_listaNombreDer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_IngreseNombre
            // 
            this.lbl_IngreseNombre.AutoSize = true;
            this.lbl_IngreseNombre.Location = new System.Drawing.Point(51, 13);
            this.lbl_IngreseNombre.Name = "lbl_IngreseNombre";
            this.lbl_IngreseNombre.Size = new System.Drawing.Size(82, 13);
            this.lbl_IngreseNombre.TabIndex = 0;
            this.lbl_IngreseNombre.Text = "Ingrese Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(174, 13);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(333, 13);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lb_listaNombresIzq
            // 
            this.lb_listaNombresIzq.FormattingEnabled = true;
            this.lb_listaNombresIzq.Location = new System.Drawing.Point(54, 90);
            this.lb_listaNombresIzq.Name = "lb_listaNombresIzq";
            this.lb_listaNombresIzq.Size = new System.Drawing.Size(120, 95);
            this.lb_listaNombresIzq.TabIndex = 3;
            // 
            // btn_itemDer
            // 
            this.btn_itemDer.Location = new System.Drawing.Point(227, 108);
            this.btn_itemDer.Name = "btn_itemDer";
            this.btn_itemDer.Size = new System.Drawing.Size(75, 23);
            this.btn_itemDer.TabIndex = 4;
            this.btn_itemDer.Text = ">";
            this.btn_itemDer.UseVisualStyleBackColor = true;
            this.btn_itemDer.Click += new System.EventHandler(this.btn_itemDer_Click);
            // 
            // btn_itemDerTodos
            // 
            this.btn_itemDerTodos.Location = new System.Drawing.Point(227, 148);
            this.btn_itemDerTodos.Name = "btn_itemDerTodos";
            this.btn_itemDerTodos.Size = new System.Drawing.Size(75, 23);
            this.btn_itemDerTodos.TabIndex = 5;
            this.btn_itemDerTodos.Text = ">>";
            this.btn_itemDerTodos.UseVisualStyleBackColor = true;
            this.btn_itemDerTodos.Click += new System.EventHandler(this.btn_itemDerTodos_Click);
            // 
            // lb_listaNombreDer
            // 
            this.lb_listaNombreDer.FormattingEnabled = true;
            this.lb_listaNombreDer.Location = new System.Drawing.Point(350, 99);
            this.lb_listaNombreDer.Name = "lb_listaNombreDer";
            this.lb_listaNombreDer.Size = new System.Drawing.Size(120, 95);
            this.lb_listaNombreDer.TabIndex = 6;
            // 
            // Ejericio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_listaNombreDer);
            this.Controls.Add(this.btn_itemDerTodos);
            this.Controls.Add(this.btn_itemDer);
            this.Controls.Add(this.lb_listaNombresIzq);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_IngreseNombre);
            this.Name = "Ejericio1";
            this.Text = "Ejericio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IngreseNombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox lb_listaNombresIzq;
        private System.Windows.Forms.Button btn_itemDer;
        private System.Windows.Forms.Button btn_itemDerTodos;
        private System.Windows.Forms.ListBox lb_listaNombreDer;
    }
}