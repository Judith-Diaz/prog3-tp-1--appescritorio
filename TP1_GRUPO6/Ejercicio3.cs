using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO6
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {


            if (chek_lista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione algun item");
                return;

            }
            lbl_Mostrar.Text = " Usted selelciono : ";
            lbl_Mostrar.Text += "genero : " + (string)(rbtn_masculino.Checked ? " Masculino"+Environment.NewLine : " Femenino" + Environment.NewLine);//pongo el que esta selecionadooo siempre las qu estdan por defecto
            lbl_Mostrar.Text += "Estado civil : " + (string)(rbtn_casado.Checked ? " casado" + Environment.NewLine : " soltero" + Environment.NewLine);
            foreach(string var in chek_lista.CheckedItems)
            {

                lbl_Mostrar.Text+= " "+var+Environment.NewLine;

            }
        }
    }
}
