using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Technology_Agustin_Martinez
{
    public partial class Punto6 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=Agustin; Initial Catalog=PruebaFlowTechnology; Integrated Security= true");

        public Punto6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            collectData((int)numericUpDown1.Value, textBox1.Text);
        }

        public void collectData(int n, string wildcard)
        {
            conexion.Open();
            string sql1 = "select AVG(edad) as promedio from personas;";
            SqlCommand comando = new SqlCommand(sql1, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            
            if (registros.Read())
            {
                int promedio = int.Parse(registros["promedio"].ToString());
                label3.Text = "Edad Promedio= " + promedio;
            }
            registros.Close();
            string sql2 = $" select id, nombre, apellido, edad from personas where (edad > {n} and(nombre like '%{wildcard}%' or apellido like '%{wildcard}%')) group by id, edad, nombre, apellido having edad = (select AVG(edad) + 10 from personas) or edad = (select AVG(edad) - 10 from personas)";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);
            SqlDataReader registros2 = comando2.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros2.Read())
            {
                dataGridView1.Rows.Add(registros2["id"].ToString(), registros2["nombre"].ToString(), registros2["apellido"].ToString(), registros2["edad"].ToString());
            }
            conexion.Close();
        }
    }
}
