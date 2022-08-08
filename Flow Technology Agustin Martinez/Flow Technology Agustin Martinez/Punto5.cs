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
    public partial class Punto5 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=Agustin; Initial Catalog=PruebaFlowTechnology; Integrated Security= true");
        public Punto5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterData2( (int) numericUpDown1.Value, textBox1.Text);
        }

        public void FilterData2(int n, string wildcard)
        {
            conexion.Open();
            string sql = $"select id, nombre, apellido, edad from personas where (edad> {n} and (nombre like '%{wildcard}%' or apellido like '%{wildcard}%')) order by edad";
            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            if (!registros.Read())
            {
                MessageBox.Show("Registro vacio");
                conexion.Close();
                return;
            }
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["id"].ToString(), registros["nombre"].ToString(), registros["apellido"].ToString(), registros["edad"].ToString());
            }
            registros.Close();
            conexion.Close();
        }
    }
}
