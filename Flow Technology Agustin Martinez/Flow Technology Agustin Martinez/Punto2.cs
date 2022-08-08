using Prueba_Flow_Technology_Agustin_Martinez;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Technology_Agustin_Martinez
{
    public partial class Punto2 : Form
    {
        public Punto2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = (int)numericUpDown1.Value;
            ArrayList Lista = new ArrayList();
            Lista = ListaFactoriales(numero);
            double total = 0;
            foreach (int dato in Lista)
            {
                total += dato;
            }
            double promedio = total / (Lista.Count);
            label2.Text = "Promedio de los factoriales de 1 a " + numero + " = " + Math.Round(promedio, 2).ToString("#.#0");
        }

        private ArrayList ListaFactoriales(int numero)
        {
            ArrayList lista = new ArrayList();
            Factorial f = new Factorial();
            int i = numero;
            while (i > 0)
            {
                lista.Add(f.FactorialN(i));
                i--;
            }
            lista.Reverse();
            return lista;
        }
    }
}
