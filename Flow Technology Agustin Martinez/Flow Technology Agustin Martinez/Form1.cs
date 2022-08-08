using Prueba_Flow_Technology_Agustin_Martinez;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void punto3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vea la clase Data");
        }

        private void punto1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Punto1 punto1 = new Punto1();
            punto1.Show();
        }

        private void punto2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Punto2 punto2 = new Punto2();
            punto2.Show();
        }

        private void punto4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Punto4 punto4 = new Punto4();
            punto4.Show();
        }

        private void punto5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Punto5 punto5 = new Punto5();
            punto5.Show();
        }

        private void punto6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Punto6 punto6 = new Punto6();
            punto6.Show();
        }
    }
}
