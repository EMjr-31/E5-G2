using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E5_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            listArreglo.Items.Add(txtNumero.Text);
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnClick1_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            for (int i = 0; i < listArreglo.Items.Count; i++)
            {
                string valor = listArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        txt1.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txt1.Text = "No hay numeros negativos pares";
                }
            }
        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = listArreglo.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;

            for (int i = 0; i < listArreglo.Items.Count; i++)
            {
                string valor = listArreglo.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txt2.Text = porcentaje.ToString()+"%";
        }

        private void btnClick3_Click(object sender, EventArgs e)
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;

            for (int i = 0; i < listArreglo.Items.Count; i++)
            {
                string valor = listArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares++;
                }
            }
            prom = suma / cantidadimpares;
            txt3.Text = prom.ToString();
        }

        private void btnClick4_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listArreglo.Items.Count; i++)
            {
                string valor = listArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor) mayor = numero;
                }
            }
            txt4.Text = mayor.ToString();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ////asignasion para que el boton Todo ejecute los metodos de los demas botones
            btnTodo.Click += new EventHandler(btnClick1_Click);
            btnTodo.Click += new EventHandler(btnClick2_Click);
            btnTodo.Click += new EventHandler(btnClick3_Click);
            btnTodo.Click += new EventHandler(btnClick4_Click);
        }
    }
}
