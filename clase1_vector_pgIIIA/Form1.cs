using clase1_vector_pgIIIA.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase1_vector_pgIIIA
{
    public partial class Form1 : Form
    {
        public Vector Vnotas = new Vector();
        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
            Vnotas.cargar(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (contador <= 9)
                {
                    MessageBox.Show(Vnotas.IngresarDatosVector(Convert.ToDouble(textBox1.Text)));
                    listBox1.Items.Add(contador);
                    listBox2.Items.Add(textBox1.Text);
                    contador++;
                }
                else
                {
                    MessageBox.Show("El Vector esta lleno");
                }
            }else
            {
                MessageBox.Show("No se permiten Valores Nulos.");
            }
            Limpiar();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) <= 9)
            {
                var valor = Vnotas.retornarValor(Convert.ToInt32(textBox2.Text));
                label6.Text = valor.ToString();
            } else
            {
                MessageBox.Show("El vector solamente tiene posicion del 0 al 9.");
            }
            Limpiar();
        }

        public void Limpiar()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Vnotas.asignarValor(Convert.ToInt32(textBox2.Text), 0));
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            CargarDatos();
            Limpiar();
        }

        public void CargarDatos()
        {
            for (int i = 0; i <= 9; i++)
            {
                var valor = Vnotas.retornarValor(i);
                listBox1.Items.Add(i);
                listBox2.Items.Add(valor);
            }
        }
    }
}
