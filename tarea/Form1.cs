using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(valor1.Text);
            int v2 = Convert.ToInt32(valor2.Text);
            int respuesta;

            if(cmbSeleccionar.SelectedIndex == -1)
            {
                MessageBox.Show("no has seleccionado nada");
            }
            else
            {
                switch (cmbSeleccionar.SelectedItem.ToString())
                {
                    case "Sumar":
                        respuesta = v1 + v2;
                        textBox1.Text = respuesta.ToString();
                        break;

                    case "Restar":
                        respuesta = v1 - v2;
                        textBox1.Text = respuesta.ToString();
                        break;

                    case "Multiplicar":
                        respuesta = v1 * v2;
                        textBox1.Text = respuesta.ToString();
                        break;

                    case "Dsividir":
                        respuesta = v1 / v2;
                        textBox1.Text = respuesta.ToString();
                        break;

                    default:
                        MessageBox.Show("no se reconoce el valor ingresado");
                        break;
                }
            }
        }
    }
}
