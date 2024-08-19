using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO6
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            //quiero que cuando se inicialice que me tire todo los integrantes
            lblIntegrantes.Text = "integrantes : " + Environment.NewLine + "     judith diaz" + Environment.NewLine +  "     caro engel" + Environment.NewLine +  "     kloster celina" + Environment.NewLine;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejericio1 Ej1 = new Ejericio1();
            Ej1.ShowDialog();
            this.Show();
        }

        private void btn_Ej2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2 Ej2 = new Ejercicio2();
            Ej2.ShowDialog();
            this.Show();
        }

        private void btn_ej3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio3 Ej3 = new Ejercicio3();
            Ej3.ShowDialog();
            this.Show();
        }
    }
}
