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
    public partial class Ejericio1 : Form
    {
        public Ejericio1()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            string nombre=txt_Nombre.Text.Trim().ToUpper();

            if (txt_Nombre.Text == " ")
            {
                MessageBox.Show("No se puede agregar nombres vacios");
                return;
            }

            foreach (object var in lb_listaNombresIzq.Items)
            {
                if (var.ToString().ToUpper() == nombre)
                {
                    MessageBox.Show("No se puede agregar nombres repetido");
                 bandera = true;
                  
                }
             
             }
            if (bandera)
            {
                txt_Nombre.Text = string.Empty;
                return;
            }

           lb_listaNombresIzq.Items.Add(nombre.Trim());
            //txt_Nombre.Text = " ";
            txt_Nombre.Text= string.Empty;
        }

        private void btn_itemDer_Click(object sender, EventArgs e)
        {
            if (lb_listaNombresIzq.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE UN ITEM "); 
                return;
            }
            lb_listaNombreDer.Items.Add(lb_listaNombresIzq.SelectedItem);//en la lista de la derecha voy a agregar  los items de la izquierda selccionadas
            //ahora remuevo los items selelciones,para que desaparezcan los que si fueron seleccionados
            lb_listaNombresIzq.Items.Remove(lb_listaNombresIzq.SelectedItem);
        }

        private void btn_itemDerTodos_Click(object sender, EventArgs e)
        {
            foreach(object nombreIzquierda in lb_listaNombresIzq.Items)
            {
                lb_listaNombreDer.Items.Add(nombreIzquierda);
    
            }
            lb_listaNombresIzq.Items.Clear();//me borra todo lo de la lista, luego de q agrege todo
            
        }
    }
}
