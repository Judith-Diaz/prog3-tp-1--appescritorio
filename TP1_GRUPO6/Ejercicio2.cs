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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
        
            string nombre= txt_nombre.Text.Trim();
        
           string apellido= txt_apellido.Text.Trim();

            bool banderaNombre=false;
            bool banderaApellido = false;

         

            if (nombre=="") 
            {
                txt_nombre.Text = "";
                txt_apellido.Text = string.Empty;
                banderaNombre = true;   

            }
            if (banderaNombre)
            {
    MessageBox.Show("Ingrese un nombre ");
          
                return;
            }
        

            if ( apellido == "")
            {
                txt_apellido.Text = string.Empty;
                txt_nombre.Text = "";
                banderaApellido = true;
            }

            if (banderaApellido)
            {
                MessageBox.Show("Ingrese un apellido ");
                 return;
            }

            if(banderaApellido==false && banderaNombre == false)
            {
                string nombreApellido = nombre.ToUpper().Trim() + " " + apellido.ToUpper().Trim();
                foreach(object var in lb_nmbreApellido.Items)
                {
                    if (var.ToString().ToUpper() == nombreApellido)
                    {
                        MessageBox.Show("El nombre y apellido ya existe ");
                        return;
                    }

                }

            }

            lb_nmbreApellido.Items.Add(nombre+" "+ apellido);
            txt_nombre.Text = " ";
            txt_apellido.Text = string.Empty;
            //funcion que me ordena por nombre alfabeticamnete
            lb_nmbreApellido.Sorted = true;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (lb_nmbreApellido.Items.Count == 0)
            {
                MessageBox.Show("no hay elementos en la lista");
                return;
            }else if (lb_nmbreApellido.SelectedIndex ==-1 )
            {
                MessageBox.Show("seleccione alguna opcion ");
                return;
            }
            while(lb_nmbreApellido.SelectedIndex != -1){//mientars el indice no sea -1, osea qeue sta vacio pasa esto
                //removeAt es para eliminar unicamnete un item seleccionado
                lb_nmbreApellido.Items.RemoveAt(lb_nmbreApellido.SelectedIndex);
            }
               
        }
    }
}
